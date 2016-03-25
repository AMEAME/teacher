using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Teacher.Modules;

namespace Teacher.Forms
{
    public partial class Form2 : Form
    {
        public List<Student> Students { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Size size = this.Size;
                this.DataBindings.Add(new Binding("ClientSize", Properties.Settings.Default, "MySubSize", true, DataSourceUpdateMode.OnPropertyChanged));
                this.Size = size;
                Properties.Settings.Default.Save();
            }
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Form1.StudentsFileName))
            {
                Directory.CreateDirectory(Form1.StudentsFileName.Split('/')[0]);
                Students = new List<Student>();
            }
            Students.Add(new Student(Students.Count + 1, this.textBox1.Text));
            XMLAccesser<List<Student>> xmlAccesser = new XMLAccesser<List<Student>>(Students);
            xmlAccesser.save(Form1.StudentsFileName);
            this.Close();
        }
    }
}
