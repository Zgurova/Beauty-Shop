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
    /// Generates perfumerepository
    /// </summary>
    public class PerfumeRepository
    {
       //Constructor
        public PerfumeRepository()
        {
           
        }

        // Gets all the perfumes
        public List<Perfume> GetAll()
        {
            List<Perfume> perfumes = null;
            using (var context = new ProductContext())
            {
                perfumes = context.Perfumes.ToList();

            }

            return perfumes;
        }

        // Takes all the data selected
        public void takeData()
        {
            using (var context = new ProductContext())
            {
                Perfume perfume = new Perfume();
                context.Perfumes.Add(perfume);
                context.SaveChanges();

            }
        }
    }
}
