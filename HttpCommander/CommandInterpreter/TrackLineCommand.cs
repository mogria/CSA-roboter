using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander.CommandInterpreter
{
    class TrackLineCommand : RobotCommand
    {

        private float trackLineLength = 0;
        public string GetCommandName()
        {
            return "TrackLine";
        }

        public void ParseCommand(List<string> commandParameters)
        {
            if(commandParameters.Count != 1)
            {
                throw new ArgumentException("TrackLineCommand requires one argument");
            }

            trackLineLength = float.Parse(commandParameters[0]);
        }

        public void RunCommand(Robot robot)
        {
            robot.Drive.RunLine(trackLineLength, 0.5f, 0.3f);
        }
    }
}
