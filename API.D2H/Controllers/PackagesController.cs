using API.D2H.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.D2H.Controllers
{
    public class PackagesController : ApiController
    {

        List<Package> _packages = new List<Package>() {
        new Package(){Id = 1, Name ="Silver"},
        new Package(){Id = 2, Name ="Gold"},
        new Package(){Id = 3, Name ="Diamond"},
        new Package(){Id = 4, Name ="Bronze"},
        new Package(){Id = 5, Name ="Steel"},
        new Package(){Id = 6, Name ="Copper"},
        new Package(){Id = 7, Name ="Platinum"},
        };


        private IRepository _repository;

        public PackagesController(IRepository repository)
        {
            this._repository = repository;
        }


        // GET: api/Packages
        public IEnumerable<Package> Get()
        {

            var result = _repository.MyValues;
            return _packages;
        }

        // GET: api/Packages/5
        public IEnumerable<Package> Get(string name)
        {
            return _packages.Where(x => x.Name.ToLower().Contains(name.ToLower()));
        }

        // POST: api/Packages
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Packages/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Packages/5
        public void Delete(int id)
        {
        }
    }
}
