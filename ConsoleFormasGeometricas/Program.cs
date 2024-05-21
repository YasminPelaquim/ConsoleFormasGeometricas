using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a forma geometrica desejada (q-Quadrado,t-Trapézio,l-Losando,r-Retângulo): ");
            string forma = Console.ReadLine();

            switch (forma)
            {
                case "q":
                    quadrado();
                    break;

                case "r":
                    retangulo();
                    break;

                case "t":
                    trapezio();
                    break;

                case "l":
                    losango();
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.ReadKey();


        }

        static void quadrado()
        {
            Console.WriteLine("Informe a medida da base: ");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da altura");
            double H = double.Parse(Console.ReadLine());

            double area;

            area = B * H;

            Console.WriteLine("A área do Quadrado é: " + area);
        }

        static void retangulo() 
        {
            Console.WriteLine("Informe a medida da base: ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da altura");
            double R2 = double.Parse(Console.ReadLine());

            double arearet;

            arearet = R * R2;

            Console.WriteLine("A área do Retângulo é: " + arearet);
        }

        static void trapezio()
        {
            Console.WriteLine("Informe a medida da base: ");
            double T = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da base: ");
            double T1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da altura");
            double TH = double.Parse(Console.ReadLine());

            double areatra;

            areatra = (T + T1) * TH / 2;

            Console.WriteLine("A área do Trapézio é: " + areatra);
        }

        static void losango()
        {
            Console.WriteLine("Informe a medida da diagonal maior: ");
            double L = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da diagonal menor: ");
            double L1 = double.Parse(Console.ReadLine());


            double arealo;

            arealo = (L * L1) / 2;

            Console.WriteLine("A área do Losango é: " + arealo);
        }

    }
}
