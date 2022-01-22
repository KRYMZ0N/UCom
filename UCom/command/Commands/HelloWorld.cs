using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commands
{
    public class HelloWorld : Command
    {

        public HelloWorld(String name = "Hello World Command", String key = "helloworld") : base(name, key)
        {
            this.name = name;
            this.key = key;
        }

        public override void Start()
        {
            Console.WriteLine("HelloWorld");
        }
    }
}
