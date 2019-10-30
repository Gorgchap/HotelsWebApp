using System.Linq;

namespace WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        readonly System.Collections.Generic.List<LoginUser> users = new System.Collections.Generic.List<LoginUser>();
        private void NewPage(string role) { Response.Redirect(role.Equals("Admin") ? "~/Admin/UsersPage.aspx" : "~/User/UserPage.aspx"); }     
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (Request.Params["logout"] != null)
            {
                Response.Cookies["token"].Value = null;
                Response.Redirect("Login.aspx"); return;
            }
            if (!string.IsNullOrEmpty(Output.Text)) Output.Text = "";
            Register.Click += Register_Click; Submit.Click += Submit_Click;
            using HotelsContext context = new HotelsContext();
            users.AddRange(from user in context.User.AsEnumerable() from role in context.Role.AsEnumerable()
                           where role.Id == user.RoleId select new LoginUser(role.Name, user.Login, user.PasswordHash));
            if (Request.Cookies["token"] != null)
                foreach (LoginUser user in users)
                    if (Utils.MakeToken(user.Login, user.PasswordHash) == Request.Cookies["token"].Value)
                    { NewPage(user.Role); return; }
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