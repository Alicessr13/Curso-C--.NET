namespace EstruturasCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 25;

            if (valor < 5) 
            {
                Console.WriteLine("Condição verdadeira");
            }
            else if (valor >= 5 && valor <10)
            {
                Console.WriteLine("Condição alternativa 1");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Condição alternativa 2");
            }
            else
            {
                Console.WriteLine("Condição alternativa final");
            }

            Console.ReadKey();
        }
    }
}