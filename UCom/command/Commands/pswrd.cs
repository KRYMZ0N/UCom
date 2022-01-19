using System;
using util;
using main;

namespace commands 
{

    public class pswrd : Command 
    {
        Program p;
        Format f = new Format();
        InputUtil IU = new InputUtil();

        public pswrd(String name = "password command", String key = "pswrd") : base(name, key) 
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
                    using (StreamWriter sw = new StreamWriter("config.ucom", append: false))
                    {
                        sw.WriteLine("User: " + f.User());
                        sw.WriteLine("Pass: " + args[2]);
                    }

                    Console.WriteLine("Password Updated Successfully!");
                }
            }

            if (args.Length < 2) 
            {
                Console.WriteLine("Insufficient Arguments");
            }
        }
    }
}


