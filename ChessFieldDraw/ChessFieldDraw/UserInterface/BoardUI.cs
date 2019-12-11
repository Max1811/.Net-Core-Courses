using ChessFieldDraw.FieldComponents;
using ChessFieldDraw.Messages;
using NLog;
using System;

namespace ChessFieldDraw.UserInterface
{
    public class BoardUI
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void Start(string[] args)
        {
            ChessField field;

            logger.Debug("Field created");
            logger.Debug("Trying to read parameters");

            if (args.Length == 4)
            {
                field = TryParseDefaultArgs(args);

                if (field != null)
                {
                    logger.Debug("Trying to draw field");

                    DisplayField(field);

                    logger.Debug("Field has been drawn");
                }
            }
            else if (args.Length < 4)
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

                            field = ParseArguments();
                            if (field != null)
                            {
                                DisplayField(field);
                                logger.Debug("Data converted");
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
                    logger.Info(new string('-', 50));
                }

                //switch (message)

            }
            else
            {
                logger.Error("Wrong number of parametrs ( > 4 )");
            }



            Console.ReadKey();
        }

        private static ChessField ParseArguments()
        {
            logger.Debug("Trying to convert data");

            try
            {
                Console.WriteLine(MessagesText.InputHeight);
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(MessagesText.InputWidth);
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(MessagesText.InputWhiteSymbol);
                char whiteSymb = Convert.ToChar(Console.ReadLine());

                Console.WriteLine(MessagesText.InputBlackSymbol);
                char blackSymb = Convert.ToChar(Console.ReadLine());

                return new ChessField(width, height, new CellSymbols(blackSymb, whiteSymb));
            }
            catch
            {
                logger.Debug("Failed to convert");
                return null;
            }
        }

        private static void DisplayField(ChessField field)
        {
            for (int x = 0; x < field.Width; x++)
            {
                string line = "";
                for (int y = 0; y < field.Height; y++)
                {
                    if (field[x, y].Color == CellColors.White)
                    {
                        line += field.DisplaySymbols.WhiteSymb;
                    }
                    else
                    {
                        line += field.DisplaySymbols.BlackSymb;
                    }
                }
                Console.WriteLine(line);
            }
        }

        private static ChessField TryParseDefaultArgs(string[] args)
        {
            try
            {
                int width = Convert.ToInt32(args[0]);
                int height = Convert.ToInt32(args[1]);
                char whiteSymbol = Convert.ToChar(args[2]);
                char blackSymbol = Convert.ToChar(args[3]);

                logger.Debug("Params converted");

                return new ChessField(width, height, new CellSymbols(whiteSymbol, blackSymbol));
            }
            catch
            {
                logger.Debug("Can not convert params");
                return null;
            }

        }
    }
}
