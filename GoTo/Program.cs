namespace GoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio: //label 
            Console.Write("Escolha uma opção: ");
            int op = int.Parse(Console.ReadLine());

            int valor = 0;
            switch (op)
            {
                default:
                    goto Inicio;

                case 1:
                    valor += 100;
                    break;

                case 2: 
                    valor += 50;
                    goto case 1;
            }

            Console.WriteLine("Valor final "+valor);
            Console.ReadKey();

        }
    }
}