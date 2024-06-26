namespace Ada.Loja
{
    public class Cerveja : Item
    {
        public Cerveja(string descricao, decimal valor) : base(descricao, valor)
        {
        }

        public decimal ObterTaxa(DateTime data)
        {
            return 0.1M;
        }
    }
}