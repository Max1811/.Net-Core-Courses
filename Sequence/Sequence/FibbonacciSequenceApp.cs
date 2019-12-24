using Sequence.TextMessages;
using Serilog;
using System;

namespace Sequence
{
    public class FibbonacciSequenceApp
    {
        private readonly FibbonacciUI _fibbonacciUserInterface;

        private const int SEQUENCE_PARAMETRS = 2;
        private const int MAX_INT_LENGTH = 9;

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

                    Log.Logger.Information($"Successfully converted parametrs into int");

                    SequenceChoice choice = _fibbonacciUserInterface.GetSequenceChoiceFromUser();

                    ISequence sequence = GetSequenceByChoice(choice, from, to);


                    _fibbonacciUserInterface.Display(sequence);
                }
                catch (ArgumentException ex)
                {
                    Log.Logger.Warning($"Exception {ex.Message}");
                    _fibbonacciUserInterface.DisplayErrorMessage(ex.Message);
                }
                catch (FormatException ex)
                {
                    _fibbonacciUserInterface.DisplayErrorMessage(ex.Message);
                    Log.Logger.Warning($"Exception {ex.Message}");
                }
            }
        }

        private ISequence GetSequenceByChoice(SequenceChoice choice, int from, int to)
        {
            Log.Logger.Information($"Creating a sequence");

            SequenceValidator validator = new SequenceValidator();

            ISequence fibbonacci = new FibbonacciSequence(from, to);
            ISequence square = new SquareSequence(from, to);

            Log.Logger.Information($"Validating a sequence");
            switch (choice)
            {
                case SequenceChoice.Fibbonacci:
                    if (validator.Validate(fibbonacci).IsValid)
                    {
                        Log.Logger.Information($"Fibbonacci sequence created and validated");
                        return fibbonacci;
                    }

                    Log.Logger.Information($"Validation error");
                    throw new ArgumentException(UIMessages.INVALID_ARGUMENTS);

                case SequenceChoice.Square:
                    if (validator.Validate(fibbonacci).IsValid)
                    {
                        Log.Logger.Information($"Square sequence created and validated");
                        return square;
                    }
                    Log.Logger.Information($"Validation error");
                    throw new ArgumentException(UIMessages.INVALID_ARGUMENTS);

                default:
                    Log.Logger.Information($"There is no sequene with this type");

                    throw new ArgumentException(UIMessages.INVALID_TYPE_OFSEQUENCE);
            }
        }

        private int ConvertInput(string usersInput)
        {
            Log.Logger.Information($"Trying to convert input parametrs");
            try
            {
                return Convert.ToInt32(usersInput);
            }
            catch 
            {
                throw new FormatException(UIMessages.WRONG_INPUT_FORMAT);
            }
        }
    }
}
