using System; using System.ComponentModel; using System.Web.UI.WebControls;

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
            begin.Attributes.Add("id", "begin"); begin.Attributes.Add("style", "width: 40%; border: 1px black solid");
            end.Attributes.Add("id", "end"); end.Attributes.Add("style", "width: 40%; border: 1px black solid");
            from.Attributes.Add("style", "margin-right: -10px"); to.Attributes.Add("style", "margin-right: -10px");
            Controls.Add(from); Controls.Add(begin); Controls.Add(to); Controls.Add(end);
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("01.01.2020")]
        [Localizable(true)]
        public DateTime MinDate { get; set; }
        
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("01.01.2020")]
        [Localizable(true)]
        public DateTime BeginDate 
        {
            get 
            {
                if (!DateTime.TryParse(begin.Text, out DateTime date))
                    return MinDate;
                if (!DateTime.TryParse(end.Text, out DateTime date_))
                    date_ = MinDate.AddDays(7);
                if (date > date_)
                    date = date_;
                if (date < MinDate)
                    date = MinDate;
                return date;
            }
            set => begin.Text = value.ToString().Substring(0, 10);
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("31.12.2020")]
        [Localizable(true)]
        public DateTime EndDate
        {
            get
            {
                if (!DateTime.TryParse(end.Text, out DateTime date))
                    return BeginDate.AddDays(7);
                if (date < BeginDate)
                    date = Convert.ToDateTime(begin.Text).Date;
                if (date < BeginDate.AddDays(7))
                    return BeginDate.AddDays(7);
                if (date > BeginDate.AddDays(30))
                    return BeginDate.AddDays(30);
                return date;
            }
            set => end.Text = value.ToString().Substring(0, 10);
        }
    }
}