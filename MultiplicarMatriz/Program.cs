namespace MultiplicarMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa para realizar a multiplicação de matriz 
            int[,] matriz1 = new int[2, 3];

            int[,] matriz2 = new int[3, 2];

            int[,] resultado = new int[2, 2];


            Console.WriteLine("Preencher a Matriz 1: ");

            for(int linha = 0; linha < 2; linha++)
            {
                for(int colunas = 0; colunas < 3; colunas++)
                {
                    //percorre todo esse for de colunas e depois vai para o for de linha
                    Console.Write("1 matriz posição [" + linha + "][" + colunas + "] = ");
                    int v = int.Parse(Console.ReadLine());
                    matriz1[linha, colunas] = v;
                }
            }


            Console.WriteLine("\nPreencher a Matriz 2: ");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int colunas = 0; colunas < 2; colunas++)
                {
                    //percorre todo esse for de colunas e depois vai para o for de linha
                    Console.Write("2 matriz posição [" + linha + "][" + colunas + "] = ");
                    int v = int.Parse(Console.ReadLine());
                    matriz2[linha, colunas] = v;
                }
            }

            Console.WriteLine("\nResultado da Matriz 1 x Matriz 2: \n");
            resultado[0,0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resultado[1,0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resultado[0,1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resultado[1,1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + resultado[0,0]+"] [" + resultado[0,1]+"]");
            Console.WriteLine("[" + resultado[1,0] + "] [" + resultado[1,1] + "]");

            Console.ReadKey();


        }
    }
}