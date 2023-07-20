namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio2:

            Console.Write("Digite o primeiro número: ");
            double numero = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

        Inicio:
            Console.Write("Qual operação será feita: (+ | - | / | x ): ");
            string oper = Console.ReadLine();

            double result;

            switch(oper)
            {
                case "+":
                    result = numero+ numero2;
                    Console.WriteLine("O resultado da soma é: " + result);
                    break;

                case "-":
                    result = numero - numero2;
                    Console.WriteLine("O resultado da subtração é: " + result);
                    break;

                case "/":
                case ":":
                    if (numero2 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Não é possivel dividir por 0!");
                        goto Inicio2;
                    }
                    else
                    {
                        result = numero / numero2;
                        Console.WriteLine("O resultado da divisão é: " + result);
                        break;
                    }

                case "x":
                case "X":
                case "*":
                    result = numero * numero2;
                    Console.WriteLine("O resultado da multiplicação é: " + result);
                    break;

                default:
                    Console.WriteLine("Digite um operador valido! ");
                    goto Inicio;
            }

            Console.WriteLine("Continuar calculando? ( s / n) ");
            string opcao = Console.ReadLine();

            if(opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                goto Inicio2;
                Console.Clear();
            }

            //Console.WriteLine("O resultado da operação " + oper + " entre " + numero + " e " + numero2 + " é: " + result);
            Console.ReadKey();
        }
    }
}