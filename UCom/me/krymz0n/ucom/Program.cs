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
        HelloWorld HW = new HelloWorld("H", CM.getKey());
        Console.WriteLine("Launched");

        String input = Console.ReadLine();

        while (GL.isOn())
        {
            if (input.Equals(HW.getKey()))
            {
                HW.Start();
                Console.WriteLine("You have launched: " + HW.getKey());
                input = Console.ReadLine();
            } else
            {
                Console.WriteLine("I'm sorry, I am not sure what you mean, try typing something else");
                input = Console.ReadLine();
            }
        }
    }
}
