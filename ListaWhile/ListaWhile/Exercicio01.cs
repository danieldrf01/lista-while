using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    class Exercicio01
    {
        public Exercicio01()
        {
            int quantidade = 0;
            Console.Write("Deseja cadastrar um nome ? ");
            string continuar = Console.ReadLine();
            continuar = continuar.ToLower();
          
            while (continuar == "sim")
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Deseja digitar o nome novamente ?");
                continuar = Console.ReadLine();
   
                quantidade = quantidade + 1;     
            }








        }
    }
}
