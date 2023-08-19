namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();

            t.Nome = "Alice";
            t.Idade = 20;
            t.Sobrenome = "Stephanie";

            Console.WriteLine(t.Nome + " " + t.Sobrenome);
            Console.WriteLine(t.Idade);
            Console.WriteLine(t.Ano);

            Console.ReadKey();
        }
    }
}