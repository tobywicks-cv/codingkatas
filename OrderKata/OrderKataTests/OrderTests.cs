using OrderKata;

namespace OrderKataTests
{
    public class OrderTests
    {
        [Fact]
        public void Test1()
        {
            var order = new Order()
            {
                Customer = new Customer()
            };

            Assert.Equal(0, order.TotalCost());
        }
    }
}