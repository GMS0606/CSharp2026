namespace Master
{
    internal class Conta : IOperacao
    {
        //Campos
        private Pessoa cliente;
        private int numero;
        private double saldo;


        //Propriedades
        public int Numeroconta
        {
            get { return numero; }
            set { numero = value; }
        }
        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }


        public Pessoa DadosCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        //Construtor
        public Conta(int numeroconta, double saldoConta, Pessoa dadosCliente)
        {
            Numeroconta = numeroconta;
            SaldoConta = saldoConta;
            DadosCliente = dadosCliente;
        }

        //Métodos 
        public void Deposito(double qtd)
        {
            SaldoConta += qtd;
        }

        public void Saque(double qtd)
        {
            SaldoConta -= qtd;
        }

        public override string ToString()
        {
            return $"Dados da conta - {Tipo.ContaNormal} " +
                $"\n\tNome so titular: {cliente.nome}" +
                $"\n\tCPF do cliente: {cliente.cpf}" +
                $"\n\tNúmero da conta: {numero}" +
                $"\n\tSaldo da conta: {SaldoConta}";

        }
    }
}
