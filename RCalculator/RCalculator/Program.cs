using System;
using RDotNet;

namespace RCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            string input;
            REngine engine;

            /* init the R engine */           
            REngine.SetEnvironmentVariables();
            engine = REngine.GetInstance();
            engine.Initialize();

            /* input */
            Console.WriteLine("Please enter the calculation");
            input = Console.ReadLine();

            /* calculate */
            CharacterVector vector = engine.Evaluate(input).AsCharacter();
            result = vector[0];

            /* clean up */
            engine.Dispose();

            /* output */
            Console.WriteLine("");
            Console.WriteLine("Result: '{0}'", result);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
