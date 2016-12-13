using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander
{
    class TrackArcLeftCommand : AbstractRobotCommand
    {
        private float radiusLength;
        private float arcAngle;

        public override string GetCommandName()
        {
            return "TrackArcLeft";
        }

        public override void ParseCommand(List<string> commandParameters)
        {
            if (commandParameters.Count != 2)
            {
                throw new ArgumentException("TrackArcLeft requires two arguments");
            }
            arcAngle = (float)int.Parse(commandParameters[0]);
            radiusLength = float.Parse(commandParameters[1]);
        }

        public override void RunCommand(Robot robot)
        {
            robot.Drive.RunArcLeft(radiusLength, arcAngle, 0.5f, 0.3f);
        }
    }
}
