﻿namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Alice";

            double valor = 100;
            c.Depositar(valor);

            double valor2 = 50;
            c.Sacar(valor2);

            Console.WriteLine("Cliente: "+c.Cliente);
            Console.WriteLine("Saldo: "+c.Saldo);

            Console.ReadKey();
        }
    }
}