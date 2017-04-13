using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KurtsMovieRental.Controllers
{
    public class RentalLogController : ApiController
    {
        // GET: api/RentalRecords
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RentalRecords/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RentalRecords
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RentalRecords/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RentalRecords/5
        public void Delete(int id)
        {
        }
    }
}
