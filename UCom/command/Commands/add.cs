using System;
using util;
using main;

namespace commands
{
    public class addcom : Command
    {
        Format f = new Format();
        InputUtil IU = new InputUtil();

        public addcom(String name = "add command", String key = "add") : base(name, key)
        {
            this.name = name;
            this.key = key;
        }

        public override void Start()
        {
            string[] args = IU.parseStringCom(Program.Input); 

            if (args.Length >= 3 && f.isInteger(args[1]) && f.isInteger(args[2]))
            {
                int sum;
                int x = int.Parse(args[1]);
                int y = int.Parse(args[2]);
                sum = x + y;
                Console.WriteLine(sum);
            }
        }
    }
}