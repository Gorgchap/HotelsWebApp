using Context;
using System;
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
        // IOrdersService _service;
        // public HotelsController(IOrdersService service) { _service = service; }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET api/orders
        public HttpResponseMessage Get()
        {
            try
            {
                using (HotelsContext c = new HotelsContext())
                {
                    var data = from h in c.Hotel.AsEnumerable()
                               select new HotelModel(h.Id, h.Name, h.City, h.Address, h.Rating, h.ConvHotel);
                    var r = new PagedResult<HotelModel>() { Page = data.ToArray(), PageCount = 1 };
                    var resp = Request.CreateResponse(HttpStatusCode.OK, r, Configuration.Formatters.JsonFormatter);
                    resp.Headers.Add("X-Access-Control-Allow-Origin", "https://localhost:44338");
                    return resp;
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Server error occured");
            }
        }

        // GET api/orders/5
        public string Get(int id)
        {
            return "order";
        }

        // POST api/orders
        public void Post([FromBody]string order)
        {
        }

        // PUT api/orders/5
        public void Put(int id, [FromBody]string order)
        {
        }

        // DELETE api/orders/5
        public HttpResponseMessage Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}