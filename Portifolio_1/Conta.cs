using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Portifolio_1
{
        // atributos
    internal class Conta
    {
        public int Numero {  get; private set; }
        public string Titular { get; private set; }
        public double Saldo {  get; private set; }

        // contrutores
        public Conta(int numero, string titular, double depositoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
            Deposito(depositoInicial);
        }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }


        // metodos utilizados

        public void AlterarTitular(string novoTitular)
        {
            Titular = novoTitular;
        }
        public void Deposito(double quantia)
        {
           Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }


        
        // impressão dos dados
        public override string ToString()
        {
            return "Conta: " +
                Numero +
                ", Titular: " +
                Titular +
                ", Saldo: " +
                Saldo.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
        }


    }

}
