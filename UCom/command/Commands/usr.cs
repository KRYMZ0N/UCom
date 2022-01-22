using System;
using util;
using main;

namespace commands {
    
    public class usr : Command {

        InputUtil IU = new InputUtil();


        public usr(String name = "username command", String key = "usr") : base(name, key) 
        {
            this.name = name;
            this.key = key;
        }

        public override void Start()
        {
            string[] args = IU.parseStringCom(Program.Input); 

            if (args.Length >= 2 && args[1] == "change") // Checking args as usual
            {
                Console.WriteLine("Hello");
                if (args.Length >= 3) 
                {
                    string pass = Format.ReadSpecificLine("config.ucom", 2);
            
                    using (StreamWriter sw = new StreamWriter("config.ucom", append: false))
                    {
                        sw.WriteLine("User: " + args[2]);
                        sw.WriteLine(pass);

                        sw.Close();
                    }

                    Console.WriteLine("Username Updated Successfully!");
                }
            }

            if (args.Length < 2) 
            {
                Console.WriteLine("Insufficient Arguments");
            }
        }
    }
}