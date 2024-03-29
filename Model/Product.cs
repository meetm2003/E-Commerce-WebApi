namespace ecommerce.Model
{
    public class Product
    {
        public int P_Id { get; set; }
        public int P_Price { get; set; }
        public int P_Qty { get; set; }
        public string P_Name { get; set; }
        public byte[] P_Image { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

}
