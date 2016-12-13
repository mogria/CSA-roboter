using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace HttpCommander
{
    abstract class AbstractRobotCommand
    {

        private string commandString;
        public void SetFullCommandString(string commandString)
        {
            this.commandString = commandString;
        }
        public String GetFullCommandString()
        {
            return commandString;
        }

        abstract public String GetCommandName();


        abstract public void ParseCommand(List<String> commandParameters);

        abstract public void RunCommand(Robot robot);
    }
}
