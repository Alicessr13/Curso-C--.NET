namespace Variaveis
{
    internal class Program
    {

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        enum Notas
        {
            minimo = 10, 
            media = 20, 
            maxima = 30
        }

        //metodo principal do programa
        static void Main(string[] args)
        {
            /*
             * bloco de comentarios
             */
            #region inteiro

            //int num;
            //int num2;
            //num2 = 120;

            //num = num2;

            //Console.WriteLine(num);

            //da uma pausa no programa e espera que clique em uma tecla
            //Console.ReadKey();

            #endregion

            #region real

            //casas decimais se usa . padrão ingles
            float num = 100.9f; //float tem que ter a letra F (long também se usa L)

            double num2 = 500.748; //double não precisa de letra auxiliar

            decimal num3 = 468486.587m; //decimal precisa da letra auxiliar M

            //Console.WriteLine(num);

            #endregion

            #region char
            //aspas simples
            char letra = 'a'; //somente 1 caractere 
            char letra2 = '\u0061'; // \u quer dizer que vai inserir um código de um caractere
            char escape = '\n'; //quebra de linha
            char escape2 = '\0'; //caractere nulo
            char escape3 = '\\'; //representa a barra invertida

            #endregion

            #region boolean

            bool varBool = false; //true ou false

            #endregion

            #region String
            //aspas duplas
            string texto = "Alice Stephanie \n2003 @!"; // @ antes das aspas faz ignorar o \n
            string mensagem = null;
            mensagem = texto;

            #endregion

            #region var

            // recebe o tipo do dado e assume esse tipo até o final do programa
            //valor tem que ser definido na criação
            var valor = 13;

            #endregion

            #region object
            // é a base para todos os outros tipos de dados e recebe qualquer tipo de dado
            // não assume o tipo, somente comporta o tipo 
            object obj = false;
            obj = 200; 
            obj = "Alice";

            #endregion

            #region constante
            //seu valor não pode ser alterado
            //valor tem que ser definido na criação
            const double pi = 3.14;
            const string nome = "Alice";

            #endregion

            #region enumeração

            //tem que ser declarada na raiz da classe para ser utilizada
            Notas notasAlunos = Notas.media;

            #endregion

            #region struct

            Pessoa p1 = new Pessoa();
            p1.nome = "Alice";
            p1.idade = 19;
            p1.altura = 1.52;

            Pessoa p2 = new Pessoa()
            {
                nome = "Malia",
                idade = 5,
                altura = 0.30
            };

            p1.idade = 20;

            #endregion

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);
            Console.ReadKey();

        }
    }
}