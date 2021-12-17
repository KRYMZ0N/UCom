using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCom.me.krymz0n.ucom.command.Commands
{
    public class Command
    {
        public String name;
        public String key;

        public Command(String name, String key)
        {
            this.name = name;
            this.key = key;
        }

        public String getKey()
        {
            return key;
        }

        public String getName()
        {
            return name;
        }
    }
}
