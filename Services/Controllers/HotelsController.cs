using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Services.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HotelsController : ApiController
    {
        readonly Interfaces.IHotelsService _service;
        public HotelsController(Interfaces.IHotelsService service) { _service = service; }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _service.GetHotels(), Configuration.Formatters.JsonFormatter);
        }

        // GET api/orders/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(int id)
        {
            return "order";
        }

        // POST api/orders
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPost]
        public void Post([FromBody]string order)
        {
        }

        // PUT api/orders/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPut]
        public void Put(int id, [FromBody]string order)
        {
        }

        // DELETE api/orders/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}