using DateTimeForm.Entities;
using DateTimeForm.Entities.Selected;

namespace DateTimeForm
{
    public partial class Form1 : Form
    {
        List<string> strings = new List<string> { "Günlük", "Haftalýk" };
        List<WeekOrDay> weekOrDayList = new List<WeekOrDay>();
        SelectionRange sr = new SelectionRange();
        List<DayOfWeek> selectedDays = new List<DayOfWeek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            ComboBox comboBox = (ComboBox)sender;
            string selectedEmployee = (string)comboBox1.SelectedItem;
            int z = 1;
            var days = weekOrDayList.FirstOrDefault(x => x.Value == selectedEmployee);
            foreach (var day in days.timeline)
            {
                comboBox2.Items.Add(day.Id + ". " + day.Value);
            }
            if (selectedEmployee == strings[1])
            {
                pazartesi.Visible = true;
                sali.Visible = true;
                carsamba.Visible = true;
                persembe.Visible = true;
                cuma.Visible = true;
                cumartesi.Visible = true;
                pazar.Visible = true;
            }
            if (selectedEmployee == strings[0])
            {
                pazartesi.Visible = false;
                sali.Visible = false;
                carsamba.Visible = false;
                persembe.Visible = false;
                cuma.Visible = false;
                cumartesi.Visible = false;
                pazar.Visible = false;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sr.Start = monthCalendar1.SelectionRange.Start;
         
            ComboBox comboBox = (ComboBox)sender;
            string selected1 = (string)comboBox1.SelectedItem;
            string selected2 = (string)comboBox2.SelectedItem;
            var charint = selected2.Split('.');
            var days = weekOrDayList.FirstOrDefault(x => x.Value == selected2);
            int selectedDateRange = Convert.ToInt16(charint[0]);
            if (selected1 == strings[0])
            {
                listBox1.Items.Clear();
                sr.End = sr.Start.Date.AddDays(selectedDateRange - 1);
                var listValues = sr.End - sr.Start;
                List<string> tarihListesi = new List<string>();
                for (DateTime tarih = sr.Start; tarih <= sr.End; tarih = tarih.AddDays(1))
                {
                    listBox1.Items.Add(tarih.ToShortDateString());
                    tarihListesi.Add(tarih.ToShortDateString());
                }
                sr.Start = DateTime.Parse(tarihListesi[0]);
                sr.End = DateTime.Parse(tarihListesi.Skip(tarihListesi.Count() - 1).First());
                monthCalendar2.SelectionRange = sr;
            }
            else if (selected1 == strings[1] && selectedDays.Count<1)
            {
                listBox1.Items.Clear();
                sr.End = sr.Start.Date.AddDays((selectedDateRange * 7) - 1);
                var listValues = sr.End - sr.Start;
                List<string> tarihListesi = new List<string>();
                for (DateTime tarih = sr.Start; tarih <= sr.End; tarih = tarih.AddDays(1))
                {
                    listBox1.Items.Add(tarih.ToShortDateString());
                    tarihListesi.Add(tarih.ToShortDateString());
                }
                sr.Start = DateTime.Parse(tarihListesi[0]);
                sr.End = DateTime.Parse(tarihListesi.Skip(tarihListesi.Count() - 1).First());
                monthCalendar2.SelectionRange = sr;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sr.Start = DateTime.Now;
            pazartesi.Visible = false;
            sali.Visible = false;
            carsamba.Visible = false;
            persembe.Visible = false;
            cuma.Visible = false;
            cumartesi.Visible = false;
            pazar.Visible = false;
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
            SelectionRange sr = new SelectionRange();
            sr.Start = monthCalendar2.SelectionRange.Start.Date;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            SelectionRange sr = new SelectionRange();
            sr.End = monthCalendar2.SelectionRange.End.Date;
        }

        private void pazartesi_Click(object sender, EventArgs e)
        {
            DateSelector(pazartesi,DayOfWeek.Monday);
        }

        private void sali_Click(object sender, EventArgs e)
        {
            DateSelector(sali, DayOfWeek.Tuesday);
           
        }

        private void carsamba_Click(object sender, EventArgs e)
        {
            DateSelector(carsamba, DayOfWeek.Wednesday);
        }

        private void persembe_Click(object sender, EventArgs e)
        {
            DateSelector(persembe, DayOfWeek.Thursday);
        }

        private void cuma_Click(object sender, EventArgs e)
        {
            DateSelector(cuma, DayOfWeek.Friday);
        }

        private void cumartesi_Click(object sender, EventArgs e)
        {
            DateSelector(cumartesi, DayOfWeek.Saturday);
        }

        private void pazar_Click(object sender, EventArgs e)
        {
            DateSelector(cumartesi, DayOfWeek.Sunday);
        }
        public void DateSelector(Button button,DayOfWeek dayOfWeek)
        {
            sr.Start = monthCalendar1.SelectionRange.Start.Date;
            listBox1.Items.Clear();
            string selected1 = (string)comboBox1.SelectedItem;
            string selected2 = (string)comboBox2.SelectedItem;
            if (selected1 == strings[1] && selected2 != null)
            {
                if (button.BackColor != System.Drawing.Color.Red)
                {
                    button.BackColor = System.Drawing.Color.Red;
                    selectedDays.Add(dayOfWeek);
                }
                else
                {
                    button.BackColor = default;
                    selectedDays.Remove(dayOfWeek);
                }
                var charint = selected2.Split('.');
                var days = weekOrDayList.FirstOrDefault(x => x.Value == selected2);
                int selectedDateRange = Convert.ToInt16(charint[0]);
                sr.End = sr.Start.Date.AddDays((selectedDateRange * 7) - 1);
                var listValues = sr.End - sr.Start;
                List<string> tarihListesi = new List<string>();
                List<DateTime> tarihListesidate = new List<DateTime>();
                for (DateTime tarih = sr.Start; tarih <= sr.End; tarih = tarih.AddDays(1))
                {
                    tarihListesidate.Add(tarih);
                    if (selectedDays.Contains(tarih.DayOfWeek))
                    {
                        listBox1.Items.Add(tarih.ToShortDateString() + " => " + tarih.DayOfWeek);
                    }

                    tarihListesi.Add(tarih.ToShortDateString());
                }
            }
        }
    }
}