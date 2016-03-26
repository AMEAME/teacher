using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Teacher.Modules;

namespace Teacher
{
    public partial class Form1 : Form
    {
        public List<Student> Students { get; set; }
        public static string StudentsFileName;

        public Form1()
        { 
            InitializeStudent();
            InitializeComponent();
            this.nameListPanel1.SetStudents(this.Students);
        }

        private void InitializeStudent()
        {
            Students = new List<Student>();
            StudentsFileName = @"Data/students.xml";
            if (System.IO.File.Exists(StudentsFileName))
            {
                XMLAccesser<List<Student>> xmlAccesser = XMLAccesser<List<Student>>.ReadXML(StudentsFileName);
                Students = xmlAccesser.Object;
                Students.ForEach(s => Console.WriteLine(s.ToString()));
            }
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Size size = this.Size;
                this.DataBindings.Add(new Binding("ClientSize", Properties.Settings.Default, "MySize", true, DataSourceUpdateMode.OnPropertyChanged));
                this.Size = size;
                Properties.Settings.Default.Save();
            }
        }

    }
}
