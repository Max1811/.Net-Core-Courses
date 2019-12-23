using System;
using System.Collections.Generic;
using System.Text;

namespace Sequence.TextMessages
{
    public static class UIMessages
    {
        public static readonly string INFO = "'help' - for all commands, 'start' to start program, 'exit' to end";

        public static readonly string STARTER_LINE = "-------------------------Sequence------------------------ ";
        public static readonly string END_LINE = "--------------------------------------------------------- ";

        public const string INPUT_FROM_NUMBER = "Input 'From' number, from which sequence is starting from";
        public const string INPUT_TO_NUMBER = "Input 'To' number, to which sequence is ending to";
        public const string OUTPUT_FIBBONACCI_SEQUENCE = "Fibbonacci sequence";
        public const string RUN_AGAIN = "Enter yes/y to continue, no/n to exit";
        public const string SEQUENCE_CHOICE = "Input 'f' to get fibbonacci sequence, 's' to get square sequence";
        public const string INCORRECT_INPUT = "Incorrect input, you can only input 'yes/y' or 'no/n'";

        public const string YES = "yes";
        public const string Y = "y";
        public const string FIBBONACCI_CHOICE = "f";
        public const string SQUARE_CHOICE = "s";
        public const string NO = "no";
        public const string N = "n";

        public const string OUT_OF_RANGE_OF_EXEPTION_MESSAGE = "Too big 'to' inputed value ";
        public const string INVALID_ARGUMENTS = "Invalid range! ";
        public const string INVALID_TYPE_OFSEQUENCE = "Invalid type of sequence ";
        public const string WRONG_INPUT_FORMAT = "Wrong type of parametrs";
    }
}
