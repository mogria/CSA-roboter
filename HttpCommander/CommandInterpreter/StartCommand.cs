using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander.CommandInterpreter
{
    class StartCommand : RobotCommand
    {
        public string GetCommandName()
        {
            return "Start";
        }

        public void ParseCommand(List<string> commandParameters)
        {
            if (commandParameters.Count != 0)
            {
                throw new ArgumentException("Start does not require any arguments");
            }
        }

        public void RunCommand(Robot robot)
        {
            robot.Drive.Power = true;
        }
    }
}
