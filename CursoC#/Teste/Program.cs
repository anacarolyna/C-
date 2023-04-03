//BORA LÁ CALCULADORA SOZINHA

using System;

namespace Teste // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)// método principal Main
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------------");
            Console.WriteLine("Selecione uma opção: ");
            short result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break; //sair do sistema no console
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nO resultado da soma é: " + (v1 + v2));
            Console.ReadKey(); //não fecha a execução do programa
            Menu();

        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nO resultado da Subtração é: " + (v1 - v2));
            Console.ReadKey();//não fecha a execução do programa
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nO resultado da Divisão é: " + (v1 / v2));
            Console.ReadKey();//não fecha a execução do programa
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nO resultado da Multiplicação é: " + (v1 * v2));
            Console.ReadKey();//não fecha a execução do programa
            Menu();

        }
    }
}