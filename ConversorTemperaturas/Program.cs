namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("Conversor de temperaturas:\n");
            Console.WriteLine("Insira a temperatura em Celcius:");
            c = double.Parse(Console.ReadLine());  // captura o que foi digitado e transforma em double

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");

            f = (c * 9 / 5) + 32;

            k = c + 273.15;

            Console.WriteLine(c+" graus celcius = "+f+" graus fahrenheit");
            Console.WriteLine(c + " graus celcis = " + k + " graus kelvin");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();


        }
    }
}