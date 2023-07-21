using System.Drawing;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, controle = 1, result=0;


            Console.WriteLine("Quantos valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia de Fibonacci com " + valores + " valores");

            for(int i = 0; i < valores; i++)
            {
                if(i <valores - 1)
                {
                    Console.Write(num + ", ");
                }
                else
                {
                    Console.Write(num + " ");
                }
                

                result = num + controle;
                num = controle;
                controle = result;
            }

            Console.ReadKey();
        }
    }
}