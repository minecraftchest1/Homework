using System;
using Minecraftchest1;

namespace PythagoreanTheormCalc
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                PythagoreanTheormCalc();
                Console.WriteLine();
                Console.WriteLine("Press ctrl/cmd + C to exit");
                Utils.Pause();
            }
        }
        static void PythagoreanTheormCalc()
        {
            double SideA = 0;
            double SideB = 0;
            double SideC = 0;

            Console.WriteLine("Pythagorean Theorm Calc.");

            /// <summary>
            /// Get the sides of the triangle from the user.
            /// </summary>
            try
            {
                SideA = Convert.ToDouble(Utils.Input("Side A: "));
                SideB = Convert.ToDouble(Utils.Input("Side B: "));
                SideC = Convert.ToDouble(Utils.Input("Side C: "));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //System.Environment.Exit(-1);
                return;
            }

            Console.WriteLine();

            /// <summary>
            /// Square each side
            /// </summary>
            double SideA2 = Math.Pow(SideA, 2);
            double SideB2 = Math.Pow(SideB, 2);
            double SideC2 = Math.Pow(SideC, 2);

            /// <summary>
            /// Print the squared sides
            /// </summary>
            Console.WriteLine("Side A^2: " + SideA2);
            Console.WriteLine("Side B^2: " + SideB2);
            Console.WriteLine("Side C^2: " + SideC2);

            /// <summary>
            /// Calculate Pythagorean Theorm 
            /// </summary>
            double SideAB2 = SideA2 + SideB2;

            Console.WriteLine("SideAB^2: " + SideAB2);
            Console.WriteLine();
            
            /// <summary>
            /// See if SideAB = SideC
            /// </summary>
            if (SideAB2 == SideC2)
            {
                Console.WriteLine("SideAB^2 (" + SideAB2 + ") equals SideC^2 (" + SideC2 +")");
            }
            else
            {
                Console.WriteLine("SideAB^2 (" + SideAB2 + ") does not equal SideC^2 (" + SideC2 + ")");
            }
        }
    }
}
