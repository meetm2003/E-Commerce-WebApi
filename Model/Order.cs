namespace ecommerce.Model
{
    public class Order
    {
        public int O_Id { get; set; }
        public int P_Id { get; set; }
        public int U_Id { get; set; }
        public int O_Qty { get; set; }
        public int O_Price { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }

}
