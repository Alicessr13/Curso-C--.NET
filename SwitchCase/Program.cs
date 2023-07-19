namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 1;

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Opção 1");
                    break;
                case 3:
                    Console.WriteLine("Opção 1");
                    break;

                default:
                    Console.WriteLine("Opção default");
                    break;
            }

            Console.ReadKey();
        }
    }
}