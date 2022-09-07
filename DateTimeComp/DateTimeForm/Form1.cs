using DateTimeForm.Entities;

namespace DateTimeForm
{
    public partial class Form1 : Form
    {
        List<string> strings = new List<string> { "Günlük", "Haftalýk" };
        List<WeekOrDay> weekOrDayList = new List<WeekOrDay>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedEmployee = (string)comboBox1.SelectedItem;
            int z = 1;
            var days=weekOrDayList.FirstOrDefault(x => x.Value==selectedEmployee);
            foreach (var day in days.timeline)
            {
                comboBox2.Items.Add(day.Id + ". " + day.Value);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            int z = 1;
            foreach (string s in strings)
            {
                WeekOrDay weekOrDay = new WeekOrDay();
                List<Timeline> timelineList = new List<Timeline>();
                weekOrDay.Id = z;
                weekOrDay.Value = s;
                comboBox1.Items.Add(s);
                for (int i = 1; i < 30; i++)
                {
                    Timeline timeline = new Timeline();
                    timeline.Id = i;
                    timeline.Value = s;
                    timelineList.Add(timeline);
                }
                weekOrDay.timeline = timelineList;
                weekOrDayList.Add(weekOrDay);
                z++;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
    }
}