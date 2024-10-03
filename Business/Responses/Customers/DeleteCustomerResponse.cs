﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Customers
{
    public class DeleteCustomerResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
