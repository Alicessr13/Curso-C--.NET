namespace Estatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematica.taxa = 10;//usado para fazer configuração que ficam globais em qualquer parte da aplicação
            //se alterar o valor da taxa em outra classe vai alterar aqui também

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminuir(200);

            Console.WriteLine("Valor 1 = "+valor1);
            Console.WriteLine("Valor 2 = "+valor2);

            Console.WriteLine();

            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();

            p1.nome = "Alice";
            p1.idade = Pessoa.CalcularIdade(2003);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maioridade);

            Console.ReadKey();
        }
    }
}