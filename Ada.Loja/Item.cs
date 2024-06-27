using Ada.Loja.Enums;

namespace Ada.Loja
{
    public abstract class Item
    {
        public Item(ECategoriaItem categoria, string descricao, decimal valor)
        {
            Categoria = categoria;
            Valor = valor;
            Descricao = descricao;
        }

        public ECategoriaItem Categoria { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        public abstract decimal ObterTaxa();

        public decimal ObterValorTotalComTaxas()
        {
            return Valor * ObterTaxa();
        }
    }
}