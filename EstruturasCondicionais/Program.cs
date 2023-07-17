namespace EstruturasCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else encadeado
            //int valor = 25;

            //if (valor < 5) 
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else if (valor >= 5 && valor <10)
            //{
            //    Console.WriteLine("Condição alternativa 1");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição alternativa 2");
            //}
            //else
            //{
            //    Console.WriteLine("Condição alternativa final");
            //}

            //Console.ReadKey();
            #endregion

            #region if else aninhado
            //int numero = 13;

            //if(numero > 5)
            //{
            //    Console.Write("O numero é maior que 5 ");

            //    if (numero%2 == 0)
            //    {
            //        Console.WriteLine("e também é par. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("e também é impar. ");
            //    }

            //}

            //Console.ReadKey();
            #endregion

            #region operador ternário 

            int numero = 10;

            string mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            // sintaxe operador ternário: condição ? true : false;

            //mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            //mensagem recebe "maior que 5" se a variavel for maior que 5 se não recebe "menor que 5"

            //Console.WriteLine(mensagem);

            Console.WriteLine(numero > 5 ? "Maior que 5" : "Menor que 5");
            Console.ReadKey();

            #endregion
        }
    }
}