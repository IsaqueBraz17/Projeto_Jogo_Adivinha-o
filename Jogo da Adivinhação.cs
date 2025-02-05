using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Jogo_Adivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randow = new Random();
            int NumeroAleatorio = randow.Next(1,101);
            int Chute;
            int Tentativas = 0;

            Console.WriteLine("Bem-vindo ao jogo da adivinhação!");
            Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

            while (Tentativas < 10) {
                Console.Write("Dgite seu chute: ");
                Chute = int.Parse(Console.ReadLine());
                Tentativas++;

                if (Chute < NumeroAleatorio)
                {
                    Console.WriteLine("Muito baixo!, Tente Novamente.");
                }
                else if (Chute > NumeroAleatorio)
                {
                    Console.WriteLine("Muito Alto! , Tente Novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou o número em.");
                    Console.WriteLine("Fim do jogo. Obrigado por jogar!");
                    break;
                }

                if (Tentativas == 5)
                {
                    Console.WriteLine($"Você usou todas as tentativas. O número secreto era {NumeroAleatorio}.");
                    Console.Write("Você deseja jogar novamente? (sim/não): ");
                }
                while (Console.ReadLine().ToLower() == "sim") ;
            }
        }
    }
}
