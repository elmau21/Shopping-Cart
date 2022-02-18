using system;
using system.Collections.Generic;
using system.Linq;
using system.Web.UI;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Objects
{
    public class CarItem
    {
        [key]
        public string ItemID { get; set; }
        public string CarID { get; set; }
        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }
        public int ProducId { get; set; }
        public virtual Product Product { get; set; }
    }
}