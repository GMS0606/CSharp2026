using Microsoft.Data.SqlClient;

namespace MasterBanco.Classes.Entidades
{
    internal class Banco
    {
        // Campo
        private const decimal TaxaSaque = 5.00m;

        public int Id { get; set; }
        public string Titular { get; set; }
        public int Numero_da_conta { get; set; }
        public decimal Saldo { get; set; }

        // Construtores
        public Banco() { }

        public Banco(string titular, int numero_da_conta, decimal saldo)
        {
            Titular = titular;
            Numero_da_conta = numero_da_conta;
            Saldo = saldo;
        }

        public Banco(string titular, int numero_da_conta)
        {
            Titular = titular;
            Numero_da_conta = numero_da_conta;
        }

        // String de conexão
        private static string conectarCaminho =
            @"Server=ECFP507D1319373\SQLEXPRESS;Database=Clodoaldo;Trusted_Connection=True;TrustServerCertificate=True;";

        // =========================
        // C - CREATE
        // =========================
        public static void CadastrarContas(Banco banco)
        {
            string consulta = "INSERT INTO Contas (Titular, Numero_da_conta, Saldo) VALUES (@Titular, @Numero_da_conta, @Saldo)";

            using (SqlConnection conexao = new SqlConnection(conectarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                comando.Parameters.AddWithValue("@Titular", banco.Titular);
                comando.Parameters.AddWithValue("@Numero_da_conta", banco.Numero_da_conta);
                comando.Parameters.AddWithValue("@Saldo", banco.Saldo);

                conexao.Open();
                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    Console.WriteLine("Conta cadastrada com sucesso!");
                }
            }
        }

        // =========================
        // R - READ
        // =========================
        public static void LerConta()
        {
            string consulta = "SELECT Id, Titular, Numero_da_conta, Saldo FROM Contas";

            using (SqlConnection conexao = new SqlConnection(conectarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                conexao.Open();

                using (SqlDataReader leitura = comando.ExecuteReader())
                {
                    if (leitura.HasRows)
                    {
                        while (leitura.Read())
                        {
                            Console.WriteLine(
                                $"ID: {leitura["Id"]} | Conta: {leitura["Numero_da_conta"]} | Titular: {leitura["Titular"]} | Saldo: {leitura["Saldo"]}"
                            );
                        }
                    }
                }
            }
        }
    }
}