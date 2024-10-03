using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Brands
{
    public class CreateBrandResponse
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
