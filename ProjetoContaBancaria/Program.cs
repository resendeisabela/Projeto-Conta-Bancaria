using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoContaBancaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haaverá depósito inicial (s/n)? ");
            string acao = Console.ReadLine();
            acao.ToLower();


            if(acao == "s")
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());

            conta.Deposito(quantia);

            Console.WriteLine("\nDados da conta atualizado:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());

            conta.Saque(quantia);

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}
