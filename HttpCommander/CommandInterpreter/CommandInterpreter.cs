﻿using RobotCtrl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace HttpCommander
{
    class CommandInterpreter
    {
        Robot robot;
        string outputLog;
        List<Type> commandClasses = new List<Type>();

        List<AbstractRobotCommand> commandsToExecute = new List<AbstractRobotCommand>();

        public CommandInterpreter(Robot robot, string outputLog)
        {
            commandClasses.Add(typeof(TrackArcLeftCommand));
            commandClasses.Add(typeof(TrackArcRightCommand));
            commandClasses.Add(typeof(TrackLineCommand));
            commandClasses.Add(typeof(TrackTurnLeftCommand));
            commandClasses.Add(typeof(TrackTurnRightCommand));
            this.robot = robot;
            this.outputLog = outputLog;
        }


        public bool ReadCommands(StreamReader reader)
        {
            lock(this)
            {
                commandsToExecute.Clear();
                String line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] arguments = line.Split(' ');
                    if (arguments.Length <= 0) continue;

                    string command = arguments[0];
                    if (command == "") continue;

                    List<String> parameters = arguments.Skip(1).ToList();

                    bool found = false;
                    foreach (Type commandClass in commandClasses)
                    {
                        AbstractRobotCommand robotCommand = Activator.CreateInstance(commandClass) as AbstractRobotCommand;
                        if (robotCommand.GetCommandName() == command)
                        {
                            robotCommand.SetFullCommandString(line);
                            robotCommand.ParseCommand(parameters);
                            commandsToExecute.Add(robotCommand);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        if (command == "Start")
                        {
                            robot.Drive.Power = true;
                            RunCommands();
                            robot.Drive.Halt();
                            //robot.Drive.Power = false;
                            LogCommand("Start", robot.Drive.DriveInfo);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        public void RunCommands()
        {
            foreach(AbstractRobotCommand command in commandsToExecute)
            {
                System.Console.WriteLine("Running " + command.GetCommandName());
                command.RunCommand(robot);
                while (!robot.Drive.Done)
                {
                    Thread.Sleep(20);
                }
                LogCommand(command.GetFullCommandString(), robot.Drive.DriveInfo);
            }
        }

        public void LogCommand(string commandString, DriveInfo driveInfo)
        {
            using (FileStream fs = new FileStream(outputLog, FileMode.Append, FileAccess.Write, FileShare.None))
            using (StreamWriter streamWriter = new StreamWriter(fs))
            {
                streamWriter.WriteLine(DateTime.Now + ": " + commandString + "(Distance Left  = " + driveInfo.DistanceL + ", Distance Right = " + driveInfo.DistanceR + ")");
            }
        }

    }
}
