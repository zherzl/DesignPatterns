﻿using Layered.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Service.Messaging
{
    public class ProductListResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public IList<ProductViewModel> Products { get; set; }
    }
}
