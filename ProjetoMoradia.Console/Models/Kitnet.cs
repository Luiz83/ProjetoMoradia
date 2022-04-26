namespace ProjetoMoradia.Models
{
    public class Kitnet : Moradia
    {
        public Kitnet(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos)
                     : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {

        }
        public override double CalcularValor()
        {
            var valor = 0.0;
            valor = TamanhoEmMetros * 30;
            return valor;
        }
    }
}