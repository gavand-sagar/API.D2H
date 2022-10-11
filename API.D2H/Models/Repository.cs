﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.D2H.Models
{
    public class Repository : IRepository
    {
        public IEnumerable<string> MyValues { get; set; }

        public Repository()
        {
            MyValues = new List<string> { "Value1", "Value2", "Value3", "Value4" };
        }
    }
}