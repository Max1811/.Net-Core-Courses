using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangles.Messages
{
    public class TextMessages
    {
        public const string Info = "'help' - for all commands, 'yes' to start/continue inputing the triangles, 'sort' to sort them all, 'exit' to end";
        public const string StarterLine = "---------------Triangles-------------- ";
        public const string InputTriangle = "Input triangle: Name,firstSide,secondSide,thirdSide";
        public const string StoppedProgram = "The program has been stopped";
        public const string ContinueInputting = "Type yes to input another triangle:";
        public const string InputtingError = "Can not create treangle with this parametrs, try more";
        public const string WrongParametrs = "Wrong input parametrs, try more";
        public const string UsersAnswer = "yes";
        public const string HelpMessage = "help";
        public const string DisplaySortedFigures = "sort";
        public const string EndMessage = "exit";
    }
}
