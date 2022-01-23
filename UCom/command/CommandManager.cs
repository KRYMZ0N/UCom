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
       public static List<Command> Coms = new List<Command>();

        public CommandManager()
        {
            Coms.Add(new HelloWorld());
            Coms.Add(new ping());
            Coms.Add(new pswrd());
            Coms.Add(new addcom());
            Coms.Add(new Help());
            Coms.Add(new usr());
            Coms.Add(new logout());
            Coms.Add(new echo());
        }

        public static List<Command> getComs()
        {
            return Coms;
        }
    }
}
