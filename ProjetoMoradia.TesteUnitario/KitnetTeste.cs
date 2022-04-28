using Xunit;
using ProjetoMoradia.Models;

namespace ProjetoMoradia.TesteUnitario;

public class KitnetTeste
{
    [Fact]
    public void KitnetNaoPodeTerMaisDeDoisBanheiros()
    {
        //Arrange
        var quantidaDeBanheirosInvalida = 3;
        var moradia = new Kitnet("teste", 1234567, 100, quantidaDeBanheirosInvalida, 1);

        //Act
        var quantidaDeBanheirosAtual = moradia.GetQuantidadeDeBanheiros();

        //Assert
        Assert.Equal(0, quantidaDeBanheirosAtual);
    }

    [Fact]
    public void KitnetNaoPodeTerMaisDeCinquentaMetros()
    {
        //Arrange
        var quantidadeDeMetrosInvalida = 51;
        var moradia = new Kitnet("teste", 1234567, quantidadeDeMetrosInvalida, 1, 1);

        //Act
        var quantidadeDeMetrosAtual = moradia.GetTamanhoEmMetros();

        //Assert
        Assert.Equal(0, quantidadeDeMetrosAtual);
    }
}