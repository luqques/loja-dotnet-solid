using Ada.Loja.Enums;

namespace Ada.Loja.Tests
{
    public class Agua : Item
    {
        public Agua(string descricao, decimal valor) : base(ECategoriaItem.Agua, descricao, valor)
        {
        }
    }
}