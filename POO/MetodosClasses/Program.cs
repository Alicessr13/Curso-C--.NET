namespace MetodosClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Comprimentar();
            m.Somar(23,42);
            m.Apresentar("Alice", 20);

            Console.ReadKey();

        }
    }
}