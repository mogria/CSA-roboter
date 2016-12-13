using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander.CommandInterpreter
{
    class TrackArcLeftCommand : RobotCommand
    {
        private float radiusLength;
        private float arcAngle;

        public string GetCommandName()
        {
            return "TrackArcLeft";
        }

        public void ParseCommand(List<string> commandParameters)
        {
            if (commandParameters.Count != 2)
            {
                throw new ArgumentException("TrackArcLeft requires two arguments");
            }
            arcAngle = (float)int.Parse(commandParameters[0]);
            radiusLength = float.Parse(commandParameters[1]);
        }

        public void RunCommand(Robot robot)
        {
            robot.Drive.RunArcLeft(radiusLength, arcAngle, 0.5f, 0.3f);
        }
    }
}
