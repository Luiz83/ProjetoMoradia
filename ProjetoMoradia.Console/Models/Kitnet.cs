namespace ProjetoMoradia.Models
{
    public class Kitnet : Moradia
    {
        public Kitnet(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos)
                     : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {

        }

        public override void SetTamanhoEmMetros(double tamanhoEmMetros)
        {
            if (tamanhoEmMetros <= 50)
            {
                TamanhoEmMetros = tamanhoEmMetros;
            }
        }

        public override void SetQuantidadeDeBanheiros(int quantidadeDeBanheiros)
        {
            if (quantidadeDeBanheiros <= 2)
            {
                QuantidadeDeBanheiros = quantidadeDeBanheiros;
            }
        }
        public override double CalcularValor()
        {
            var valor = 0.0;
            valor = TamanhoEmMetros * 30;
            return valor;
        }
    }
}