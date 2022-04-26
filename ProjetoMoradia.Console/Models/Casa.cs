namespace ProjetoMoradia.Models
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }

        public Casa(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos,
                    bool comQuintal) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {
            ComQuintal = comQuintal;
        }

        public void SetComQuintal(bool comQuintal)
        {
            ComQuintal = comQuintal;
        }

        public bool GetComQuintal()
        {
            return ComQuintal;
        }

        public override double CalcularValor()
        {
            var valor = 0.0;
            valor = (TamanhoEmMetros * 35) + (QuantidadeDeQuartos * 10) + (QuantidadeDeBanheiros * 5);
            if (ComQuintal)
                valor = valor * 1.1;
            return valor;
        }
    }
}