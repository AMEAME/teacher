using System;

namespace Teacher.Panel
{
    partial class NameListPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newNameButton1 = new Teacher.CustomComponents.Button.NewNameButton();
            this.SuspendLayout();
            // 
            // newNameButton1
            // 
            this.newNameButton1.ButtonText = "New";
            this.newNameButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newNameButton1.Location = new System.Drawing.Point(5, 15);
            this.newNameButton1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.newNameButton1.Name = "newNameButton1";
            this.newNameButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newNameButton1.Size = new System.Drawing.Size(80, 50);
            this.newNameButton1.TabIndex = 0;
            this.newNameButton1.TextLocation = new System.Drawing.Point(10, 10);
            this.newNameButton1.Click += new System.EventHandler(this.newNameButton1_Click);
            // 
            // NameListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.newNameButton1);
            this.Name = "NameListPanel";
            this.Size = new System.Drawing.Size(517, 487);
            this.Resize += new EventHandler(NameListPanel_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.Button.NewNameButton newNameButton1;
    }
}
