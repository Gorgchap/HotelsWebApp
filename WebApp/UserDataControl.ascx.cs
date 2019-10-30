using System.Linq;

namespace WebApp
{
    public partial class UserDataControl : System.Web.UI.UserControl
    {
        public int UserId { get; set; }
        public string Login { get => TextLogin.Text; set => TextLogin.Text = value; }
        public string Name { get => TextName.Text; set => TextName.Text = value; }
        public string Surname { get => TextSurname.Text; set => TextSurname.Text = value; }
        public string Email { get => TextEmail.Text; set => TextEmail.Text = value; }
        public string Phone { get => TextPhone.Text; set => TextPhone.Text = value; }
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (!IsPostBack && UserId > 0)
                using (HotelsContext context = new HotelsContext())
                {
                    User u = (from user in context.User where user.Id == UserId select user).First();
                    Login = u.Login; Name = u.Name; Surname = u.Surname; Email = u.Email; Phone = u.Phone;
                }
        }
    }
}