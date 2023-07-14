namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ou vetor bidimensional 
            int[,] numeros = new int[2, 3]; //2 linhas e 3 colunas  armazena 6 elementos 

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 50;
            numeros[1, 1] = 60;
            numeros[1, 2] = 100;

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]\n");

            Console.WriteLine();

            string[,] nomes =
            {
                {"Alice","Stephanie","Soares","Ribeiro" }, //2 linhas com 4 colunas cada
                {"Gabriel","Danny","Artur","Flavio" }
            };

            Console.WriteLine(nomes[0,1]);

            Console.ReadKey();
        }
    }
}