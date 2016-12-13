using RobotCtrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpCommander
{
    interface RobotCommand
    {
        String GetCommandName();

        void ParseCommand(List<String> commandParameters);

        void RunCommand(Robot robot);
    }
}
