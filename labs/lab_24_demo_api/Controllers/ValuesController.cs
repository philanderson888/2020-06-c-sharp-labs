using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lab_24_demo_api.Controllers
{
    public class ValuesController : ApiController
    {

        static List<string> customers = new List<string>()
        {
            "Bob","Fred","Tilly"
        };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "value 3", "phils value" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            var customer = customers[id];

            return $"you have chosen customer {customer}";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            // put to database
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
