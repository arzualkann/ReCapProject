﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Colors
{
    public class UpdateColorRequest
    {
        public int Id { get; set; }
        public string ColorName { get; set; }

    }
}