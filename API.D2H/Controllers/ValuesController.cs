using BL.D2H;
using BL.D2H.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.D2H.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        private ICustomerBL businessLogic;
        public ValuesController(ICustomerBL customerBL)
        {
            this.businessLogic = customerBL;
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id, string name)
        {
            
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
