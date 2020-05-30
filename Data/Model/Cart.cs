using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
   
    /// <summary>
    /// Table from database
    /// </summary>
    public class Cart
    {
        // Columns from database
        private string id;
        private string name;
        private decimal price;

        public Cart()
        {
                
        }
        public string Id { get; set; }

        public string Name { get; set; }
        
        public decimal Price { get; set; }
       
        // Constructor
        public Cart(string id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

       

    }
}
