namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Alice"); //escreve e pula linha

            //Console.Write("Staphanie"); //escreve sem pular linha

            //int codigo = Console.Read(); //captura o codigo do primeiro caratere e espera o enter

            string texto = Console.ReadLine(); //captura o que for escrito em string

            Console.WriteLine(texto);

            Console.ReadKey(); //pausa e captura uma tecla do teclado 
        }
    }
}