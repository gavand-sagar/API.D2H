using API.D2H.Models;
using BL.D2H;
using BL.D2H.Interfaces;
using Models.D2H;
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
        private IPackageBL businessLogic;
        public PackagesController(IPackageBL packageBL)
        {
            this.businessLogic = packageBL;
        }

        // GET: api/Packages
        public List<Package> Get()
        {

            return businessLogic.GetAll();
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
