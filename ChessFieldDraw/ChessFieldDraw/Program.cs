using ChessFieldDraw.FieldComponents;
using ChessFieldDraw.Messages;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFieldDraw
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            ChessField field;
            CellSymbols displaySymbols;

            logger.Debug("Field created");
            logger.Debug("Trying to read parameters");

            int width = 0, height = 0;
            char whiteSymbol =' ', blackSymbol = ' ';

            if (args.Length == 4)
            {
                try
                {

                    Int32.TryParse(args[0], out width);
                    Int32.TryParse(args[1], out height);
                    Char.TryParse(args[2], out whiteSymbol);
                    Char.TryParse(args[3], out blackSymbol);
                    logger.Debug("Params converted");

                    displaySymbols = new CellSymbols(whiteSymbol, blackSymbol);
                    field = new ChessField(width, height);

                    try
                    {
                        logger.Debug("Trying to draw field");
                        field.DrawField(displaySymbols);
                        logger.Debug("Field has been drawn");
                    }
                    catch (Exception ex)
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
            else if(args.Length < 4)
            {
                logger.Error("Wrong number of parametrs");

                bool flag = true;
                Console.WriteLine(MessagesText.Info);
                while (flag)
                {
                    logger.Debug("Looping switch");
                    string message = Console.ReadLine().ToLower();
                    switch (message)
                    {
                        case MessagesText.HelpMessage:
                            logger.Debug("Writing info");
                            Console.WriteLine(MessagesText.Info);
                            break;
                        case MessagesText.StartMessage:
                            logger.Debug("Starting program:");
                            try
                            {
                                logger.Debug("Trying to convert data");
                                Console.WriteLine(MessagesText.InputHeight);
                                width = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(MessagesText.InputWidth);
                                height = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(MessagesText.InputWhiteSymbol);
                                whiteSymbol = Convert.ToChar(Console.ReadLine());

                                Console.WriteLine(MessagesText.InputBlackSymbol);
                                blackSymbol = Convert.ToChar(Console.ReadLine());

                                field = new ChessField(width, height);
                                displaySymbols = new CellSymbols(blackSymbol, whiteSymbol);
                                field.DrawField(displaySymbols);
                                logger.Debug("Data converted");
                            }
                            
                            catch(Exception ex)
                            {
                                logger.Debug("Failed to convert" + ex.Message);
                            }
                            break;
                        case MessagesText.EndMessage:
                            logger.Debug("Ending program");
                            flag = false;
                            break;
                        default:
                            logger.Debug("Not usual string was written");
                            break;
                    }
                }

                //switch (message)

            }
            else
            {
                logger.Error("Wrong number of parametrs ( > 4 )");
            }

            logger.Info(new string('-',50));

            Console.ReadKey();
        }
        


    }
}
