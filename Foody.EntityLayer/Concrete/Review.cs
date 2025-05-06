using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
    public class Review
    {
        public int ReciewId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerTitle { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;


    }
}
