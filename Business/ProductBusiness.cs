using Data;
using products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    /// <summary>
    /// The main ProductBusiiness class
    /// Contains all methods for performing basic math functions
    /// </summary>
    
    public class ProductBusiness
    {
        private ProductContext productContext;

       // It gets all of the selected
        public List<Cart> GetAll()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Cart.ToList();
            }
        }

        // Returns the total price in string
        public string TotalPrice()
        {
            CartRepository cartRepository = new CartRepository();
            List<Cart> cart = cartRepository.GetAll();
            decimal totalPrice = 0;

            foreach (var item in cart)
            {
                totalPrice += item.Price;
            }
            string totalPrice1 = totalPrice.ToString();
            return totalPrice1;
        }

        // Gets object from database
        public Cart Get(int id)
        {
            using (productContext = new ProductContext())
            {
                return productContext.Cart.Find(id);
            }
        }

        // Adds product to the cart
        public void Add(Cart product)
        {
            using (productContext = new ProductContext())
            {
                productContext.Cart.Add(product);
                productContext.SaveChanges();

            }
        }

        // Updates the cart
        public void Update(Cart product)
        {
            using (productContext = new ProductContext())
            {

                var item = productContext.Cart.Find(product.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(product);
                    productContext.SaveChanges();
                }

            }
        }

        // Deletes an object from cart
        public void Delete(int id)
        {
            using (productContext = new ProductContext())
            {
                var product = productContext.Cart.Find(id);
                if (product != null)
                {
                    productContext.Cart.Remove(product);
                    productContext.SaveChanges();
                }
            }
        }
    }
}
