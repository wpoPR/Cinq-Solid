using System;
using System.Collections.Generic;

namespace Cinq.Dojo.Solid.Core
{
    public class Funcionario
    {
        public double Salario { get; set; }

        public CargoEnum Cargo { get; set; }

        public string Nome { get; set; }
    }

    public class Vendedor : Funcionario
    {
        public double Comissão { get; set; }

        public double CalculaSalarioVendedor()
        {
            return Salario + Comissão;
        }
    }

    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        public double CalculaSalarioGerente()
        {
            return Salario + Bonus;
        }
    }

    public class FolhaSalarial
    {
        public void ImprimirFolhaSalarial(IList<Funcionario> funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                switch (funcionario.Cargo)
                {
                    case CargoEnum.Vendendor:
                        var vendedor = (Vendedor) funcionario;
                        Console.WriteLine($"{vendedor.Nome} -- {vendedor.CalculaSalarioVendedor()}");
                        break;
                    case CargoEnum.Gerente:
                        var gerente = (Gerente)funcionario;
                        Console.WriteLine($"{gerente.Nome} -- {gerente.CalculaSalarioGerente()}");
                        break;
                }
            }
        }
    }

    public enum CargoEnum
    {
        Vendendor,
        Gerente
    }
}