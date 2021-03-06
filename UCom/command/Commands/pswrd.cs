using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    string user = Format.ReadSpecificLine("config.ucom", 1);
            
                    using (StreamWriter sw = new StreamWriter("config.ucom", append: false))
                    {
                        sw.WriteLine(user);
                        sw.WriteLine("Pass: " + args[2]);

                        sw.Close();
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
