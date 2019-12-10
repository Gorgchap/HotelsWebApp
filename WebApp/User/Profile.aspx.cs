using Context;
using System.Linq;
namespace WebApp
{
    public partial class Profile : System.Web.UI.Page
    {
        readonly System.Collections.Generic.List<User> users = new System.Collections.Generic.List<User>();
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Output.Text)) Output.Text = ""; Change.Click += Change_Click;
            using HotelsContext c = new HotelsContext(); users.AddRange(from u in c.User select u);
            Data.UserId = (from u in c.User.AsEnumerable() where Utils.MakeToken(u.Login, u.PasswordHash) == Request.Cookies["token"].Value select u.Id).First();
        }
        private void Change_Click(object sender, System.EventArgs e)
        {
            string errors = Utils.CheckUserData(Data.UserId, Data.Login, Data.Name, Data.Surname, Data.Email, Data.Phone, users);
            if (errors.Length == 0)
                using (HotelsContext c = new HotelsContext())
                {
                    User u = (from user in c.User where user.Id == Data.UserId select user).First(); u.Login = Data.Login;
                    u.Name = Data.Name; u.Surname = Data.Surname; u.Email = Data.Email; u.Phone = Data.Phone;
                    c.SaveChanges(); Response.Cookies["token"].Value = Utils.MakeToken(u.Login, u.PasswordHash);
                    Response.Redirect("Hotels.aspx"); return;
                }
            Output.Text = "New profile credentials (" + errors.Remove(errors.Length - 2) + ") have been rejected"; Output.ForeColor = System.Drawing.Color.Red;
        }
    }
}