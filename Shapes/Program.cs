using System;
using Shapes.Common;
using Shapes.Shapes;
using Shapes.Implementation;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what to draw:");

            Console.WriteLine("Arrow: 1");
            Console.WriteLine("Double Arrow: 2");
            Console.WriteLine("Line: 3");
            Console.WriteLine("Square: 4");
            Console.WriteLine("Triangle: 5");
            Console.WriteLine("Table: 6");
            while (true)
            {

                Console.Write("Insert value: ");
                string answer = Console.ReadLine();

                if (Convert.ToInt32(answer) >= 1 && Convert.ToInt32(answer) <= 6)
                {
                    switch ((ShapeTypes)Convert.ToInt32(answer))
                    {
                        case ShapeTypes.Arrow:
                            {
                                DrawArrowApi drawArrowApi = new();
                                Arrow arrow = new(drawArrowApi);

                                arrow.Draw();
                            }
                            break;
                        case ShapeTypes.DoubleArrow:
                            {
                                DrawDoubleArrowApi doubleArrowApi = new();
                                DoubleArrow doubleArrow = new(doubleArrowApi);

                                doubleArrow.Draw();
                            }
                            break;
                        case ShapeTypes.Line:
                            {
                                DrawLineApi drawLineApi = new();
                                Line line = new(drawLineApi);

                                line.Draw();
                            }
                            break;
                        case ShapeTypes.Square:
                            {
                                DrawSquareApi drawSquareApi = new();
                                Square square = new(drawSquareApi);

                                square.Draw();
                            }
                            break;
                        case ShapeTypes.Triangle:
                            {
                                DrawTriangleApi drawTriangleApi = new();
                                Triangle triangle = new(drawTriangleApi);

                                triangle.Draw();
                            }
                            break;
                        case ShapeTypes.Table:
                            {
                                DrawTableApi drawTableApi = new();
                                Table table = new(drawTableApi);

                                table.Draw();
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Program Stopped!!");
                    break;
                }
            }
        }
    }
}
