using Ada.Loja.Enums;

namespace Ada.Loja.Tests
{
    public class Refrigerante : ItemComTaxa
    {
        public Refrigerante(string descricao, decimal valor) : base(ECategoriaItem.Refrigerante, descricao, valor)
        {
        }

        public override decimal ObterTaxa()
        {
            return 0.2M;
        }
    }
}