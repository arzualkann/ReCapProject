﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Sellers
{
    public class UpdateSellerResponse
    {
        public string CompanyName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}