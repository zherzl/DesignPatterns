﻿using Layered.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Model
{
    public interface IProductRepository
    {
        IList<Product> FindAll();
    }
}
