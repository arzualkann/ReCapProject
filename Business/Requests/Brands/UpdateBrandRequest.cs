﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Brands
{
    public class UpdateBrandRequest
    {
        public int Id { get; set; }

        public string BrandName { get; set; }

    }
}
