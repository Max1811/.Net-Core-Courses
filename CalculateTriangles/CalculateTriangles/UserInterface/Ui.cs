using CalculateTriangles.Messages;
using CalculateTriangles.TriangleElements;
using CalculateTriangles.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangles.UserInterface
{
    public static class UI
    {
        public static void Start(string[] args)
        {
            Triangle triangle;
            SortedFigures<Triangle> triangles = new SortedFigures<Triangle>();
            

            string _triangleParams = "";

            if (args.Length != 0)
            {
                //ParseParametrs();
            }
            else
            {
                bool flag = true;
                Console.WriteLine(TextMessages.Info);
                TrianglesValidator validation = new TrianglesValidator();
                while (flag)
                {
                    string message = Console.ReadLine().ToLower();
                    switch (message)
                    {
                        case TextMessages.HelpMessage:
                            Console.WriteLine(TextMessages.Info);
                            break;
                        case TextMessages.UsersAnswer:

                            Console.WriteLine(TextMessages.InputTriangle);
                            _triangleParams = Console.ReadLine();

                            triangle = ParseTriangleParams(_triangleParams);

                            if(triangle == null)
                            {
                                Console.WriteLine(TextMessages.WrongParametrs);
                                Console.WriteLine(TextMessages.ContinueInputting);
                                break;
                            }

                            if (validation.Validate(triangle).IsValid)
                            {
                                triangles.Add(triangle);
                                Console.WriteLine(TextMessages.ContinueInputting);
                            }
                            else
                            {
                                Console.WriteLine(TextMessages.InputtingError);
                                Console.WriteLine(TextMessages.ContinueInputting);
                            }
                            
                            break;
                        case TextMessages.DisplaySortedFigures:

                            triangles.SortFiguresList();
                            UI.DisplaySortedList(triangles);
                            Console.WriteLine(TextMessages.ContinueInputting);
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

        private static Triangle ParseTriangleParams(string triangleParams)
        {
            string[] words = triangleParams.Split(',');
            string name = words[0];
            const int NUMBER_OF_PARAMETRS = 4;
            if(words.Length == NUMBER_OF_PARAMETRS)
            {
                double fSide, sSide, tSide;
                try
                {
                    fSide = Convert.ToDouble(words[1]);
                    sSide = Convert.ToDouble(words[2]);
                    tSide = Double.Parse(words[3]);
                    return new Triangle(name, fSide, sSide, tSide);
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            
            else
            {
                return null;
            }

        }

        private static void DisplaySortedList(SortedFigures<Triangle> triangles)
        {
            foreach (var item in triangles.Figures)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
