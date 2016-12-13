using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander
{
    class TrackLineCommand : AbstractRobotCommand
    {

        private float trackLineLength = 0;
        public override string GetCommandName()
        {
            return "TrackLine";
        }

        public override void ParseCommand(List<string> commandParameters)
        {
            if(commandParameters.Count != 1)
            {
                throw new ArgumentException("TrackLineCommand requires one argument");
            }

            trackLineLength = float.Parse(commandParameters[0]);
        }

        public override void RunCommand(Robot robot)
        {
            robot.Drive.RunLine(trackLineLength, 0.5f, 0.3f);
        }
    }
}
