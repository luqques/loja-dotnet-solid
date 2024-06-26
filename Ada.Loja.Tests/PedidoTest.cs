global using Xunit;

namespace Ada.Loja.Tests
{
    public class PedidoTest
    {
        [Fact]
        public void Pedido_Deve_Retornar_ValorSubtotal_Corretamente()
        {
            var itens = new List<Item>();
            var pedido = new Pedido(itens);

            pedido.AdicionarItem(new Cerveja("Heineken", 15));
            pedido.AdicionarItem(new Refrigerante("Pepsi", 20));
            pedido.AdicionarItem(new Agua("Cristal", 10));

            var total = pedido.CalculaValorSubTotal();

            Assert.Equal(45, total);
        }
    }
}