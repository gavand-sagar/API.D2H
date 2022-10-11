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

        


        private IRepository _repository;

        public PackagesController(IRepository repository)
        {
            this._repository = repository;
        }


        // GET: api/Packages
        public IEnumerable<Package> Get()
        {

            var result = _repository.MyValues;
            return _repository._packages;
        }

        // GET: api/Packages/5
        public IEnumerable<Package> Get(string name)
        {
            return _repository._packages.Where(x => x.Name.ToLower().Contains(name.ToLower()));
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
