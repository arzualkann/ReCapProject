﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.CarImages
{
    public class GetByIdCarImageResponse
    {
        public int CarId { get; set; }
        public string ImagePath { get; set; }
    }
}
