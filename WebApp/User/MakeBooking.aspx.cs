using Context; using System.Linq;

namespace WebApp
{
    public partial class MakeBooking : System.Web.UI.Page
    {
        readonly System.Collections.Generic.List<User> users = new System.Collections.Generic.List<User>();
        public int RoomId => int.Parse(Request.Params["id"]);
        protected override void OnInit(System.EventArgs e)
        {
            Data.MinDate = System.DateTime.Now.Date.AddDays(1);
            Data.BeginDate = System.DateTime.Now.Date.AddDays(1);
            Data.EndDate = System.DateTime.Now.Date.AddDays(8);
        }

        protected void Page_Load(object sender, System.EventArgs e)
        {
            Save.Click += Save_Click; using HotelsContext context = new HotelsContext();
            users.AddRange(context.User.AsEnumerable());
        }

        private void Save_Click(object sender, System.EventArgs e)
        {
            using HotelsContext c = new HotelsContext();
            foreach (User user in users)
                if (Utils.MakeToken(user.Login, user.PasswordHash) == Request.Cookies["token"].Value)
                {
                    c.Booking.Add(new Booking() { RoomId = RoomId, DateBegin = Data.BeginDate, DateEnd = Data.EndDate,
                        User = user }); c.SaveChanges(); Response.Redirect("Bookings.aspx"); return;
                }
        }
    }
}