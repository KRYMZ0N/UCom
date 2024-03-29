﻿using System;
using commands;
using util;
using loop;

namespace main 
{
    class Program
    {
        public static String? Input;
        static GameLoop GL = new GameLoop();
        static Command CM = new Command("test", "test");
        static CommandManager comMan = new CommandManager();
        static HelloWorld HW = new HelloWorld();
        static Format f = new Format();
        static Program p = new Program();
        public static void Main(string[] args)
        {

                    // All file writing stuff.
            runStartupCode();
    
            Console.WriteLine("You are Logged in!");
            Console.Write("UCom v0.0>> ");

            while (GL.isOn()) //Loop
            {
                bool temp = false;
                Input = Console.ReadLine();
                foreach (Command cm in CommandManager.getComs())
                {
                    if (Input.Contains(cm.getKey()))
                    {
                        cm.Start();
                        Console.WriteLine("You have launched: " + cm.getKey());
                        //Console.Write("UCom v0.0>> ");
                        temp = true;
                        break;
                    }
                }
                if (Input.Equals(""))
                {
                    if (temp == false)
                    Console.Write("UCom v0.0>> ");
                }
                else
                {
                    if (temp == false)
                    Console.WriteLine("I'm sorry, I am not sure what you mean, try typing something else");
                    Console.Write("UCom v0.0>> "); 
                }
            }
        }
    

        public static void runStartupCode() 
        {
            if (File.Exists("config.ucom"))
            {
                Console.WriteLine("You are prompted to log in!");

                Console.Write("User: ");
            }
            else
            {
                Console.WriteLine("Press Enter!");
                Console.Write("Login>> ");

            }

            Input = Console.ReadLine();

            String HKey = HW.getKey();

            int i = 1;

            while (i == 1)
            {

                if (File.Exists("config.ucom"))
                {

                    StreamReader sr = new StreamReader("config.ucom");

                    int j = 1;
                    int k = 1;

                    while (j == 1)
                    { // Checking to see if the users input is the pass and user. Then looping through that
                        if (f.User() != null)
                        {
                            if (!f.User().Equals(Input))
                            {
                                Console.WriteLine("You are prompted to log in!");
                                Console.Write("User: ");
                                Input = Console.ReadLine();
                            }
                            else
                            {
                                Console.Write("Pass: ");
                                Input = Console.ReadLine();
                                while (k == 1)
                                {
                                    if (f.Pass() != null)
                                    {
                                        if (!f.Pass().Equals(Input))
                                        {
                                            Console.Write("Pass: ");
                                            Input = Console.ReadLine();
                                        }
                                        else
                                        {
                                            i = 0;
                                            j = 0;
                                            k = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {

                    using (StreamWriter sw = new StreamWriter("config.ucom", append: true))
                    {
                        int l = 1;

                        while (l == 1)
                        {
                            Console.WriteLine("Please register a User!");

                            Console.Write("User: ");

                            Input = Console.ReadLine();


                            if (Input != "") 
                            {
                                string possibleUser = Input;
                                
                                Console.Write("Pass: ");

                                Input = Console.ReadLine();

                                if (Input != "") 
                                {
                                    sw.WriteLine("User: " + possibleUser);
                                    sw.WriteLine("Pass: " + Input);

                                    sw.Close();
                                    

                                    l = 0;
                                    i = 0;     
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void reform() {
            StreamReader sr = new StreamReader("config.ucom");
            using (StreamWriter sw = new StreamWriter("config.ucom", append: true))
            {
                string line1 = Format.ReadSpecificLine("config.ucom", 2);
                string line2;
            }
        }
    }
}
