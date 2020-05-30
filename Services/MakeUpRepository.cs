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
    ///  Generates the makeuprepository
    /// </summary>
    public class MakeUpRepository
    {
       //Constructor
        public MakeUpRepository()
        {
            
        }

        // Gets all the MakeUp
        public List<MakeUp> GetAll()
        {
            List<MakeUp> makeUp = null;
            using (var context = new ProductContext())
            {
                makeUp = context.MakeUp.ToList();

            }

            return makeUp;
        }

        // Takes all the data selected
        public void takeData()
        {
            using (var context = new ProductContext())
            {
                MakeUp makeUp = new MakeUp();
                context.MakeUp.Add(makeUp);
                context.SaveChanges();

            }
        }
    }
}
