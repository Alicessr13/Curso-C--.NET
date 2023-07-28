namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e objetos
            //MinhaClasse mClasse = new MinhaClasse(); //criação de objeto 
            //MinhaClasse m2 = null; //objeto não inicializado

            //OutraClasse Outra = new OutraClasse();
            //OutraClasse Outra2 = Outra; //atribui a referencia do objeto não o valor 
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Alice";
            p1.sobrenome = "Stephanie";
            p1.anoNascimento = 2003;

            Pessoa p2 = new Pessoa()
            {
                nome = "Artur", 
                sobrenome = "Ribeiro",
                anoNascimento = 1985
            };

            p1.sobrenome = "Soares";

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);

            Console.WriteLine();

            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);

            Console.ReadKey();


        }
    }

    class MinhaClasse 
    {

    }

}