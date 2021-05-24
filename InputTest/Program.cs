using System;


namespace InputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string input = Minecraftchest1.Utils.Input("Press any key.");
            Console.WriteLine(input);

            Console.WriteLine(input.Length);

            Minecraftchest1.Utils.Pause();
        }
    }
}
