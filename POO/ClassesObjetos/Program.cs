namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse mClasse = new MinhaClasse(); //criação de objeto 
            MinhaClasse m2 = null; //objeto não inicializado

            OutraClasse Outra = new OutraClasse();
            OutraClasse Outra2 = Outra; //atribui a referencia do objeto
        }
    }

    class MinhaClasse 
    {

    }

}