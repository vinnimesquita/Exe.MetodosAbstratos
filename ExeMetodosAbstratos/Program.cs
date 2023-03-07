﻿
using ExeMetodosAbstratos.Entities;
using ExeMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine()); 


                if (ch == 'r')
                {
                    Console.WriteLine("Width:");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height:");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }

                else
                {
                    Console.WriteLine("Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }

            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shape in list) 
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
