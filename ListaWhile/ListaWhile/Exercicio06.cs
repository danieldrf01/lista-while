using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    class Exercicio06
    {
        public Exercicio06()
        {
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("|Código    |Tipo                 |Nome                              |Valor     |");
            Console.WriteLine("|__________|_____________________|_________________________________ |__________|");
            Console.WriteLine("|1         |Bolos                |Bolo Brigadeiro                   |R$ 29.50  |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|2         |Bolos                |Bolo Floresta Negra               |R$ 2.00   |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|3         |Bolos                |Bolo Leite Com Nutella            |R$ 29.23  |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|4         |Bolos                |Bolo Mousse de Chocolate          |R$ 7.10   |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|5         |Bolos                |Bolo Nega Maluca                  |R$ 19.33  |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|6         |Doces                |Bomba de Creme                    |R$ 17.71  |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|7         |Doces                |Bomba de Morango                  |R$ 4.82   |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|8         |Sanduíches           |Filé-Mignon com fritas e          |R$ 21.16  |");
            Console.WriteLine("|          |                     |cheddar                           |          |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|9         |Sanduíches           |Hambúrber com queijos,            |R$ 12.70  |");
            Console.WriteLine("|          |                     |champignon e rúcula               |          |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|10        |Sanduíches           |Provolone com salame              |R$ 19.70  |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|11        |Sanduíches           |Vegetariano de berinjela          |R$ 28.22  |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|12        |Pizzas               |Calabresa                         |R$ 8.98   |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|13        |Pizzas               |Napolitana                        |R$ 0.42   |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|14        |Pizzas               |Peruana                           |R$ 18.36  |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|15        |Pizzas               |Portuguesa                        |R$ 27.50  |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");
            Console.WriteLine("|16        |                     |Sair                              |          |");
            Console.WriteLine("|__________|_____________________|__________________________________|__________|");

            Console.WriteLine("Solicite um produto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            int bolo = Convert.ToInt32(Console.ReadLine());
            int doce = Convert.ToInt32(Console.ReadLine());
            int sanduiche = Convert.ToInt32(Console.ReadLine());
            int pizza = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            double valor = Convert.ToDouble(Console.ReadLine());
            int produto = 0;

            while (codigo != 16)
            {
                produto = produto + 1;


                if ((produto > 0 ) && (produto < 6)) 
                {
                    bolo = bolo + 1;
                }

                if ((produto > 5) && (produto < 8))
                {
                    doce = doce + 1;

                }

                if ((produto > 7) && (produto < 12))
                {
                    sanduiche = sanduiche + 1;
                }

                if ((produto > 11) && (produto < 16)) 
                {
                    pizza = pizza + 1;
                }

                if (produto == 1)
                {
                    valor = 29.50;
                }

                if (produto == 2)
                {
                    valor = 2.00;
                }

                if (produto == 3)
                {
                    valor = 29.23;
                }

                if (produto == 4)
                {
                    valor = 7.10;
                }

                if (produto == 5)
                {
                    valor = 19.33;
                }

                if (produto == 6)
                {
                    valor = 17.71;
                }

                if (produto == 7)
                {
                    valor = 4.82;
                }

                if (produto == 8) 
                {
                    valor = 21.16;
                }

                if (produto == 9)
                {
                    valor = 12.70;
                }

                if (produto == 10)
                {
                    valor = 19.70;
                }

                if (produto == 11)
                {
                    valor = 28.22;
                }

                if (produto == 12)
                {
                    valor = 8.98;
                }

                if (produto == 13)
                {
                    valor = 0.42;
                }

                if (produto == 14)
                {
                    valor = 18.36;
                }

                if (produto == 15) 
                {
                    valor = 27.50;
                }


                
                Console.WriteLine("Quantidade de produtos consumidos: " + produto ); 
                Console.WriteLine("Total dos pedidos: " + (contador + 1));


                


           }





        }
    }
}
