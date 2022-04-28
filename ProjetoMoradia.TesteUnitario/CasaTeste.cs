using Xunit;
using ProjetoMoradia.Models;

namespace ProjetoMoradia.TesteUnitario;

public class CasaTeste
{
    [Fact]
    public void CasaNaoPodeTerMaisDeCincoBanheiros()
    {
        //Arrange
        var quantidaDeBanheirosInvalida = 6;
        var moradia = new Casa("teste", 1234567, 100, quantidaDeBanheirosInvalida, 1, false);

        //Act
        var quantidaDeBanheirosAtual = moradia.GetQuantidadeDeBanheiros();

        //Assert
        Assert.Equal(0, quantidaDeBanheirosAtual);
    }

    [Fact]
    public void CasaNaoPodeTerMaisDeCemMetros()
    {
        //Arrange
        var quantidadeDeMetrosInvalida = 101;
        var moradia = new Casa("teste", 1234567, quantidadeDeMetrosInvalida, 1, 1, true);

        //Act
        var quantidadeDeMetrosAtual = moradia.GetTamanhoEmMetros();

        //Assert
        Assert.Equal(0, quantidadeDeMetrosAtual);
    }
}