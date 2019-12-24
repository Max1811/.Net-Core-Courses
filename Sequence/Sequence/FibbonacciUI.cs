using Sequence.TextMessages;
using Serilog;
using System;

namespace Sequence
{
    public class FibbonacciUI
    {
        public bool IsRun()
        {
            bool doRunAgain = false;
            bool askAgain = false;

            do
            {
                Log.Logger.Information($"Inputting string for IsRun again:");
                string input = string.Empty;

                Console.WriteLine(UIMessages.RUN_AGAIN);
                input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case UIMessages.YES:
                    case UIMessages.Y:
                        Log.Logger.Information($"String is yes, continuing program");
                        doRunAgain = true;
                        askAgain = false;

                        Log.Logger.Information($"--------------------------------------------------------");

                        break;

                    case UIMessages.NO:
                    case UIMessages.N:
                        Log.Logger.Information($"String is no, ending program");
                        doRunAgain = false;
                        askAgain = false;

                        Log.Logger.Information($"--------------------------------------------------------");

                        break;

                    default:
                        Log.Logger.Information($"Incorrect input for IsRun: {input}");
                        Console.WriteLine(UIMessages.INCORRECT_INPUT);
                        Console.WriteLine();

                        askAgain = true;

                        break;
                }
            }
            while (askAgain);

            return doRunAgain;
        }

        internal void Display(ISequence sequence)
        {
            string result = String.Empty;

            foreach (var item in sequence)
            {
                result += item + " ";
            }

            Console.WriteLine(UIMessages.STARTER_LINE);
            Console.WriteLine(result);
            Console.WriteLine(UIMessages.END_LINE);
        }

        internal void DisplayErrorMessage(string message)
        {
            Log.Logger.Information($"Displaying sequence");
            Console.WriteLine(message);
        }

        public SequenceChoice GetSequenceChoiceFromUser()
        {
            Console.WriteLine(UIMessages.SEQUENCE_CHOICE);

            string choice = Console.ReadLine().ToLower();

            bool doAskAgain = false;

            do
            {
                switch (choice)
                {
                    case UIMessages.FIBBONACCI_CHOICE:
                        return SequenceChoice.Fibbonacci;

                    case UIMessages.SQUARE_CHOICE:
                        return SequenceChoice.Square;

                    default:
                        doAskAgain = false;
                        break;
                }
            }
            while (doAskAgain);

            throw new ArgumentException();
        }

        public string GetInputFromUser(string input)
        {
            Console.WriteLine(input);

            return Console.ReadLine();
        }
    }
}
