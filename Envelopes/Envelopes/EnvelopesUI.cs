using Envelopes.TextMessages;
using Serilog;
using System;

namespace Envelopes
{
    public class EnvelopesUI
    {
        public string[] GetEnvelopeFromUser(string informationForUser)
        {
            Console.WriteLine(informationForUser);

            return Console.ReadLine().Split(' ');
        }

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

        public void Display(ContainStates state)
        {
            Console.WriteLine("\n" + new string('-', 50));
            Log.Logger.Information($"Displaying state of comparing envelopes:");
            switch (state)
            {
                case ContainStates.FirstContainsSecond:
                    Log.Logger.Information($"State: first can fit second");
                    Console.WriteLine(UIMessages.SECOND_FITS_IN_FIRST);

                    break;
                case ContainStates.SecondContainsFirst:
                    Log.Logger.Information($"State: second can fit first");
                    Console.WriteLine(UIMessages.FIRST_FITS_IN_SECOND);

                    break;
                case ContainStates.DoesntContainsAny:
                    Log.Logger.Information($"Can not fit each other");
                    Console.WriteLine(UIMessages.ENVELOPES_DONT_FIT_TO_EACH_OTHER);

                    break;
                default:
                    Log.Logger.Information($"invalid state");
                    Console.WriteLine(UIMessages.INVALID_COMPARING_STATE);

                    break;
            }
            Console.WriteLine("\n" + new string('-', 50));

        }

        internal void DisplayExeption(string message)
        {
            Log.Logger.Information($"Displaying the cause of exception");
            Console.WriteLine(message);
        }
    }
}
