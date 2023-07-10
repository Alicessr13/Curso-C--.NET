namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region conversão implicita
            byte num1 = 100; // 8 bits, de 0 a 255
            ushort num2; // 16 bits, 0 a 65.535

            num2 = num1; //conversão sem problemas pq byte é menor do que ushort

            float num3 = 1230.43f;
            double num4 = num3; //também sem problemas 

            char letra = 'C';
            int numero = letra; //vai pegar o código numerico desse caracter, int suporta char 

            //Console.WriteLine(numero);
            #endregion

            #region conversão explicita

            ushort numero1 = 100;
            byte numero2 = (byte)numero1; // pode haver perca de dados se o dado for maior do que cabe na veriavel 

            float numero3 = 2500.76f;
            int numero4 = (int)numero3; //como int não aceita virgula há perca de dados

            char letra1 = (char)97; //vai imprimir o caracter correspondente a esse valor

            //Console.WriteLine(letra1);

            #endregion

            #region metodo parse 
            string txtNumero = "1985"; 

            int numero6 = int.Parse(txtNumero); //se tiver letras o metodo não funciona

            byte numero7 = byte.Parse("120");

            double numero8 = double.Parse("123445,76"); //usa virgula pq a linguagem do computador é portugues 

            float numero9 = float.Parse("6222,843"); //não precisa colocar a letra f no final

            //console.WriteLine(numero6);
            //Console.ReadKey();
            #endregion

            #region classe convert

            string texto = Convert.ToString(2500);

            double num5 = Convert.ToDouble(false);

            int num6 = Convert.ToInt32('c');

            Console.WriteLine(num5);
            Console.ReadKey();
            #endregion
        }
    }
}