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
            Console.WriteLine(p1.idade+"\n");

            Pessoa p2 = new Pessoa("Alice","Ribeiro",2003);

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.sobrenome);
            Console.WriteLine(p2.anoNasc);
            Console.WriteLine(p2.idade + "\n");

            Pessoa p3 = new Pessoa("Malia","Soares");
            
            Console.WriteLine(p3.nome);
            Console.WriteLine(p3.sobrenome);
            Console.WriteLine(p3.anoNasc);
            Console.WriteLine(p3.idade + "\n");

            Console.ReadKey();
        }
    }
}