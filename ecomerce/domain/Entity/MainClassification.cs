using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Domain.Entity
{
    public class MainClassification
    {

        public int Id { get; set; }
        public string MainClassificationName { get; set; }
       
        public string? ImageUrl { get; set; }
        public virtual ICollection<BasicClassification> BasicClassifications { get; set; }
        public virtual ICollection<Product> Products { get; set; }



    }
}
