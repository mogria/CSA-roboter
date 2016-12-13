using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander.CommandInterpreter
{
    class TrackTurnRightCommand : RobotCommand
    {
        private float arcAngle;

        public string GetCommandName()
        {
            return "TrackTurnRight";
        }

        public void ParseCommand(List<string> commandParameters)
        {
            if (commandParameters.Count != 1)
            {
                throw new ArgumentException("TrackTurnRight requires one argument");
            }
            arcAngle = (float)int.Parse(commandParameters[0]);
        }

        public void RunCommand(Robot robot)
        {
            robot.Drive.RunTurn(arcAngle, 0.5f, 0.3f);
        }
    }
}