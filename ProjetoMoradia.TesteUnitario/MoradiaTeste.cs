using Xunit;
using ProjetoMoradia.Models;

namespace ProjetoMoradia.TesteUnitario;

public class MoradiaTeste
{
    [Fact]
    public void TestarSeOCepTemOitoDigitos()
    {
        //Arrange
        int cepEsperado = 0;
        var moradia = new Moradia("teste", 1234567, 100, 1, 1);

        //Act
        var cepAtual = moradia.GetCep();

        //Assert
        Assert.Equal(cepEsperado, cepAtual);
    }
}