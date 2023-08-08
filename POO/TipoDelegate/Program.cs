namespace TipoDelegate
{
    internal class Program
    {
        delegate int Operacao(int num1, int num2); //pode ser criado com qualquer tipo de retorno e qualquer tipo de assinatura
        static void Main(string[] args)
        {
            //delegate e um tipo personalizado
            Matematica m = new Matematica();

            Operacao conta = null;

            conta += m.Somar; // o objeto delegate vai se comportar como sendo o metodo somar
            //vai retornar tudo que o metodo faz

            conta += m.Subtração;
            conta += m.Multiplicar;
            conta += m.Dividir;
            conta += m.Multiplicar;

            conta(10, 2);

            Console.WriteLine();

            conta -= m.Dividir;
            conta -= m.Subtração;

            conta(15, 3);

            Console.ReadKey();
        }
    }
}