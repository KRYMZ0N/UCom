using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCom.me.krymz0n.ucom.command.Commands
{
    public class HelloWorld : Command
    {

        public HelloWorld(String name = "Hello World Command!", String key = "helloworld") : base(name, key)
        {
            this.name = name;
            this.key = key;
        }

        public void Start()
        {
            Console.WriteLine("HelloWorld");
        }
    }
}
