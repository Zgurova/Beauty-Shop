using Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{

    /// <summary>
    /// Generates creamrepository
    /// </summary>
    public class CreamRepository
    {
     
       // Constructor
        public CreamRepository()
        {
          
        }

        // Gets all the creams  
        public List<Cream> GetAll()
        {
            List<Cream> creams = null;
            using (var context = new ProductContext())
            {               
               creams = context.Creams.ToList();
            }           
            return creams;
        }

        // Gets all the data selected
        public void takeData()
        {
            using (var context = new ProductContext())
            {
                Cream cream = new Cream();
                context.Creams.Add(cream);
                context.SaveChanges();

            }
        }

    }
}
