using System;

namespace Minecraftchest1
{
    class Utils
    {
        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static string Input(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return input;
        }
        public static double InputDouble(string prompt)
        {
            double inputD = 0;
            string inputS;
            inputS = Utils.Input(prompt);

            Console.Write(prompt);
            try
            {
                inputD = Convert.ToDouble(inputS);
            }
            catch (FormatException)
            {
                if (inputS == null)
                {
                    inputD = 0;
                    return inputD;
                }
                else
                {
                    InputErrorException ex = new InputErrorException($"Could not convert {inputS} to a Double.");
                    ex.Input = inputS;
                    throw ex;
                }
            }
            catch(Exception e) 
            {
                throw;
            }
            return inputD;
        }
	}

    [System.Serializable]
    public class InputErrorException  : Exception
    {
        public InputErrorException() { }
        public InputErrorException(string message) : base(message) { }
        public InputErrorException(string message, Exception inner) : base(message, inner) { }
        protected InputErrorException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public string Input;
    }
}
