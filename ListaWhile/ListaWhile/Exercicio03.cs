using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.WriteLine("Digite o peso: ");
            double contador = 0;
            double peso = Convert.ToDouble(Console.ReadLine());

            while ((peso >= 0) && (peso <= 300.00))
            {
                
                contador = contador + 1;
                Console.WriteLine("Digite o peso: " + peso);
                peso = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Quantidade de pessoas cadastradas " + contador);


        }
    }
}
