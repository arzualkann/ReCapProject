using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Colors
{
    public class CreateColorResponse
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
