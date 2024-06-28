using Ada.Loja.Enums;

namespace Ada.Loja
{
    public class Cerveja : ItemComTaxa
    {
        public Cerveja(string descricao, decimal valor) : base(ECategoriaItem.Cerveja, descricao, valor)
        {
        }

        public override decimal ObterTaxa()
        {
            return 0.1M;
        }
    }
}