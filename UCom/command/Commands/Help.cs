using System;


namespace commands {

    public class Help : Command
    {

        public Help(String name = "Help Command", String key = "help") : base(name, key) 
        {
            this.name = name;
            this.key = key;
        }

        public override void Start()
        {
            Console.WriteLine("");
            foreach (Command com in CommandManager.getComs())
            {
                Console.Write(com.getName() + ": ");
                Console.WriteLine(com.getKey());
            }

            Console.WriteLine("");
        }
    }
}