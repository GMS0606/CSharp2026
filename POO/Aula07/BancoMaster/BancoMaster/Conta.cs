
namespace BancoMaster
{
    internal class Conta
    {
        //Campos
        private int numero;
        private string titular;
        private double saldo;


        //Propriedades
        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }


        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }


        public int NumeroConta
        {
            get { return numero; ; }
            set { numero = value; }
        }

        //Contrutor
        public Conta(double saldoConta, string titularConta, int numeroConta)
        {
            SaldoConta = saldoConta;
            TitularConta = titularConta;
            NumeroConta = numeroConta;
        }

        public Conta(string titularConta, int numeroConta) : this(numeroConta, titularConta, 0)
        {
            SaldoConta = 0;
        }

        //Métodos
        public virtual void Saque(double quantia)
        {
            SaldoConta -= quantia + 5;
        }
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
    }
}
