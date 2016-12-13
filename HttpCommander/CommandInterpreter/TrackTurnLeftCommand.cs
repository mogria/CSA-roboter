using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander.CommandInterpreter
{
    class TrackTurnLeftCommand : RobotCommand
    {
        private float arcAngle;

        public string GetCommandName()
        {
            return "TrackTurnLeft";
        }

        public void ParseCommand(List<string> commandParameters)
        {
            if (commandParameters.Count != 1)
            {
                throw new ArgumentException("TrackTurnLeft requires one argument");
            }
            arcAngle = (float) int.Parse(commandParameters[0]);
            arcAngle = arcAngle * (-1);                         // invert for left turn

        }

        public void RunCommand(Robot robot)
        {
            robot.Drive.RunTurn(arcAngle, 0.5f, 0.3f);
        }
    }
}
