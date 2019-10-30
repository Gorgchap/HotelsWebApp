using System.Linq;

namespace WebApp
{
    public partial class EditUser : System.Web.UI.Page
    {
        readonly System.Collections.Generic.List<User> users = new System.Collections.Generic.List<User>();
        protected void Page_Load(object sender, System.EventArgs e)
        {
            using HotelsContext context = new HotelsContext(); Data.UserId = int.Parse(Request.Params["id"]);
            Save.Click += Save_Click; users.AddRange(from user in context.User.AsEnumerable() select user);
        }
        private void Save_Click(object sender, System.EventArgs e)
        {
            string errors = Utils.CheckUserData(Data.Login, Data.Name, Data.Surname, Data.Email, Data.Phone, users);
            if (errors.Length == 0)
                using (HotelsContext context = new HotelsContext())
                {
                    User u = (from user in context.User where user.Id == Data.UserId select user).First();
                    u.Login = Data.Login; u.Name = Data.Name; u.Surname = Data.Surname; u.Email = Data.Email;
                    u.Phone = Data.Phone; context.SaveChanges(); Response.Redirect("UsersPage.aspx"); return;
                }
            Output.Text = "Edit credentials (" + errors.Remove(errors.Length - 2) + ") have been rejected"; Output.ForeColor = System.Drawing.Color.Red;
        }
    }
}