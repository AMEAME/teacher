﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Teacher.Forms;
using Teacher.Modules;

namespace Teacher.CustomComponents.Panel
{
    public partial class NameListPanel : UserControl
    {
        public List<Student> Students { get; set; }
        public List<System.Windows.Forms.Button> StudentButtonList { get; set; }

        private Size ButtonSize;

        public NameListPanel()
        {
            InitializeComponent();
        }

        public void SetStudents(List<Student> students)
        {
            this.Students = students;
            StudentButtonList = new List<System.Windows.Forms.Button>();
            ButtonSize = new Size(150, 70);
            createButton();
        }

        private void NameListPanel_Resize(object sender, EventArgs e)
        {
            if (Students != null)
            {
                setButtonLocation();
            }
        }

        private void setButtonLocation()
        {
            if (StudentButtonList != null && Students != null)
            {
                int row = this.Width / 160;
                if (row == 0)
                {
                    return;
                }
                for (int i = 0; i < Students.Count; i++)
                {
                    int width = (ButtonSize.Width + 10) * (i - row * (i / row)) + 10;
                    int height = (ButtonSize.Height + 10) * (i / row) + 80;
                    StudentButtonList[i].Location = new Point(width, height);
                }
            }
        }

        private void createButton()
        {
            if (this.Students != null)
            {
                for (int i = 0; i < Students.Count; i++)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                    button.Size = ButtonSize;
                    button.BackColor = Color.LightCyan;
                    button.ForeColor = Color.Black;
                    button.Font = new Font("Microsoft Sans Serif", 20);
                    button.Text = Students[i].Name;
                    this.Controls.Add(button);
                    StudentButtonList.Add(button);
                }
            }
        }


        private void addButton()
        {
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            button.Size = ButtonSize;
            button.BackColor = Color.LightCyan;
            button.ForeColor = Color.Black;
            button.Font = new Font("Microsoft Sans Serif", 20);
            button.Text = Students[Students.Count - 1].Name;
            this.Controls.Add(button);
            StudentButtonList.Add(button);
        }

        private void newNameButton1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (this.Students == null)
            {
                this.Students = new List<Student>();
            }
            form.Students = this.Students;
            int beforetCount = this.Students.Count;
            form.ShowDialog();
            if (beforetCount + 1 == form.Students.Count)
            {
                addButton();
            }
            form.Dispose();
            setButtonLocation();
        }

    }

}
