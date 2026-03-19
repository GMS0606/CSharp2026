namespace Exemplo1
{
    internal class Produto
    {
        //Capos da classe 
        public string nome;
        public double preco;
        public int quantidade;

        //Construtor 

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        //Métodos 
        public double Valores()
        {
            return preco * quantidade;
        }

        public void adipro(int qtd)
        {
            quantidade += qtd;
        }

        public void remopro(int qtd)
        {
            quantidade -= qtd;
        }


        public string dadospro()
        {
            return ($"Nome : {nome}, preço: {preco} e quantidade: {quantidade}" +
                $"\nTotal de valor em estoque: {Valores()}");
        }
    }
}
