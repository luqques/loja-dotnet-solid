namespace Ada.Loja.Tests
{
    public class PedidoTest
    {
        [Fact]
        public void Pedido_Deve_Retornar_ValorSubtotal_Corretamente()
        {
            var pedido = new Pedido();
            pedido.AdicionarItem(new Cerveja("Heineken", 15));
            pedido.AdicionarItem(new Refrigerante("Pepsi", 20));
            pedido.AdicionarItem(new Agua("Cristal", 10));

            var total = pedido.CalcularValorSubTotal();

            Assert.Equal(45, total);
        }

        [Fact]
        public void Pedido_Deve_Retornar_ValorTaxas_Corretamente()
        {
            var pedido = new Pedido();
            pedido.AdicionarItem(new Cerveja("Heineken", 15));
            pedido.AdicionarItem(new Refrigerante("Pepsi", 20));
            pedido.AdicionarItem(new Agua("Cristal", 10));

            var totalComTaxas = pedido.CalcularValorTaxas();

            Assert.Equal(5.5M, totalComTaxas);
        }
    }
}