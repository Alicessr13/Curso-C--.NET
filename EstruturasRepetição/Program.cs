namespace EstruturasRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while
            int valor = 0;

            while (valor<10) //equanto for verdadeiro
            {
                //Console.WriteLine("O valor é "+valor);
                valor++;
            }
            #endregion

            #region do while

            int valor2 = 15;

            do //igual while mas executa pelo menos a primeira vez
            {
                //Console.WriteLine("O valor é " + valor2);
                valor2++;

            } while (valor2<10);

            #endregion

            #region
            
            for(int i = 0, j = 10; i < 10; i++, j--)
            {
                Console.WriteLine("i = "+i+" | j = "+j);

            }

            #endregion
            Console.ReadKey();
        }
    }
}