namespace MetodoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobrenome);
            Console.WriteLine(p1.anoNasc);
            Console.WriteLine(p1.idade);

            Console.ReadKey();
        }
    }
}