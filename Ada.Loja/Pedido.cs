

namespace Ada.Loja
{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
            Itens = new List<Item>();
        }

        public Guid Id { get; set; }
        public List<Item> Itens { get; set; }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public decimal CalcularValorSubTotal()
        {
            decimal total = 0;
            foreach (Item item in Itens)
                total += item.Valor;

            return total;
        }

        public decimal CalcularValorTaxas()
        {
            decimal total = 0;
            
            foreach (var item in Itens)
            {
                var itemComTaxa = item as ItemComTaxa;

                if (itemComTaxa != null)
                {
                    total += itemComTaxa.ObterValorTotalComTaxas();
                }
            }

            return total;
        }
    }
}
