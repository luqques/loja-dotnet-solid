

namespace Ada.Loja
{
    public class Pedido
    {
        public decimal ValorTotal { get; set; }
        public List<Item> Itens { get; set; }

        public Pedido(List<Item> itens)
        {
            Itens = itens;
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public decimal CalculaValorSubTotal()
        {
            foreach (Item item in Itens)
                ValorTotal += item.Valor;

            return ValorTotal;
        }
    }
}
