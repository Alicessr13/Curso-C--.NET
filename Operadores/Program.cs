using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region operadores matematicos
            int num1 = 15;

            int num2 = 2;

            //int resultado = num1 + num2;

            //Console.WriteLine(num1 + num2+"\n");

            //Console.WriteLine(num1 - num2+"\n");

            //Console.WriteLine(num1 * num2 + "\n");

            ///Console.WriteLine(num1 / num2 + "\n");

            //Console.WriteLine(num1 % num2 + "\n");
            #endregion

            #region regras de precedência

            //primeiro é executado os parenteses, depois multiplicação e divisão e depois soma e subtração

            //mesmo nivel de prioridade é primeiro feito o que tiver do lado esquerdo 

            double num3 = 100;

            double num4 = 10;

            double num5 = 5;

            double resultado = (num3 + num4) * (num5 / 2);

            //Console.WriteLine(resultado);

            #endregion

            #region operadores de incremento e decremento

            int numero = 10;

            numero++; //mesma coisa que numero = numero + 1;  pós incremento, processa a variavel e depois adiciona o valor 

            ++numero; //pré incremento, primeiro adiciona o valor e depois a variavel é processada 

            //Console.WriteLine(numero++); //imprime 12 (mas após a execução completa da linha o valor vai ser 13

            //Console.WriteLine(++numero); //imprime 13

            //operadores de decremento é igual

            #endregion

            #region concatenação

            //com string o + faz a concatenação

            string nome = "Alice " + "Stephanie ";

            string sobrenome = "Soares Ribeiro ";

            string nomeCompleto = nome + sobrenome + 2003;

            //Console.WriteLine(nomeCompleto);

            #endregion

            #region atribuição

            int numero1 = 10; //sobrescreve o valor que a variavel já possuir

            numero1 += 20; // mesma coisa que numero1 = numero1 + 20;

            numero1 -= 2;

            string nome2 = "Alice";

            //nome2 = "Stephanie";  o nome é sobreescrito

            nome2 += " Stephanie";

            Console.WriteLine(numero1);
            Console.WriteLine(nome2);

            #endregion

            Console.ReadKey();
            
        }
    }
}