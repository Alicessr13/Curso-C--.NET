namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5]; // declaração de um vetor que armazena 5 elementos

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            numeros[2] = 55; //alterando o valor do indice 2

            Console.WriteLine(numeros[2]);

            string[] nomes = { "Alice", "Artur", "Graziella", "Carol" }; //vetor de 4 elementos, até o final 

            Console.WriteLine(nomes[1]);
        }
    }
}