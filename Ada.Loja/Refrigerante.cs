
namespace Ada.Loja.Tests
{
    public class Refrigerante : Item
    {
        public Refrigerante(string descricao, decimal valor) : base(descricao, valor)
        {
        }

        public decimal ObterTaxa(DateTime data)
        {
            return 0.2M;
        }
    }
}