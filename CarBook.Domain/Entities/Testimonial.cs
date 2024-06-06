using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public String Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public String ImageUrl { get; set; }

    }
}
