using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using commands;

namespace commands
{
    public class CommandManager
    {
       public List<Command> Coms = new List<Command>();

        public CommandManager()
        {
            Coms.Add(new HelloWorld());
            Coms.Add(new ping());
            Coms.Add(new pswrd());
        }

        public List<Command> getComs()
        {
            return Coms;
        }
    }
}
