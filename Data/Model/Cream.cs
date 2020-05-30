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
    public class Cream
    {
        // Table from database
        public string id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string type { get; set; }
    }
}
