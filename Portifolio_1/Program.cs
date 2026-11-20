using Portifolio_1;
using System;
using System.Globalization;

namespace SistemaBancario
{
    public class SistemaBancario
    {
        static void Main(string[] args)
        {
            // solicita a entrada do n° da conta, nome do titular e se terá deposito
            Console.WriteLine("===============================");
            Console.Write("Entre o n° da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char usrDI = char.ToLower(char.Parse(Console.ReadLine()));

            // verifica se o digito é s ou n
            while (usrDI != 's' && usrDI != 'n')
            {
                Console.WriteLine("Inválido!!!");
                Console.Write("Haverá deposito inicial (s/n)? ");
                usrDI = char.ToLower(char.Parse(Console.ReadLine()));
            }

            // define qual dos dois contrutores será usado
            Conta usr;
            if (usrDI == 's')
            {
                Console.WriteLine("===============================");
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                usr = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                usr = new Conta(numero, titular);
            }

            // exibe os dados da conta, solicita o valor do deposito e mostra os dados atualizados
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(usr);
            Console.WriteLine("===============================");
            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usr.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(usr);

            // solicita o valor do saque e mostra os dados atualizados
            Console.WriteLine("===============================");
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usr.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(usr);
            Console.WriteLine("===============================");

            // pergunta se o usuário quer sair, fazer um novo deposito ou se quer atualizar o titular
            int opcoes = 0;
            do
            {
                Console.WriteLine("Deseja fazer qual operação?");
                Console.Write("1) Sair, 2) Novo Deposito, 3) Atualizar nome: ");
                opcoes = int.Parse(Console.ReadLine());

                // verifica se o digito é 1, 2 ou 3
                while (opcoes < 1 && opcoes > 3)
                {
                    Console.WriteLine("Inválido!!!");
                    Console.Write("Digite as opções: 1) air, 2) Novo deposito ou 3) Atualizar nome ");
                    opcoes = int.Parse(Console.ReadLine());
                }

                // verifica qual das opções o usuário escolheu e executa

                switch (opcoes)
                {
                    case 1:
                        Console.WriteLine("Encerrando a aplicação.");
                        break;

                    case 2:
                        Console.Write("Entre um valor para deposito: ");
                        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        usr.Deposito(quantia);
                        Console.WriteLine("Dados da conta atualizados:");
                        Console.WriteLine(usr);
                        Console.WriteLine("===========================");
                        Console.WriteLine("Deseja fazer qual operação?");
                        Console.Write("1) Sair, 2) Novo Deposito, 3) Atualizar nome: ");
                        opcoes = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("Digite o novo titular: ");
                        string novoTitular = Console.ReadLine();
                        usr.AlterarTitular(novoTitular);
                        Console.WriteLine("=============================");
                        Console.WriteLine($"Titular alterado com sucesso: {novoTitular}");
                        break;

                    default:
                        break;
                }

            } while (opcoes != 1);

        }
    }
}