using Context;
using Models;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public HttpResponseMessage Get(int page = 1, int pageLen = 5) => Request.CreateResponse(HttpStatusCode.OK, _service.GetHotels(page, pageLen), Configuration.Formatters.JsonFormatter);

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Get(int id)
        {
            using (HotelsContext c = new HotelsContext())
            {
                Hotel hotel = (from h in c.Hotel where h.Id == id select h).FirstOrDefault();
                if (hotel == null) return Request.CreateResponse(HttpStatusCode.NotFound);
                HotelModel model = new HotelModel(hotel.Id, hotel.Name, hotel.City, hotel.Address, hotel.Rating);
                return Request.CreateResponse(HttpStatusCode.OK, model, Configuration.Formatters.JsonFormatter);
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody]NewHotelModel m)
        {
            using (HotelsContext c = new HotelsContext())
            {
                c.Hotel.Add(new Hotel() { Name = m.Name, City = m.City, Address = m.Address, Rating = m.Rating });
                c.SaveChanges(); return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]NewHotelModel m)
        {
            using (HotelsContext c = new HotelsContext())
            {
                Hotel h = (from hotel in c.Hotel where hotel.Id == id select hotel).FirstOrDefault();
                if (h == null) return Request.CreateResponse(HttpStatusCode.NotFound);
                h.Name = m.Name; h.City = m.City; h.Address = m.Address; h.Rating = m.Rating;
                c.SaveChanges(); return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (HotelsContext c = new HotelsContext())
                {
                    Hotel hotel = (from h in c.Hotel where h.Id == id select h).FirstOrDefault();
                    if (hotel == null) return Request.CreateResponse(HttpStatusCode.NotFound);
                    c.Hotel.Remove(hotel); c.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException dbex) { return Request.CreateResponse(HttpStatusCode.Conflict, dbex.ToString()); }
            
        }
    }
}