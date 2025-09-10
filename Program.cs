using ShapePractice.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePractice
{
    internal class Program
    {
        static List<Shape> shapes;
        static void Main(string[] args)
        {
            shapes = new List<Shape>();
            AddShapes();
        }
        static void AddShapes()
        {
            int option = DisplayMenu();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Introduce el lado del Cuadrado");
                    shapes.Add(new Cuadrado(float.Parse(Console.ReadLine())));
                    Console.WriteLine("El Cuadrado Fue Añadido");
                    AddShapes();
                    break;
                case 2:
                    Console.WriteLine("Introduce la base del Triangulo");
                    float baseLength = float.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce la altura del Triangulo");
                    float height = float.Parse(Console.ReadLine());
                    shapes.Add(new Triangulo(baseLength, height));
                    Console.WriteLine("El Triangulo Fue Añadido");
                    AddShapes();
                    break;
                case 3:
                    Console.WriteLine("Introduce el radio del Circulo");
                    shapes.Add(new Circulo(float.Parse(Console.ReadLine())));
                    Console.WriteLine("El Circulo Fue Añadido");
                    AddShapes();
                    break;
                case 4:
                    Console.WriteLine("Introduce la base del Rectangulo");
                    float rectBase = float.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce la altura del Rectangulo");
                    float rectHeight = float.Parse(Console.ReadLine());
                    shapes.Add(new Rectangulo(rectBase, rectHeight));
                    Console.WriteLine("El Rectangulo Fue Añadido");
                    AddShapes();
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
                case 6:
                    DisplayShapes();
                    break;
            }
        }
        static int DisplayMenu()
        {
            Console.WriteLine("Que Figura desea añadir:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Circulo");
            Console.WriteLine("4. Rectangulo");
            Console.WriteLine("5. Salir");
            if(shapes.Count > 0)
            {
                Console.WriteLine("6: Show Shapes");
            }
            string optionInput = Console.ReadLine();
            return int.Parse(optionInput);
        }

        static void DisplayShapes()
        {
            Console.WriteLine("--- Lista de Figuras ---");
            foreach (Shape s in shapes)
            {
                Console.WriteLine($"{s.name} - Área: {s.GetArea()}");
            }
            DisplayMenu();
        }
    }
}
