using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarResults
{
    public class GetCarWithBrandQueryResult
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public String BrandName { get; set; }
        public String Model { get; set; }
        public String CoverImageUrl { get; set; }
        public int Km { get; set; }
        public String Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public String Fuel { get; set; }
        public String BigImageUrl { get; set; }
    }
}
