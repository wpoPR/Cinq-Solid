using System;

namespace Cinq.Dojo.Solid.DoJeitoSERTU
{
    public class Conta
    {
        public int Id { get; set; }

        public string Documento { get; set; }

        public double Saldo { get; set; }

        public TipoContaEnum Tipo { get; set; }
    }

    public class ContaCorrente : Conta
    {
        public double Limite { get; set; }
    }

    public abstract class ContaService<T>  where T : Conta
    {
        public void Transferir(double valor, T conta, T contaDestino)
        {
            if (!SaldoDisponivel(valor, conta)) throw new Exception("Saldo Indisponível");

            Creditar(valor, contaDestino);
            Debitar(valor, conta);
        }

        public void Creditar(double valor, T conta)
        {
            conta.Saldo += valor;
        }

        public abstract bool SaldoDisponivel(double valor, T conta);
        public abstract void Debitar(double valor, T conta);
    }

    public class ContaPoupancaService : ContaService<Conta>
    {
        public override bool SaldoDisponivel(double valor, Conta conta)
        {
            return valor <= conta.Saldo;
        }

        public override void Debitar(double valor, Conta conta)
        {
            if (!SaldoDisponivel(valor, conta)) throw new Exception("Saldo Indiponível");

            conta.Saldo -= valor;
        }
    }

    public class ContaCorrenteService : ContaService<ContaCorrente>
    {
        public override bool SaldoDisponivel(double valor, ContaCorrente conta)
        {
            return valor <= (conta.Saldo + conta.Limite);
        }

        public override void Debitar(double valor, ContaCorrente conta)
        {
            if (!SaldoDisponivel(valor, conta)) throw new Exception("Saldo Indiponível");

            conta.Saldo -= valor;
        }
    }

    public enum TipoContaEnum
    {
        Poupanca,
        ContaCorrente
    }
}