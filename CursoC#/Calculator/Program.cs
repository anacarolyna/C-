
using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)// método principal Main
        {
            Menu();//chama o método
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo! Qual operação deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break; //sair do sistema no console
                default: Menu(); break;

                    // if (res == 1)
                    //     Soma()

            }

            static void Soma() //método soma
            {

                Console.Clear();
                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                float resultado = v1 + v2;
                Console.WriteLine($"O resultado da soma é: {resultado}");
                Console.ReadKey(); //não fecha a execução do programa


                // Console.WriteLine("O Resultao da soma é: "+ resultado);
                // Console.WriteLine($"O resultado da soma é {vl+v2}"); //<- outra forma de fazer
                // Console.WriteLine ("O resultado da soma é " + (v1 + v2));
            }

            static void Subtracao()

            {
                Console.Clear();

                Console.WriteLine("Primeiro Valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo Valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 - v2;
                Console.WriteLine($"O resultado da subtração é: {resultado} ");
                Console.ReadKey(); //não fecha a execução do programa

            }

            static void Divisao()
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 / v2;
                Console.WriteLine($"O resultado da divisão é: {resultado} ");
                Console.ReadKey(); //não fecha a execução do programa



            }

            static void Multiplicacao()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo Valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 * v2;

                Console.WriteLine($"O resultado da multiplicação é: {resultado} ");
                Console.ReadKey(); //não fechar a execução do programa, so quando der enter ou outra tecla
            }

        }
    }
}