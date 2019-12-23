using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelopes.TextMessages
{
    public static class UIMessages
    {
        public const string HELP = "help";

        public const string YES = "yes";
        public const string NO = "no";
        public const string Y = "y";
        public const string N = "n";

        public const string RUN_AGAIN = "Enter yes/y to continue, no/n to exit";
        public const string INCORRECT_INPUT = "Incorrect input, you can only input 'yes/y' or 'no/n'";

        public const string INFO = "Input 'help' to get help message, input 'start' to run app, input 'no/n' to exit";

        public const string INPUT_FIRST_ENVELOPE = "Input first envelope:";
        public const string INPUT_SECOND_ENVELOPE = "Input second envelope:";

        public const string FIRST_FITS_IN_SECOND = "First envelope cab be fitted in the second one";
        public const string SECOND_FITS_IN_FIRST = "Second envelope can be fitted in the first one";
        public const string ENVELOPES_DONT_FIT_TO_EACH_OTHER = "Envelopes can not be placed to each others";
        public const string INVALID_COMPARING_STATE = "Invalid state of comparing envelopes";
    }
}
