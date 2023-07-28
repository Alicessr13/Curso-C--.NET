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

            Console.WriteLine("Valor 1: " + num1); //100
            Console.WriteLine("Valor 2: " + num2); //110

            Console.WriteLine();

            string nomeCompleto = m.MontaNome("Alice", "Stephanie");
            int codigoChar = m.CodigoChar('a');
            double PI = m.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(PI);

            Console.ReadKey();

        }
    }
}