using System.Linq;

namespace WebApp
{
    public partial class AddUser : System.Web.UI.Page
    {
        readonly System.Collections.Generic.List<User> users = new System.Collections.Generic.List<User>();
        protected void Page_Load(object sender, System.EventArgs e)
        {
            Add.Click += Add_Click; using HotelsContext context = new HotelsContext();
            users.AddRange(from user in context.User.AsEnumerable() select user);
        }
        private void Add_Click(object sender, System.EventArgs e)
        {
            string errors = Utils.CheckUserData(Data.UserId, Data.Login, Data.Name, Data.Surname, Data.Email, Data.Phone, users);
            if (errors.Length == 0)
                using (HotelsContext context = new HotelsContext())
                {
                    context.User.Add(new User { RoleId = 2, Login = Data.Login, Name = Data.Name, Surname = Data.Surname,
                        Email = Data.Email, Phone = Data.Phone, PasswordHash = Utils.ConvertToSHA512(Password.Text) });
                    context.SaveChanges(); Response.Redirect("UsersPage.aspx"); return;
                }
            Output.Text = "Add credentials (" + errors.Remove(errors.Length - 2) + ") have been rejected"; Output.ForeColor = System.Drawing.Color.Red;
        }
    }
}