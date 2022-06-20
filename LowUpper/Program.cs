using System;

namespace Coding.Exercise
{
    public class Method
    {
        // Place for your methods
        public static void Main(string[] args)
        {
            Run();
            Console.Read();
        }

        public static string LowUpper(string text)
        {
            return text.ToLower() + text.ToUpper();
        }
        public static void Count(string s)
        {
            Console.WriteLine("The number of letters in the string is {0}.", s.Length);

        }

        public static void Run()
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);

        }
    }
}
