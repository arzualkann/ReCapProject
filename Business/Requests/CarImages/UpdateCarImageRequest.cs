﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.CarImages
{
    public class UpdateCarImageRequest
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }

    }
}