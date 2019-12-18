using SequenceTask.Fibbonacci;
using SequenceTask.SequenceOfNumbers;
using SequenceTask.SquareCheck;
using SequenceTask.TextMessages;
using System;

namespace SequenceTask.SequenceUI
{
    public static class UI
    {
        public static void Start(string[] args)
        {
            //TODO logging
            //TODO validating natural numbers

            Sequence filteredFibbonacciSequence;
            Sequence filteredSquareSequence;

            int from;
            int to;
            int pow;

            if (args.Length != 0)
            {
                //TODO parse args
            }
            else
            {
                bool flag = true;

                do
                {
                    Console.WriteLine(Messages.INFO);
                    string message = Console.ReadLine();
                    switch (message)
                    {
                        case Messages.START:

                            try
                            {
                                GetInputedData(out from, out to, out pow);
                            }
                            catch (InvalidCastException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }

                            Console.WriteLine(Messages.OUTPUT_FIBBONACCI_SEQUENCE);
                            filteredFibbonacciSequence = new Sequence(new FibbonacciSequence(from, to).FibbonacciSequenceCount());
                            Display(filteredFibbonacciSequence);

                            Console.WriteLine(Messages.OUTPUT_POW_SEQUENCE);
                            filteredSquareSequence = new Sequence(new ExponentSequence(from, to, pow).SelectPows());
                            Display(filteredSquareSequence);


                            break;
                        case Messages.END_MESSAGE:

                            break;
                        case Messages.HELP_MESSAGE:
                            Console.WriteLine(Messages.INFO);

                            break;
                        default:

                            break;
                    }
                }
                while (flag);
            }
        }

        private static void Display(Sequence sequence)
        {
            if (sequence.NumbersSequence == null)
            {
                Console.WriteLine("Null sequence");
            }
            else
            {
                Console.WriteLine(Messages.STARTER_LINE);

                string allNumbers = " ";

                foreach (var item in sequence.NumbersSequence)
                {
                    allNumbers += item + " ";
                }

                Console.WriteLine(allNumbers);
            }

        }

        private static void GetInputedData(out int from, out int to, out int pow)
        {
            try
            {
                Console.WriteLine(Messages.INPUT_FROM_NUMBER);
                from = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Messages.INPUT_TO_NUMBER);
                to = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Messages.INPUT_POW_NUMBER);
                pow = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new InvalidCastException("Wrong type of parametrs");
            }
        }
    }
}
