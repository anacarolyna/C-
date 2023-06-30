//módulo STRINGS
using System.Text;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuild();
        }

        static void Identificador()
        {
            //GUIDS 

            var id = Guid.NewGuid(); //identificador global unico, gera um hash
            id.ToString();

            id = new Guid("f618af12-4b26-4004-9904-b3296dc418c9");//gera um guid com o valor que informei
                                                                  // if (id == Guid.NewGuid())
                                                                  // {

        }

        static void Interpolacao()
        {
            var price = 10.2;
            // var text = "O preço do produto é" + price;
            // var texto = string.Format("O preço do produto é {0} apenas na promação {1}", price, true);
            var texto = $@"O preço do 
            produto é {price} apenas na promoção"; //@ = mais linhas

            Console.WriteLine(texto);
        }

        static void Comparacao()
        {
            //COMPARAÇÃO DE STRINGS
            var texto = "Este texto é um teste";
            // Console.WriteLine(texto.CompareTo("Testando")); //compara strings completamente iguais = retorna 0 ou 1
            // Console.WriteLine(texto.CompareTo("testando"));
            Console.WriteLine(texto.Contains("teste"));// ver se existe uma palavra dentro do texto = retorna true or false
            Console.WriteLine(texto.Contains("hey"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));// ignora o case sensitive
            Console.WriteLine(texto.Contains(null));
        }

        static void StarsWithandEndsWith()//começa com e termina com
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("texto"));
            Console.WriteLine(texto.EndsWith("teste"));
        }

        static void Igual()//EQUALS
        {
            //sempre comparar com o mesmo tipo, int com int, string com string etc...
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }

        static void Indices()//INDEX mesmo tipo
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));//IndexOf
            Console.WriteLine(texto.LastIndexOf("s"));//LastIndexOf
        }

        static void MetodosAdicionais()//converter minusc e maiusc
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToLower());//Minusculo
            Console.WriteLine(texto.ToUpper());//Maiusculo
            Console.WriteLine(texto.Insert(10, " AQUI"));
            Console.WriteLine(texto.Remove(5, 5));
            Console.WriteLine(texto.Length);//quantidade de caracteres que uma string tem
        }

        static void ManipulandoStrings()
        {
            var texto = "Este texto é um teste";
            //Console.WriteLine(texto.Replace("Este", "isto"));//
            Console.WriteLine(texto.Replace("e", "A"));

            var divisao = texto.Split(" ");//lista de strings
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(5, 5);//prmeiro = começa, segunda pega 5 caracteres
            //var resultado = texto.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado);

            Console.WriteLine(texto.Trim());//limpa os espaços do começo e do fim

        }

        static void StringBuild()//linhas string
        {
            var texto = new StringBuilder();//contruir
            texto.Append("Este texto é um teste");
            texto.Append("é um teste");
            texto.Append("Este um teste");
            //texto += "aqui";//concatenação

            //converter = texto.ToString();
            Console.WriteLine(texto);
        }
    }
}