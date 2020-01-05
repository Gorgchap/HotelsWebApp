using System.Web.UI.WebControls;

namespace WebApp
{
    [System.Web.UI.ToolboxData("<{0}:BookingDates runat=server></{0}:BookingDates>")]
    public class BookingDates : Panel
    {
        private readonly Label from = new Label() { Text = "C " }, to = new Label() { Text = "По " };
        private readonly TextBox begin = new TextBox(), end = new TextBox();
        public BookingDates()
        {
            Attributes.Add("style", "border: 1px black solid; display: flex; justify-content: space-around; padding: 1%");
            begin.Attributes.Add("id", "begin"); begin.Attributes.Add("type", "date");
            begin.Attributes.Add("style", "width: 40%; border: 1px black solid");
            end.Attributes.Add("id", "end"); end.Attributes.Add("type", "date");
            end.Attributes.Add("style", "width: 40%; border: 1px black solid");
            from.Attributes.Add("style", "margin-right: -10px"); to.Attributes.Add("style", "margin-right: -10px");
            Controls.Add(from); Controls.Add(begin); Controls.Add(to); Controls.Add(end);
        }
    }
}