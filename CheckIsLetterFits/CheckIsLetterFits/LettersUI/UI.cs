using CheckIsLetterFits.LetterComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsLetterFits.LettersUI
{
    public static class UI
    {
        public static void Start(string args)
        {
            if (args.Length != 0)
            {
                //TO DO Parsing args
            }
            else
            {
                StartInputting();
            }
        }

        private static void StartInputting()
        {

            bool flag = true;

            do
            {
                Console.WriteLine();
                string message = Console.ReadLine();
                switch (message)
                {
                    case "start":

                        LettersContainer<ILetter> container = TryParseLetters();

                        break;


                }
            }
            while (flag);
        }

        //private static LettersContainer<ILetter> TryParseLetters()
        //{
        //    Letter letterOne,
        //        letterTwo;

        //    string firstLetter = Console.ReadLine();

        //    try
        //    {
        //        string[] letterParts = firstLetter.Split(".");
        //    }
        //    catch
        //    {

        //    }

        //}
    }
}
