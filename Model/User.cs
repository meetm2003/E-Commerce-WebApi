namespace ecommerce.Model
{
    public class User
    {
        public int U_Id { get; set; }
        public string U_Name { get; set; }
        public string U_Address { get; set; }
        public string U_Email { get; set; }
        public int U_Mob_Num { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

}
