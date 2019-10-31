using System.Linq;

namespace WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        readonly System.Collections.Generic.List<LoginUser> users = new System.Collections.Generic.List<LoginUser>();
        private void NewPage(string role) { Response.Redirect(role.Equals("Admin") ? "~/Admin/UsersPage.aspx" : "~/User/Hotels.aspx"); }     
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (Request.Params["logout"] != null) { Response.Cookies["token"].Value = null; Response.Redirect("Login.aspx"); return; }
            if (!string.IsNullOrEmpty(Output.Text)) Output.Text = ""; Register.Click += Register_Click; Submit.Click += Submit_Click;
            using HotelsContext c = new HotelsContext(); users.AddRange(from u in c.User.AsEnumerable()
                from r in c.Role.AsEnumerable() where r.Id == u.RoleId select new LoginUser(r.Name, u.Login, u.PasswordHash));
            if (Request.Cookies["token"] != null)
                foreach (LoginUser u in users)
                    if (Utils.MakeToken(u.Login, u.PasswordHash) == Request.Cookies["token"].Value)
                    { NewPage(u.Role); return; }
        }
        private void Register_Click(object sender, System.EventArgs e) { Response.Redirect("Register.aspx"); }
        private void Submit_Click(object sender, System.EventArgs e)
        {
            foreach (LoginUser user in users)
                if (LogIn.Text == user.Login && Utils.ConvertToSHA512(Password.Text) == user.PasswordHash)
                {
                    Response.Cookies["token"].Value = Utils.MakeToken(user.Login, user.PasswordHash);
                    NewPage(user.Role); return;
                }
            Output.Text = "Login credentials have been rejected"; Output.ForeColor = System.Drawing.Color.Red;
        }
    }
}