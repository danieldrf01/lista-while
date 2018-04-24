using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.Write("Numero1: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número2: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" __________________________________");
            Console.WriteLine("|             MENU                 |");
            Console.WriteLine("|                                  |");
            Console.WriteLine("|__________________________________|");
            Console.WriteLine("|1                 |Somar          |");
            Console.WriteLine("|__________________|_______________|");
            Console.WriteLine("|2                 |Subtrair       |");
            Console.WriteLine("|__________________|_______________|");
            Console.WriteLine("|3                 |Multiplicar    |");
            Console.WriteLine("|__________________|_______________|");
            Console.WriteLine("|4                 |Dividir        |");
            Console.WriteLine("|__________________|_______________|");
            Console.WriteLine("|5                 |Sair           |");
            Console.WriteLine("|__________________|_______________|");

            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != 5)
            {


                if (opcao == 1)
                {
                    Console.WriteLine("Soma " + (numero1 + numero2));
                }

                else if (opcao == 2)
                {
                    Console.WriteLine("Subtração: " + (numero1 - numero2));
                }

                else if (opcao == 3)
                {
                    Console.WriteLine("Multiplicação: " + (numero1 * numero2));
                }

                else if (opcao == 4)
                {
                    Console.WriteLine("Divisão: " + (numero1 / numero2));
                }

                Console.WriteLine(" __________________________________");
                Console.WriteLine("|             MENU                 |");
                Console.WriteLine("|                                  |");
                Console.WriteLine("|__________________________________|");
                Console.WriteLine("|1                 |Somar          |");
                Console.WriteLine("|__________________|_______________|");
                Console.WriteLine("|2                 |Subtrair       |");
                Console.WriteLine("|__________________|_______________|");
                Console.WriteLine("|3                 |Multiplicar    |");
                Console.WriteLine("|__________________|_______________|");
                Console.WriteLine("|4                 |Dividir        |");
                Console.WriteLine("|__________________|_______________|");
                Console.WriteLine("|5                 |Sair           |");
                Console.WriteLine("|__________________|_______________|");

                opcao = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
