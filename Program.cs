using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeJogoDaAmizade
{
    internal class Program
    {

        static int totalCartas;

        static void Main(string[] args)
        {
            string resposta;

            Console.Clear();
            Console.WriteLine("Bem vindo ao jogo da amizade");
            Console.WriteLine("Você ganha se conseguir chegar em 21 cartas!");
            Console.WriteLine("Se passar de 21 você perde!");
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine($"Total de cartas: {totalCartas}\n");

            Console.WriteLine("Quer uma carta? (responda com 's' ou 'n')");
            resposta = Console.ReadLine();
            Console.Clear();

            if (resposta == "s")
            {
                Random cartaAleatoria = new Random();
                int carta = cartaAleatoria.Next(1, 10);

                Console.WriteLine($"Você recebeu a carta {carta}");
                totalCartas = totalCartas + carta;

                if (totalCartas == 21)
                {
                    Console.WriteLine($"Você juntou {totalCartas} cartas!");
                    Console.WriteLine("Você ganhou!");
                    Console.WriteLine("Pressione ENTER para encerrar");
                    Console.ReadKey();
                    return;
                }

                if (totalCartas > 21)
                {
                    Console.WriteLine("Você estourou! Perdedor!");
                    Console.WriteLine("Pressione ENTER para encerrar");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Pressine ENTER para continuar!");
                Console.ReadKey();
                Main(null);
                return;
            }
            if (resposta == "n")
            {
                Console.WriteLine($"Você juntou {totalCartas} cartas!");
                Console.WriteLine("Você perdeu!");
                Console.WriteLine("Pressione ENTER para encerrar");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Respostas inválida!");
            Console.WriteLine("Pressine ENTER para continuar!");
            Console.ReadKey();
            Main(null);
            return;
        }
    }
}

