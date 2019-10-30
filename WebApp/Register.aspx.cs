using System.Linq;

namespace WebApp
{
    public partial class Register : System.Web.UI.Page
    {
        readonly System.Collections.Generic.List<User> users = new System.Collections.Generic.List<User>();
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Output.Text)) Output.Text = ""; LoginPage.Click += LoginPage_Click; Submit.Click += Submit_Click;
            using HotelsContext context = new HotelsContext(); users.AddRange(from user in context.User.AsEnumerable() select user);
        }
        private void LoginPage_Click(object sender, System.EventArgs e) { Response.Redirect("Login.aspx"); }
        private void Submit_Click(object sender, System.EventArgs e)
        {
            string errors = Utils.CheckUserData(LogIn.Text, Name.Text, Surname.Text, Email.Text, Phone.Text, users);
            errors += Pwd.Text != Pwd2.Text || string.IsNullOrEmpty(Pwd.Text) || string.IsNullOrEmpty(Pwd2.Text) ? "password, " : "";          
            if (errors.Length == 0)
            {
                using HotelsContext context = new HotelsContext();
                context.User.Add(new User()
                {
                    RoleId = 2, Login = LogIn.Text, Name = Name.Text, Surname = Surname.Text,
                    Email = Email.Text, Phone = Phone.Text, PasswordHash = Utils.ConvertToSHA512(Pwd.Text)
                });
                context.SaveChanges(); LoginPage_Click(null, null); return;
            }
            Output.Text = "Register credentials (" + errors.Remove(errors.Length - 2) + ") have been rejected"; Output.ForeColor = System.Drawing.Color.Red;
        }
    }
}