using Context; using Models; using System.Linq;

namespace WebApp
{
    public partial class Rooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            using HotelsContext c = new HotelsContext(); Rms.DataSource = (from r in c.Room.AsEnumerable()
                where r.HotelId == int.Parse(Request.Params["id"]) select new RoomModel(r.Id, r.Number, r.Price, r.RoomType)).ToList(); Rms.DataBind();
        }
    }
}