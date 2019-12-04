using CalculateTriangles.Messages;
using CalculateTriangles.TriangleElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle;
            double firstSide, secondSide, thirdSide;
            string name = "";

            if(args.Length != 0)
            {
                //parse parametrs
            }
            else
            {
                bool flag = true;
                Console.WriteLine(TextMessages.Info);
                while (flag)
                {
                    string message = Console.ReadLine().ToLower();
                    switch (message)
                    {
                        case TextMessages.HelpMessage:
                            Console.WriteLine(TextMessages.Info);
                            break;
                        case TextMessages.StartMessage:

                            try
                            {
                                Console.WriteLine(TextMessages.InputName);
                                name = Convert.ToString(Console.ReadLine());

                                Console.WriteLine(TextMessages.InputFirstSide);
                                firstSide = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(TextMessages.InputSecondSide);
                                secondSide = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(TextMessages.InputThirdSide);
                                thirdSide = Convert.ToInt32(Console.ReadLine());

                                triangle = new Triangle(name, firstSide, secondSide, thirdSide) ;
                                TrianglesList.triangles.Add(triangle);
                            }

                            catch (Exception ex)
                            {

                            }
                            break;
                        case TextMessages.EndMessage:
                            flag = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
