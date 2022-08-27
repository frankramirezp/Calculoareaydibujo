using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculoarea
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double Area;
            double Altura;
            double Base;

            Console.WriteLine("Elija un figura geometrica");
            Console.WriteLine("1-Circulo");
            Console.WriteLine("2-Triangulo");
            Console.WriteLine("3-Cuadrado");

            num = Convert.ToInt32(Console.ReadLine());

            string continuar;

            switch (num)
            {
                case 1:
                    {
                        //-----------------------------------------------------------------------------------
                        int x, y, radio;
                        double PI = 3.1416;
                        Console.WriteLine("Indique el radio: ");
                        radio = int.Parse(Console.ReadLine());
                        Area = PI * Math.Pow(radio, 2);
                        Console.WriteLine("El area del circulo es: " + Area);
                        for (x = 0; x <= radio * 2; x++)
                        {
                            for (y = 0; y <= radio * 2; y++)
                            {
                                if (Math.Pow(y - radio, 2) + Math.Pow(x - radio, 2) <= (int)Math.Pow(radio, 2))
                                {
                                    Console.WriteLine("*");
                                }
                                else
                                {
                                    Console.WriteLine(" ");
                                }
                            }
                            Console.WriteLine(" ");
                        }
                        //-----------------------------------------------------------------------------------
                    }
                    
                    break;

                case 2:
                    {
                        //-----------------------------------------------------------------------------------
                        Console.WriteLine("Indique la base");
                        Base = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique la altura");
                        Altura = Convert.ToInt32(Console.ReadLine());

                        Area = Base * Altura / 2;
                        Console.WriteLine("El area es: " + Area);
                        int aster;
                        double x, y;
                        for (x = 1; x <= Altura; x++)
                        {
                            for (y = 0; y < Altura - x; y++)
                            {
                                Console.WriteLine(" ");
                            }
                            for (aster = 0; aster < (x * 2) - 1; aster++)
                            {
                                Console.WriteLine("*");
                            }
                            Console.WriteLine();
                        }
                        //-----------------------------------------------------------------------------------
                    }

                    break;
                    
                case 3:
                    {
                        //-----------------------------------------------------------------------------------
                        int lado, x, y;
                        Console.WriteLine("Indique cuando mide un lado del cuadrado");
                        lado = Convert.ToInt32(Console.ReadLine());
                        Area = lado * lado;
                        Console.WriteLine("El area es: " + Area);
                        Console.WriteLine("");

                        for (x = 1; x <= lado; x++)
                        {
                            for (y = 1; y <= lado; y++)
                            {
                                Console.WriteLine("*  ");
                            }
                            Console.WriteLine(" ");
                        }
                        //-----------------------------------------------------------------------------------
                    }

                    break;
            }

            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("Desea continuar? y/n: ");
            continuar = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Clear();

            while (continuar != "n") ;

            Console.WriteLine("Adios");
            Console.ReadKey();
        }
        

    }
}