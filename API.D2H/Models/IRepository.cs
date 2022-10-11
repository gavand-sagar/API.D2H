using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.D2H.Models
{
    public interface IRepository
    {
        IEnumerable<string> MyValues { get; set; }
        List<Package> _packages { get; set; }
    }
}
