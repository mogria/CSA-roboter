using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander
{
    class TrackTurnRightCommand : AbstractRobotCommand
    {
        private float arcAngle;

        public override string GetCommandName()
        {
            return "TrackTurnRight";
        }

        public override void ParseCommand(List<string> commandParameters)
        {
            if (commandParameters.Count != 1)
            {
                throw new ArgumentException("TrackTurnRight requires one argument");
            }
            arcAngle = (float)int.Parse(commandParameters[0]);
            arcAngle = arcAngle * (-1);
        }

        public override void RunCommand(Robot robot)
        {
            robot.Drive.RunTurn(arcAngle, 0.5f, 0.3f);
        }
    }
}