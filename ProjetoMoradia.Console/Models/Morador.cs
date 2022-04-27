namespace ProjetoMoradia.Models
{
    public class Morador
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataNascimento { get; set; }

        public Morador(string nome, string cpf, string dataNascimento)
        {
            SetNome(nome);
            SetCpf(cpf);
            SetDataNascimento(dataNascimento);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetCpf(string cpf)
        {
            if (cpf.Count() == 11)
                Cpf = cpf;
            else return;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public void SetDataNascimento(string dataNascimento)
        {
            DataNascimento = DateTime.Parse(dataNascimento);
        }

        public DateTime GetDataDeNascimento()
        {
            return DataNascimento;
        }
    }
}