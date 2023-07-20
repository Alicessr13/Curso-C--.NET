namespace EstruturasRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while
            int valor = 0;

            while (valor<10)
            {
                //Console.WriteLine("O valor é "+valor);
                valor++;
            }
            #endregion

            #region do while

            int valor2 = 15;

            do
            {
                Console.WriteLine("O valor é " + valor2);
                valor2++;

            } while (valor2<10);

            #endregion
            Console.ReadKey();
        }
    }
}