using System;

namespace OrderKata
{
    public class Recordset
    {
        public void Load() => throw new NotImplementedException("Do not run database operations from unit tests!");
    }

    public class System : Recordset
    {
        public string DefaultName { get; }

        public System() => Load();
    }

    public class User : Recordset
    {
        public User() => Load();

        public string Name { get; set; } = new System().DefaultName;

        public string Address { get; set; }
    }

    public class Customer : Recordset
    {
        private User _mainUser = null;

        public Customer() => Load();

        public User MainUser => _mainUser ?? (_mainUser = new User());

        public decimal DiscountAmount()
        {
            if (MainUser == null) return BaseDiscount();
            if (MainUser.Name == "CommerceVision") return BaseDiscount() * 2;

            return MainUser.Name == "Julie" ? BaseDiscount() * 3 : BaseDiscount();
        }

        public decimal BaseDiscount() => .1m;
    }

    public class Order
    {
        public Customer Customer { get; set; } = new Customer();

        public decimal LineItemsCost => 100;

        public decimal TotalCost()
        {
            return LineItemsCost * (1 - Customer.DiscountAmount());
        }
    }
}
