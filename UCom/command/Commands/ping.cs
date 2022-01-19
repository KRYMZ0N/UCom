using System;

namespace commands {

    public class ping : Command 
    {
        public ping(String name = "ping command", String key = "ping") : base(name, key)
        {
            this.name = name;
            this.key = key;
        }

        public override void Start() 
        {
            Console.WriteLine("Pong!");
        }
    }
}