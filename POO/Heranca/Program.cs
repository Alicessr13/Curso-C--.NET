namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uma classe herda atributos metodos e comportamentos de outra classe
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();

            // classe abstrata é uma classe que é somente base de outras classes, não sendo instanciada por conta propria 

            c.Acelerar();
            b.Acelerar();

            Console.ReadKey();
        }
    }
}