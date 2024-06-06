﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Banner
    {
        public int BannerID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String VideoDescription { get; set;}
        public String VideoUrl { get; set; }
    }
}
