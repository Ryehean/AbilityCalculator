using System;

namespace AbilityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add Amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Miniumum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }
        /// <summary>
        /// Writes a prompt and reads in an int value from the console
        /// </summary>
        /// <param name="lastUsedValue"> The defaut value.</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse.</returns>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.WriteLine(prompt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine("    using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("    using default value" + lastUsedValue);
                return lastUsedValue;
            }
        }

        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.WriteLine(prompt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine("    using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("    using default value" + lastUsedValue);
                return lastUsedValue;
            }
        }

    }
}
