using Sequence.TextMessages;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sequence
{
    public class FibbonacciSequenceApp
    {
        private readonly FibbonacciUI _fibbonacciUserInterface;

        private const int SEQUENCE_PARAMETRS = 2;

        public FibbonacciSequenceApp()
        {
            _fibbonacciUserInterface = new FibbonacciUI();
        }
        public void Start(string[] args)
        {
            Log.Logger.Information($"Starting app");

            int from,
                to;

            while (_fibbonacciUserInterface.IsRun())
            {
                try
                {
                    Log.Logger.Information($"User is inputting parametrs");

                    if(args.Length != 0)
                    {
                        if(args.Length > SEQUENCE_PARAMETRS)
                        {
                            throw new ArgumentException();
                        }

                        from = ConvertInput(args[0]);
                        to = ConvertInput(args[1]);

                        Array.Clear(args, 0, args.Length);
                    }
                    else
                    {
                        from = ConvertInput(_fibbonacciUserInterface.GetInputFromUser(UIMessages.INPUT_FROM_NUMBER));
                        to = ConvertInput(_fibbonacciUserInterface.GetInputFromUser(UIMessages.INPUT_TO_NUMBER));
                    }

                    SequenceChoice choice = _fibbonacciUserInterface.GetSequenceChoiceFromUser();

                    ISequence sequence = GetSequenceByChoice(choice, from, to);

                    _fibbonacciUserInterface.Display(sequence);
                }
                catch (ArgumentException ex)
                {
                    Log.Logger.Information($"Exception {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Log.Logger.Information($"Exception {ex.Message}");
                }
            }
        }

        private ISequence GetSequenceByChoice(SequenceChoice choice, int from, int to)
        {
            //TODO validate
            switch (choice)
            {
                case SequenceChoice.Fibbonacci:
                    return new FibbonacciSequence(from, to);

                case SequenceChoice.Square:
                    return new SquareSequence(from, to);

                default:
                    throw new ArgumentException();
            }
        }

        private int ConvertInput(string usersInput)
        {
            try
            {
                return Convert.ToInt32(usersInput);
            }
            catch 
            {
                throw new FormatException();
            }
        }
    }
}
