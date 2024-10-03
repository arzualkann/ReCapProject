using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Brands
{
    public class DeleteBrandResponse
    {
        public int Id { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
