using Context;
using System.Linq;
namespace WebApp
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        readonly System.Collections.Generic.List<LoginUser> users = new System.Collections.Generic.List<LoginUser>();
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Output.Text)) Output.Text = ""; Submit.Click += Submit_Click; using HotelsContext context = new HotelsContext();
            users.AddRange(from u in context.User.AsEnumerable() select new LoginUser(null, u.Login, u.PasswordHash));
        }
        private void Submit_Click(object sender, System.EventArgs e)
        {
            using HotelsContext context = new HotelsContext(); Output.ForeColor = System.Drawing.Color.Red;
            if (NewPwd.Text != NewPwd2.Text) { Output.Text = "New password is not equal to confirmation"; return; }
            foreach (LoginUser user in users)
                if (Utils.MakeToken(user.Login, Utils.ConvertToSHA512(CurPwd.Text)) == Request.Cookies["token"].Value)
                {
                    User us = (from u in context.User where u.Login == user.Login select u).First();
                    us.PasswordHash = Utils.ConvertToSHA512(NewPwd.Text); context.SaveChanges();
                    Request.Cookies["token"].Value = Utils.MakeToken(us.Login, us.PasswordHash);
                    Response.Redirect("Hotels.aspx"); return;
                }
            Output.Text = "Wrong password has been entered";
        }
    }
}