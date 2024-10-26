﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Sellers
{
    public class UpdateSellerRequest
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
