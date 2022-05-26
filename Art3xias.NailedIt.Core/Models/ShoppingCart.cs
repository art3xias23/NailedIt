using System.Collections.Generic;

namespace Art3xias.NailedIt.Core.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            CartItems = new List<ShoppingCartItem>();
        }

        public List<ShoppingCartItem> CartItems
        {
            get;
            set;
        }
    }
}
