using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets.UIMessages
{
    public class TextMessages
    {
        public const string Info = "'help' - for all commands, 'start' to start the program, 'exit' to end";

        public const string StarterLine = "---------------Is lucky-------------- ";
        public const string BlankLine = " ";

        public const string InputPathToFile = "Input path 'path' ('Method1.txt' or 'Method2.txt' - default files)";
        public const string InputTicket = "Input ticket (6 numbers)";
        public const string StoppedProgram = "The program has been stopped";
        public const string PathError = "Can not find this file, try again";
        public const string InvalidMethodsName = "Invalid methods name in file";
        public const string InvalidTicket = "Invalid ticket's length, it must be <= 6";
        public const string CkeckIsLucky = "Checking if it's lucky";
        public const string LuckyTicket = "Cheers, your ticket is lucky!";
        public const string UnluckyTicket = "Your ticket is unlucky :(";
        public const string AlgorithmType = "algorithm";

        public const string StartProgram = "start";
        public const string HelpMessage = "help";
        public const string EndMessage = "exit";
    }
}
