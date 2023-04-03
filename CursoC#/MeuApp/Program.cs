using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse gamer", 299.97, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine((int)mouse.Type);
        }
    }
    struct Product
    {

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;

        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    { 
    Product = 1,    
    Service = 2
}
}




// static void Main(string[] args)
// {

//     var arr = new string[2];
//     arr[0] = "Item 1";

//     var arr2 = arr;

//      Console.WriteLine(arr[0]);
//      Console.WriteLine(arr2[0]);

//      arr[0] = "Item 2";
//       Console.WriteLine(arr[0]);
//      Console.WriteLine(arr2[0]);


// }


// int x = 25;
// int y = x;
// Console.WriteLine(x);
//Console.WriteLine(y);
// x = 32;
// Console.WriteLine(x);
//Console.WriteLine(y);
// MeuMetodo();
// string nome = RetornaNome("Ana Carolyna", "Diniz Ribeiro");
// Console.WriteLine(nome);


// static void MeuMetodo()
// {
//     Console.WriteLine("AAAAAAA");
// }

// static string RetornaNome(
//     string nome,
//     string sobrenome,
//     int idade = 20,
//     bool teste = false
// )
// {
//     return nome + " " + sobrenome +" tem "+ idade;
// }


// int valor = 0;
// do
// {
//     Console.WriteLine(valor);
//     valor++;
// } while (valor <= 5);



// while (valor <= 5)
// {
//     valor++;
//     Console.WriteLine(valor);

// }


// string valor = "andre";
// switch (valor)
// {
//     case "joao": Console.WriteLine("Não é o cara"); break;
//     case "marcelo": Console.WriteLine("Não é o cara"); break;
//     case "andre": Console.WriteLine("É este!"); break;
//     default: Console.WriteLine("Não encontrei"); break;
// }


// for (int i = 1; i <= 5; i++)
// {
//     for (int multi = 1; multi <= 1; multi++)
//     {
//         Console.WriteLine(multi + " x " + i + " = " + i * multi);

//     }
//     Console.WriteLine();
// }
// Console.Read();


// if (25 != 32)
// {
//     Console.WriteLine("é diferente");

// } else
// {
//      Console.WriteLine("é igual");
// }


// Console.WriteLine("Finalizou o programa");


// double x = 2;
// x = 2 + 2 * 2;
// Console.WriteLine(x);

// int x = 2;
// x += 3;
// Console.WriteLine(x);

//     int x = 2;
//    Console.WriteLine(x == 2);

// int inteiro = 100;
// float real = 25.5f;
// real = inteiro; //100.0f conversão implicita
// inteiro = (int)real;//conversão explicita, pois tenho que colocar o tipo
// string valorReal = real.ToString();
// inteiro = int.Parse(valorReal); obrigatório ser uma string
// inteiro = Convert.ToInt32(real); aceita qualquer tipo de valor
// Console.WriteLine(inteiro);
// Console.WriteLine(Convert.ToBoolean("true"));

// const int IDADE_MINIMA =0; //const geralmente é feita com letra maiuscula depende do projeto
// char letra = 'A';
// string texto = "meru teyhsidja";
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!"+ letra+ texto);




