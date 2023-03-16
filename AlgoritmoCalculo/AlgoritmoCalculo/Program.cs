using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoCalculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double soma;
            string nome, resposta;

            Console.WriteLine("Olá, qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Tudo bem com você, " + nome + "?");
            resposta = Console.ReadLine();

            if (resposta == "Sim")
            {
                Console.WriteLine("Que bom!");
            }
            else if (resposta == "Não")
            {
                Console.WriteLine("Que pena...");
            }
            Console.WriteLine("Gostaria de fazer uns cálculos?");
            resposta = Console.ReadLine();

            if (resposta == "Sim")
            {
                Console.WriteLine("Então vamos começar\n");
                Console.WriteLine("Digite um número para somar:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                num2 = double.Parse(Console.ReadLine());

                soma = num1 + num2;
                Console.WriteLine("\nO resultado é: " + soma + "\n");

                string operação;

                Console.WriteLine("Agora escolha uma operação.");
                operação = Console.ReadLine();
                Console.WriteLine("Para qual número?");
                num1 = double.Parse(Console.ReadLine());

                if (operação == "Soma")
                {
                    Console.WriteLine("O resultado é: " + (num1 + soma));
                }
                else if (operação == "Multiplicação")
                {
                    Console.WriteLine("O resultado é: " + num1 * soma);
                }
                else if (operação == "Subtração")
                {
                    Console.WriteLine("O resultado é: " + (soma - num1));
                }
                else if (operação == "Divisão")
                {
                    Console.WriteLine("O resultado é: " + soma / num1);
                }
                else
                    Console.WriteLine("Digite uma operação possível.");
                }
            if(resposta == "Não")
            {
                Console.WriteLine("Tudo bem, tchau!");
            }
            Console.WriteLine("Fim");
            }
        }
    }

