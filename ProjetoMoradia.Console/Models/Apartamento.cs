namespace ProjetoMoradia.Models
{
    public class Apartamento : Moradia
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }

        public Apartamento(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos,
                           int andar, double valorCondominio) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros,
                           quantidadeDeQuartos)
        {
            SetAndar(andar);
            ValorCondominio = valorCondominio;
        }

        public void SetAndar(int andar)
        {
            if (andar <= 10)
            {
                Andar = andar;
            }
        }

        public int GetAndar()
        {
            return Andar;
        }

        public void SetValorCondominio(double valorCondominio)
        {
            ValorCondominio = valorCondominio;
        }

        public override void SetTamanhoEmMetros(double tamanhoEmMetros)
        {
            if (tamanhoEmMetros <= 60)
            {
                TamanhoEmMetros = tamanhoEmMetros;
            }
        }

        public override void SetQuantidadeDeBanheiros(int quantidadeDeBanheiros)
        {
            if (quantidadeDeBanheiros <= 3)
            {
                QuantidadeDeBanheiros = quantidadeDeBanheiros;
            }
        }

        public double GetValorCondominio()
        {
            return ValorCondominio;
        }

        public override double CalcularValor()
        {
            var valor = 0.0;
            valor = (TamanhoEmMetros * 40) + (QuantidadeDeQuartos * 10) + (QuantidadeDeBanheiros * 5) + ValorCondominio;
            return valor;
        }
    }
}