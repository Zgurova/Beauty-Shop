using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    /// <summary>
    /// Generates cartrepository
    /// </summary>
    public class CartRepository
    {
        // Constructor
        public CartRepository()
        {

        }

        // Removes object from the cart
        public void Remove(string id)
        {
            using (var context=new ProductContext())
            {
                var customer = context.Cart.Find(id);
                context.Cart.Remove(customer);
                context.SaveChanges();
            }
        }

        // Adds object to the cart
        public List<Cart> Add(object cosmetic)
        {
            List<Cart> cart = null;            
            using (var context = new ProductContext())
            {                
                cart = context.Cart.ToList();
            }
            return cart;
        }

        // Gets all the objects from the cart
        public List<Cart> GetAll()
        {
            List<Cart> cart = null;
            using (var context = new ProductContext())
            {
                cart = context.Cart.ToList();
            }
            return cart;
        }

        // Takes all the data from the cart
        public void takeData()
        {
            using (var context = new ProductContext())
            {
                Cart cart = new Cart();
                context.Cart.Add(cart);
                context.SaveChanges();

            }
        }

    }
}
