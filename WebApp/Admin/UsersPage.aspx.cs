using Context; using System.Linq;

namespace WebApp
{
    public partial class UsersPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            using HotelsContext c = new HotelsContext(); Users.DataSource = (from u in c.User.AsEnumerable() where u.RoleId > 1
                select new UserModel(u.Id, u.Login, u.Name, u.Surname, u.Email, u.Phone)).ToList(); Users.DataBind();
        }
    }
}