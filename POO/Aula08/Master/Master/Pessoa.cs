namespace Master
{
    internal struct Pessoa
    {
        public string nome;
        public long cpf;

        //Contrtor

        public Pessoa(string nome, long cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
