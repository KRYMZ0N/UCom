using System;
using main;

namespace commands {

    public class logout : Command {

        public logout(String name = "logout command", String key = "logout") : base(name, key) 
        {
            this.name = name;
            this.key = key;
        }

        public override void Start()
        {
            Console.WriteLine("Shutting down!! Goodbye");

            Program.runStartupCode();

        }
    }
}