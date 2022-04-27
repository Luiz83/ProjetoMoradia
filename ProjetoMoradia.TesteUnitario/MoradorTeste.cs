using Xunit;
using ProjetoMoradia.Models;

namespace ProjetoMoradia.TesteUnitario;

public class MoradorTeste
{
    [Fact]
    public void TestarSeONomeEstaSendoSalvoCorretamente()
    {
        //Arrange
        var nomeEsperado = "Luiz";
        var morador = new Morador(nomeEsperado,"11111111111", "30/04/1998");

        //Act
        var nome = morador.GetNome();

        //Assert
        Assert.Equal(nomeEsperado,nome);

    }

    [Fact]
    public void TestarSeOCpfEstaSendoSalvoCorretamente()
    {
        //Arrange
        var cpfEsperado = "58796554128";
        var morador = new Morador("Giovanni",cpfEsperado, "30/04/1998");

        //Act
        var cpf = morador.GetCpf();

        //Assert
        Assert.Equal(cpfEsperado,cpf);

    }

    [Fact]
    public void TestarSeAValidacaoDoSetCpfEstaFuncionando()
    {
        //Arrange
        var cpfTeste = "587965541287";
        var morador = new Morador("Giovanni",cpfTeste, "30/04/1998");

        //Act
        var cpf = morador.GetCpf();

        //Assert
        Assert.Equal(null,cpf);

    }

    [Fact]
    public void TestarSeADataDeNacimentoEstaSendoSalvaCorretamente()
    {
        //Arrange
        var dataNascimentoEsperada = "11/07/1992";
        var morador = new Morador("Giovanni","11111111111", dataNascimentoEsperada);

        //Act
        var dataNascimento = morador.GetDataDeNascimento();

        //Assert
        Assert.Equal(dataNascimentoEsperada,dataNascimento.ToString("dd/MM/yyyy"));

    }
}
/*
Realizar teste de get e set das propriedaes Morador
Adicionar validação no setCPF para verificar se tem 11 digitos
Adicionar teste para verficiar se quando passam um cpf invalido ele realmente não salva
*/