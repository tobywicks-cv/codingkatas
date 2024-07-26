using OrderKata;

namespace OrderKataTests
{
    public class OrderTests
    {
        [Fact]
        public void DiscountAmountTest()
        {
            const decimal CustomerDiscount = 0.2m;
            const decimal ListItemsTotal = 10;

            var order = new Order()
            {
                Customer = new Customer()
                {
                }
            };

            Assert.Equal(8m, order.TotalCost());
        }

        [Fact]
        public void WhenOrderFromJulieHasTripleDiscount()
        {
            var customer = new Customer()
            {
                //MainUser = new User
                //{
                //    Name = "Julie"
                //}
            };

            Assert.Equal(0.3m, customer.DiscountAmount());
        }

        [Fact]
        public void WhenOrderFromCVHasDoubleDiscount()
        {
            var customer = new Customer()
            {
                //MainUser = new User
                //{
                //    Name = "CommerceVision"
                //}
            };

            Assert.Equal(0.2m, customer.DiscountAmount());
        }
    }
}