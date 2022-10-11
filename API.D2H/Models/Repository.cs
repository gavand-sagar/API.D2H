using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.D2H.Models
{
    public class Repository : IRepository
    {
        public IEnumerable<string> MyValues { get; set; }
        public List<Package> _packages { get; set; }

        public Repository()
        {
            MyValues = new List<string> { "Value1", "Value2", "Value3", "Value4" };
            _packages = new List<Package>() {
                    new Package(){Id = 1, Name ="Silver"},
                    new Package(){Id = 2, Name ="Gold"},
                    new Package(){Id = 3, Name ="Diamond"},
                    new Package(){Id = 4, Name ="Bronze"},
                    new Package(){Id = 5, Name ="Steel"},
                    new Package(){Id = 6, Name ="Copper"},
                    new Package(){Id = 7, Name ="Platinum"},
        };
        }
    }
}