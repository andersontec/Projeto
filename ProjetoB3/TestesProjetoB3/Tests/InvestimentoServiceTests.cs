using Xunit;
using ProjetoB3.Services;  // Certifique-se de que este namespace corresponda ao do serviço

namespace ProjetoB3.Tests
{
    public class InvestimentoServiceTests
    {
        private readonly InvestimentoService _investimentoService;

        public InvestimentoServiceTests()
        {
            _investimentoService = new InvestimentoService();
        }

        [Fact]
        public void CalcularInvestimento_RetornaValorCorreto_QuandoDadosValidos()
        {
            // Arrange
            double valorInicial = 1000;
            int prazoMeses = 12;
            double resultadoEsperado = 1795.86;  // Este é um valor de exemplo, ajuste conforme necessário

            // Act
            double resultado = _investimentoService.CalcularInvestimento(valorInicial, prazoMeses);

            // Assert
            Assert.Equal(resultadoEsperado, resultado, 2); // O último parâmetro é a precisão
        }
    }
}
