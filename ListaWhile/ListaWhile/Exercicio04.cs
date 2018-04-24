using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    class Exercicio04
    {
        public Exercicio04()
        {



            int contador = 0;

            Console.Write("Quantos carros deseja cadastrar? ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int somaAno = 0;

            double somaValor = 0;

            double somaG = 0;
            double somaA = 0;

            string ModeloAux = "";

            while (quantidade > contador)
            {

                contador = contador + 1;

                Console.Write("Modelo do carro: ");
                string modeloCarro = Console.ReadLine();
                ModeloAux = modeloCarro.ToLower();
                ModeloAux.Substring(0, 1);

                Console.Write("Valor: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ano: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                somaAno = somaAno + ano;
                somaValor = somaValor + valor;

                if (ModeloAux.Substring(0, 1) == "g")
                {
                    somaG = somaG + 1;
                }

                else if (ModeloAux.Substring(0, 1) == "a")
                {
                    somaA = somaA + 1;
                }


            }

            double mediaAno = somaAno / contador;
            double mediaValor = somaValor / contador;

            Console.WriteLine("Média do ano dos carros: " + mediaAno);
            Console.WriteLine("Média do valor dos carros: " + mediaValor);
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + somaG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + somaA);

        }
    }
}
