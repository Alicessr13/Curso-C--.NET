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

            Console.WriteLine();

            int num1 = 100, num2 = 100;

            m.AumentarValor(num1); //apenas vai pegar a cópia do valor 
            m.AumentarRef(ref num2); // quando for feita a operação será feita no valor da variavel não na cópia

            Console.WriteLine();

            Console.WriteLine("Valor 1: " + num1);
            Console.WriteLine("Valor 2: " + num2);

            Console.ReadKey();

        }
    }
}