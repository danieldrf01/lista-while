using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    class Exercicio07
    {
        public Exercicio07()
        {

            int jogador = 0;

            double somaM = 0;
            double somaF = 0;

            double peso = 0, maiorPeso = int.MinValue, menorPeso = int.MaxValue;

            double altura = 0, maiorAltura = int.MinValue, menorAltura = int.MaxValue;

            int cartaoAmarelo = 0, maiorQuantidade1 = int.MinValue, menorQuantidade1 = int.MaxValue;
            int cartaoVermelho = 0, maiorQuantidade2 = int.MinValue, menorQuantidade2 = int.MaxValue;
            
            string nomeAux1 = "0";
            string nomeAux2 = "0"; 

            while (jogador < 1)
            {

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                string modeloAux = nome.ToLower();
                int tamanhoNome = nome.Length;
                int tamanhoNomeAux = 0;
                
                Console.Write("\nIdade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nPeso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nSexo: ");
                char sexo = Console.ReadLine()[0];
                char sexoAux = Char.ToLower(sexo);
                Console.Write("\nAltura: ");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nQuantidade de Gols: ");
                int quantidadeDeGols = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nQuantidade de cartões amarelo: ");
                cartaoAmarelo = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nQuantidade de cartões vermelho: ");
                cartaoVermelho = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (sexoAux == 'f')
                {
                    jogador = jogador + 1;
                }

                if (sexoAux == 'g')
                {
                    jogador = jogador + 1;
                }

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                }

                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                }

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                }

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                }

                if (altura < menorAltura)
                {
                    menorAltura = altura;
                }

                if (tamanhoNomeAux > tamanhoNome )
                {
                    tamanhoNome = tamanhoNomeAux;
                        nomeAux1 = nome;
                }

                if (tamanhoNomeAux < tamanhoNome)
                {
                    tamanhoNome= tamanhoNomeAux;
                    nomeAux2 = nome;
                }

                if (cartaoAmarelo > maiorQuantidade1)
                {
                    maiorQuantidade1 = cartaoAmarelo;
                }

                if (cartaoAmarelo < menorQuantidade1)
                {
                    menorQuantidade1 = cartaoAmarelo;
                }

                if (cartaoVermelho > maiorQuantidade2)
                {
                    maiorQuantidade2 = cartaoVermelho;
                }

                if (cartaoVermelho < menorQuantidade2)
                {
                    menorQuantidade2 = cartaoVermelho;
                }

            }

            Console.WriteLine("\nJogador com maior peso: " + maiorPeso);
            Console.WriteLine("\nJogador com menor peso: " + menorPeso);
            Console.WriteLine("\nJogador com maior altura: " + maiorAltura);
            Console.WriteLine("\nJogador com menor altura: " + menorAltura);
            Console.WriteLine("\nQuantidade de jogadores masculinos: " + jogador);
            Console.WriteLine("\nQuantidade de jogadores femininos: " + jogador);
            Console.WriteLine("\nJogador com maior nome: " + nomeAux1 );
            Console.WriteLine("\nJogador com menor nome: " + nomeAux2);
            Console.WriteLine("\nMaior quantidade de cartões amarelo: " + maiorQuantidade1);
            Console.WriteLine("\nMenor quantidade de cartões amarelo: " + menorQuantidade1);
            Console.WriteLine("\nMaior quantidade de cartões vermelho: " + maiorQuantidade2);
            Console.WriteLine("\nMenor quantidade de cartões vermelho: " + menorQuantidade2);





        }
    }
}
