using System;

namespace Cinq.Dojo.Solid.Core
{

    public class ContaCorrente
    {
        public int Id { get; set; }

        public string Documento { get; set; }

        public double Saldo { get; set; }

        public double Limite { get; set; }

        public TipoContaEnum Tipo { get; set; }

        public bool SaldoDisponivel(double valor)
        {
            if (valor <= Saldo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Tranferir(double valor, ContaCorrente destinoContaCorrente)
        {
            if (SaldoDisponivel(valor))
            {
                destinoContaCorrente.Creditar(valor);
                Debitar(valor);
            }
            else
            {
                throw new Exception("Saldo Indisponível");
            }
        }

        public void Debitar(double valor)
        {
            if (Tipo == TipoContaEnum.Poupanca)
            {
                if (SaldoDisponivel(valor))
                {
                    Saldo -= valor;
                }
                else
                {
                    throw new Exception("Saldo Indisponível");
                }
            }

            if (Tipo == TipoContaEnum.ContaCorrente)
            {
                if (SaldoDisponivel(valor))
                {
                    Saldo -= valor;
                }
                else
                {
                    var limiteTotal = Saldo + Limite;
                    if (limiteTotal >= valor)
                    {
                        Saldo -= valor;
                        return;
                    }

                    throw new Exception("Saldo Indisponível");
                }
            }
        }

        public void Creditar(double valor)
        {
            Saldo += valor;
        }
    }

    public enum TipoContaEnum
    {
        Poupanca,
        ContaCorrente
    }
}