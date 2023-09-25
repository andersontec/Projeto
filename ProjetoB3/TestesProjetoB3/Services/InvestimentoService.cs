using System;

namespace ProjetoB3.Services
{
    public class InvestimentoService
    {
        public double CalcularInvestimento(double valorInicial, int prazoMeses)
        {
            double taxaJuros = 0.05; // 5% de taxa de juros

            // Calculo de valor final considerando uma taxa de juros simples
            double valorFinal = valorInicial * Math.Pow(1 + taxaJuros, prazoMeses);

            return valorFinal;
        }
    }
}
