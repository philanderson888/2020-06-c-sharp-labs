using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_northwind_entity_framework.Controllers
{
    public class ValuesController : ApiController
    {
        List<string> values = new List<string>() { "value1", "value2" };
        
        // GET api/values/5
        public string Get(int id)
        {
            return values[id];
        }



        // GET api/values
        public IEnumerable<string> Get()
        {
            return values;
        }
        
        // POST api/values
        public string Post([FromBody] string value)
        {
            values.Add(value);
            return "added value " + value;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            values.Remove("value1");
        }
    }
}
