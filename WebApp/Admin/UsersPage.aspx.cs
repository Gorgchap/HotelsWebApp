using System.Linq;

namespace WebApp
{
    public partial class UsersPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            using HotelsContext context = new HotelsContext(); System.Collections.Generic.List<UserModel> list = new System.Collections.Generic.List<UserModel>();
            list.AddRange(from u in context.User.AsEnumerable() where u.RoleId > 1 select new UserModel(u.Id, u.Login, u.Name, u.Surname, u.Email, u.Phone));
            Users.DataSource = list; Users.DataBind();
        }
    }
}