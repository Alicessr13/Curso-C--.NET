namespace EstruturasRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            while (valor<10)
            {
                Console.WriteLine("O valor é "+valor);
                valor++;
            }

            Console.ReadKey();
        }
    }
}