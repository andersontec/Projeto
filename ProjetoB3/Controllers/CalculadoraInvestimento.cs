public static class CalculadoraInvestimento
{
    public static InvestimentoModel Calcular(double valorInicial, int prazoMeses)
    {
        double tb = 1.08;
        double cdi = 0.009;
        double valorFinal = valorInicial;
        double valorLiquido = 0;

        for (int i = 0; i < prazoMeses; i++)
        {
            valorFinal *= (1 + (cdi * tb));
        }

        double taxaImposto = 0;

        if (prazoMeses <= 6)
        {
            taxaImposto = 0.225;
        }
        else if (prazoMeses <= 12)
        {
            taxaImposto = 0.2;
        }
        else if (prazoMeses <= 24)
        {
            taxaImposto = 0.175;
        }
        else
        {
            taxaImposto = 0.15;
        }

        valorLiquido = valorFinal - (valorFinal - valorInicial) * taxaImposto;

        return new InvestimentoModel
        {
            ValorInicial = valorInicial,
            PrazoMeses = prazoMeses,
            ValorFinal = valorFinal,
            ValorLiquido = valorLiquido
        };
    }
}
