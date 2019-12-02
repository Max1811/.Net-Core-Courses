using System;
using ChessFieldDrawProgram.Classes;
using NLog;

namespace ChessFieldDrawProgram
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            
            ChessField field;
            logger.Debug("Field created");
            logger.Debug("Trying to read parameters");
            if (args.Length == 3)
            {
                try
                {
                    int width, height;
                    char symbol;
                    Int32.TryParse(args[0], out width);
                    Int32.TryParse(args[1], out height);
                    Char.TryParse(args[2], out symbol);
                    logger.Debug("Params converted");

                    field = new ChessField(width, height, symbol);

                    try
                    {
                        logger.Debug("Trying to draw field");
                        field.DrawField();
                        logger.Debug("Field has been drawn");
                    }
                    catch(Exception ex)
                    {
                        ex.ToString();
                        logger.Error("Fail to draw field"); //logging 
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    logger.Error("Fail to read parametrs");
                }
            }
            else
            {
                logger.Error("Wrong number of parametrs");

                bool flag = true;
                while (flag)
                {
                    string message = Console.ReadLine();
                    switch (message)
                    {
                        case Messages.help

                        default:
                            break;
                    }
                }

                //switch (message)

            }

            logger.Info("-----------------------------------------------------------");

            Console.ReadKey();
        }


    }
}
