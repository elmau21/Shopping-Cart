namespace LegoNinjaGo.Models
{
    public class ProductContext: DbcContext
    {
        public ProductContext()
        : base ("LegoNinjaGo")
        {
        }

        public Dbset<category> Categories { get; set; }
        public Dbset<product> Products { get; set; }
        public Dbset<CarItem> ShoppingCart { get; set; }
    }
}