namespace DateTimeForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pazartesi = new System.Windows.Forms.Button();
            this.sali = new System.Windows.Forms.Button();
            this.carsamba = new System.Windows.Forms.Button();
            this.persembe = new System.Windows.Forms.Button();
            this.cuma = new System.Windows.Forms.Button();
            this.cumartesi = new System.Windows.Forms.Button();
            this.pazar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(654, 40);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(654, 238);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 2;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(999, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 469);
            this.listBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(29, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 23);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pazartesi
            // 
            this.pazartesi.Location = new System.Drawing.Point(29, 165);
            this.pazartesi.Name = "pazartesi";
            this.pazartesi.Size = new System.Drawing.Size(75, 23);
            this.pazartesi.TabIndex = 6;
            this.pazartesi.Text = "Pazartesi";
            this.pazartesi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pazartesi.UseVisualStyleBackColor = true;
            this.pazartesi.Click += new System.EventHandler(this.pazartesi_Click);
            // 
            // sali
            // 
            this.sali.Location = new System.Drawing.Point(165, 165);
            this.sali.Name = "sali";
            this.sali.Size = new System.Drawing.Size(75, 23);
            this.sali.TabIndex = 7;
            this.sali.Text = "Salı";
            this.sali.UseVisualStyleBackColor = true;
            this.sali.Click += new System.EventHandler(this.sali_Click);
            // 
            // carsamba
            // 
            this.carsamba.Location = new System.Drawing.Point(314, 164);
            this.carsamba.Name = "carsamba";
            this.carsamba.Size = new System.Drawing.Size(75, 23);
            this.carsamba.TabIndex = 8;
            this.carsamba.Text = "Çarşamba";
            this.carsamba.UseVisualStyleBackColor = true;
            this.carsamba.Click += new System.EventHandler(this.carsamba_Click);
            // 
            // persembe
            // 
            this.persembe.Location = new System.Drawing.Point(29, 226);
            this.persembe.Name = "persembe";
            this.persembe.Size = new System.Drawing.Size(75, 23);
            this.persembe.TabIndex = 9;
            this.persembe.Text = "Perşembe";
            this.persembe.UseVisualStyleBackColor = true;
            this.persembe.Click += new System.EventHandler(this.persembe_Click);
            // 
            // cuma
            // 
            this.cuma.Location = new System.Drawing.Point(165, 226);
            this.cuma.Name = "cuma";
            this.cuma.Size = new System.Drawing.Size(75, 23);
            this.cuma.TabIndex = 10;
            this.cuma.Text = "Cuma";
            this.cuma.UseVisualStyleBackColor = true;
            this.cuma.Click += new System.EventHandler(this.cuma_Click);
            // 
            // cumartesi
            // 
            this.cumartesi.Location = new System.Drawing.Point(314, 226);
            this.cumartesi.Name = "cumartesi";
            this.cumartesi.Size = new System.Drawing.Size(75, 23);
            this.cumartesi.TabIndex = 11;
            this.cumartesi.Text = "Cumartesi";
            this.cumartesi.UseVisualStyleBackColor = true;
            this.cumartesi.Click += new System.EventHandler(this.cumartesi_Click);
            // 
            // pazar
            // 
            this.pazar.Location = new System.Drawing.Point(24, 284);
            this.pazar.Name = "pazar";
            this.pazar.Size = new System.Drawing.Size(75, 23);
            this.pazar.TabIndex = 12;
            this.pazar.Text = "Pazar";
            this.pazar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pazar.UseVisualStyleBackColor = true;
            this.pazar.Click += new System.EventHandler(this.pazar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 536);
            this.Controls.Add(this.pazar);
            this.Controls.Add(this.cumartesi);
            this.Controls.Add(this.cuma);
            this.Controls.Add(this.persembe);
            this.Controls.Add(this.carsamba);
            this.Controls.Add(this.sali);
            this.Controls.Add(this.pazartesi);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button pazartesi;
        private Button sali;
        private Button carsamba;
        private Button persembe;
        private Button cuma;
        private Button cumartesi;
        private Button pazar;
    }
}