using System;
using UCom.me.krymz0n.ucom.command.Commands;
using UCom.me.krymz0n.ucom.util;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello World");
        GameLoop GL = new GameLoop();
        Command CM = new Command("test", "test");
        HelloWorld HW = new HelloWorld();
        Console.WriteLine("Launched\n");
        Console.Write("UCom v0.0>> ");

        String Input = Console.ReadLine();

        String HKey = HW.getKey();

        while (GL.isOn()) //Loop
        {

            if (Input.Equals(HW.getKey()))
            {
                HW.Start();
                Console.WriteLine("You have launched: " + HW.getKey());
                Console.Write("UCom v0.0>> ");
                Input = Console.ReadLine();
            } else
            {
                if (Input.Equals(""))
                {
                    Console.Write("UCom v0.0>> ");
                    Input = Console.ReadLine();
                }
                else
                {

                    Console.WriteLine("I'm sorry, I am not sure what you mean, try typing something else");
                    Console.Write("UCom v0.0>> ");
                    Input = Console.ReadLine();
                }
            }

            switch (Input)
            {
                case HKey:
                    {
                        break;
                    }
                default:
                    Console.WriteLine("I'm sorry, I am not sure what you mean, try typing something else");
                    Console.Write("UCom v0.0>> ");
                    Input = Console.ReadLine();
                    break;
            }
        }
    }
}
