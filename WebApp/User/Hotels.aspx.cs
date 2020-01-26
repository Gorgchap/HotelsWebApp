using Context; using System.Linq;

namespace WebApp
{
    public partial class Hotels : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            using HotelsContext c = new HotelsContext(); Htls.DataSource = (from h in c.Hotel.AsEnumerable()
                select new Models.HotelModel(h.Id, h.Name, h.City, h.Address, h.Rating)).ToList(); Htls.DataBind();
        }
    }
}