using LuckyTickets.TicketsComponents;
using LuckyTickets.UIMessages;
using System;
using System.IO;

namespace LuckyTickets.UI
{
    public static class LuckyTicketsUI
    {
        const int MAX_FILE_LINES_COUNT = 1;
        public static void Start(string[] args)
        {
            Ticket usersTicket;

            if (args.Length != 0)
            {
                //parse args
            }
            else
            {
                bool flag = true;
                Console.WriteLine(TextMessages.Info);
                Console.WriteLine(TextMessages.StarterLine);

                while (flag)
                {
                    string message = Console.ReadLine().ToLower();
                    switch (message)
                    {
                        case TextMessages.HelpMessage:
                            Console.WriteLine(TextMessages.HelpMessage);

                            break;
                        case TextMessages.StartProgram:
                            Console.WriteLine(TextMessages.BlankLine);
                            Console.WriteLine(TextMessages.InputPathToFile);

                            string path = "../../../" + Console.ReadLine();
                            usersTicket = TryParsePath(path);

                            break;
                        case TextMessages.EndMessage:
                            flag = false;

                            break;
                        default:
                            Console.WriteLine(TextMessages.Info);

                            break;
                    }
                }
            }
        }

        private static Ticket TryParsePath(string path)
        {
            Ticket usersTicket;
            AlgorithmsCases algorithmCase = new AlgorithmsCases();
            ILuckyTicketsCounter method;
            string algorithmsName = " ";

            try
            {
                StreamReader fileMethod = new StreamReader(path);
                if (fileMethod != null)
                {
                    string line;
                    int lineCount = 0;
                    while ((line = fileMethod.ReadLine()) != null && lineCount != MAX_FILE_LINES_COUNT)
                    {
                        algorithmsName = line;
                        lineCount++;
                    }
                    fileMethod.Close();
                }
                else
                {
                    Console.WriteLine(TextMessages.PathError);

                    return null;
                }// Parsing string from file
            }
            catch
            {
                Console.WriteLine("Can not find your file, try again:");
                Console.WriteLine(TextMessages.Info);

                return null;
            }

            if (algorithmsName == "Piter")
            {
                Console.WriteLine("Piter algorithm");
                algorithmCase = AlgorithmsCases.Piter;
                method = new PiterLuckyNumber();
            }
            else if (algorithmsName == "Moscow")
            {
                Console.WriteLine("Moscow algorithm");
                algorithmCase = AlgorithmsCases.Moscow;
                method = new MoskowLuckyTicket();
            }
            else
            {
                Console.WriteLine(TextMessages.InvalidMethodsName);
                return null;
            }

            Console.WriteLine(TextMessages.InputTicket);

            string usersInput = Console.ReadLine();
            if (usersInput != null)
            {
                usersTicket = new Ticket(usersInput, algorithmCase, method);

                if (usersTicket.ticketNumber == null)
                {
                    Console.WriteLine(TextMessages.InvalidTicket);
                    return null;
                }
                Console.WriteLine(TextMessages.CkeckIsLucky);
                if (usersTicket.countMethod != null && usersTicket.countMethod.IsLucky(usersTicket))
                {

                    Console.WriteLine(TextMessages.LuckyTicket);
                    Console.WriteLine(TextMessages.BlankLine);
                    Console.WriteLine(TextMessages.Info);
                    Console.WriteLine(TextMessages.BlankLine);

                    return usersTicket;
                }
                else
                {
                    Console.WriteLine(TextMessages.UnluckyTicket);
                    Console.WriteLine(TextMessages.BlankLine);
                    Console.WriteLine(TextMessages.Info);
                    Console.WriteLine(TextMessages.BlankLine);

                    return null;
                }
            }
            else
            {
                return null;
            }

        }
    }
}

//string[] piterMethod = Enum.GetNames(typeof(AlgorithmsCases));
//foreach (var item in piterMethod)
//{
//    if(item == algorithmsName)
//    {
//        algorithmCase = AlgorithmsCases;
//    }
//}