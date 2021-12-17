using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using UCom.me.krymz0n.ucom.command.Commands;

namespace UCom.me.krymz0n.ucom.command
{
    public class CommandManager
    {
       List<Command> Coms = new List<Command>();

        public CommandManager()
        {
            Coms.Add(new HelloWorld());
        }
    }
}
