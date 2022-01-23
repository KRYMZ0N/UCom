using System;
using util;
using main;

namespace commands {

    public class echo : Command
    {
        InputUtil IU = new InputUtil();

        public echo(String name = "echo Command", String key = "echo") : base(name, key)
        {
            this.name = name;
            this.key = key;

        }

        public override void Start()
        {
            string[] args = IU.parseStringCom(Program.Input); 

            if (args.Length < 2)
            {
                Console.WriteLine("This is the echo command, try typing a string as an argument!");

            }

            if (args.Length >= 2)
            {
                Console.WriteLine(args[1].ToString());

            }

            if (args.Length >= 3)
            {
                Console.WriteLine("heh, try using just one argument lol");
            }

        }
    }
}