using DateTimeForm.Entities;

namespace DateTimeForm
{
    public partial class Form1 : Form
    {
        List<string> strings = new List<string> { "Günlük", "Haftalýk" };
        List<WeekOrDay> weekOrDayList = new List<WeekOrDay>();
        SelectionRange sr1 = new SelectionRange();
        SelectionRange sr2 = new SelectionRange();
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
            sr1.Start = monthCalendar1.SelectionRange.Start;
            var compare = sr2.End - sr1.Start;
            if (compare.TotalMinutes > 0)
            {
                ComboBox comboBox = (ComboBox)sender;
                string selected1 = (string)comboBox1.SelectedItem;
                string selected2 = (string)comboBox2.SelectedItem;
                var charint = selected2.Split('.');
                var days = weekOrDayList.FirstOrDefault(x => x.Value == selected2);
                int selectedDateRange = Convert.ToInt16(charint[0]);
                if (selected1 == strings[0])
                {
                    listBox1.Items.Clear();
                    //sr2.End = sr1.Start.Date.AddDays(selectedDateRange);
                    var listValues = sr2.End - sr1.Start;
                    for (DateTime tarih = sr1.Start; tarih <= sr2.End; tarih = tarih.AddDays(selectedDateRange))
                    {
                        listBox1.Items.Add(tarih.ToShortDateString());
                    }

                }
                else if (selected1 == strings[1] && selectedDays.Count < 1)
                {
                    listBox1.Items.Clear();
                    //sr2.End = sr1.Start.Date.AddDays((selectedDateRange * 7) - 1);
                    var listValues = sr2.End - sr1.Start;
                    for (DateTime tarih = sr1.Start; tarih <= sr2.End; tarih = tarih.AddDays(selectedDateRange + 7))
                    {
                        listBox1.Items.Add(tarih.ToShortDateString());
                    }

                }
            }
            else
            {
                listBox1.Items.Add("Lütfen Bitiþ Tarihi Seçiniz");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sr1.Start = DateTime.Now;
            sr2.Start = DateTime.Now;
            sr1.End = DateTime.Now;
            sr2.End = DateTime.Now;
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
            sr1.Start = monthCalendar1.SelectionRange.Start.Date;
            sr1.End = monthCalendar1.SelectionRange.End.Date;
            monthCalendar1.SelectionRange = sr1;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            sr2.Start = monthCalendar2.SelectionRange.Start.Date;
            sr2.End = monthCalendar2.SelectionRange.End.Date;
            monthCalendar2.SelectionRange = sr2;
        }

        private void pazartesi_Click(object sender, EventArgs e)
        {
            DateSelector(pazartesi, DayOfWeek.Monday);
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
        public void DateSelector(Button button, DayOfWeek dayOfWeek)
        {
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
                var listValues = sr2.End - sr1.Start;
                int counter = 0;
                for (DateTime tarih = sr1.Start; tarih <= sr2.End; tarih = tarih.AddDays(1))
                {
                    if (selectedDays.Contains(tarih.DayOfWeek))
                    {
                        counter++;
                        listBox1.Items.Add(tarih.ToShortDateString() + " => " + tarih.DayOfWeek);
                        if (counter == selectedDays.Count())
                        {
                            tarih = tarih.AddDays((selectedDateRange * 7) - selectedDays.Count());
                        }

                    }
                }
            }
        }
    }
}