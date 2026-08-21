using System;
using System.Collections.Generic;
using System.Text;

namespace RocketApp
{
    internal class RocketSimulation
    {
        string rocket = "";
        public void InitRocket()
        {
            rocket = "    /\\    " +
                "\n   /  \\   " +
                "\n  / () \\   " +
                "\n /      \\   " +
                "\n |      |  " +
                "\n |      |  " +
                "\n |      |  " +
                "\n |      |  " +
                "\n (\\    /) " +
                "\n(__\\  /__)" +
                "\n   |__|   ";
            Console.WriteLine(rocket);
        }
        public void DescendRocket()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.Clear();
                rocket = "\n" + rocket;
                Console.WriteLine(rocket);
                Thread.Sleep(500);
            }
        }

        public void LandingComplete()
        {
            Thread.Sleep(1000);
            Console.WriteLine("The rocket has landed. Woohoo! Another successful landing!");
        }
    }
}
