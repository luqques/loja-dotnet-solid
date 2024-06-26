namespace Ada.Loja
{
    public class Item
    {
        public Item(string descricao, decimal valor)
        {
            Valor = valor;
            Descricao = descricao;
        }

        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}