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
                    Console.WriteLine("Opção 2");
                    break;

                case 3: //como não tem um break se for escolido a opção 3 ou 4 será executado o mesmo código
                case 4:
                    Console.WriteLine("Opção combinada");
                    break;

                default:
                    Console.WriteLine("Opção default");
                    break;
            }

            Console.ReadKey();
        }
    }
}