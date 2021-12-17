using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCom.me.krymz0n.ucom.command.Commands
{
    public class HelloWorld : Command
    {
        private String ModName;
        private String ModKey;

        public HelloWorld(String name, String key) : base(name, key)
        {
            ModName = name;
            ModKey = key;
        }

        public void Start()
        {
            Console.WriteLine("HelloWorld");
        }
    }
}
