namespace Teacher
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameListPanel1 = new Teacher.Panel.NameListPanel();
            this.menuButton2 = new Teacher.CustomComponents.Button.MenuButton();
            this.menuButton1 = new Teacher.CustomComponents.Button.MenuButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameListPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 338);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.menuButton2);
            this.panel2.Controls.Add(this.menuButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 338);
            this.panel2.TabIndex = 0;
            // 
            // nameListPanel1
            // 
            this.nameListPanel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.nameListPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameListPanel1.Location = new System.Drawing.Point(154, 0);
            this.nameListPanel1.Name = "nameListPanel1";
            this.nameListPanel1.Size = new System.Drawing.Size(367, 338);
            this.nameListPanel1.Students = null;
            this.nameListPanel1.TabIndex = 1;
            // 
            // menuButton2
            // 
            this.menuButton2.ButtonText = "Schedule";
            this.menuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.menuButton2.Location = new System.Drawing.Point(3, 79);
            this.menuButton2.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(144, 50);
            this.menuButton2.TabIndex = 1;
            this.menuButton2.TextLocation = new System.Drawing.Point(10, 10);
            // 
            // menuButton1
            // 
            this.menuButton1.ButtonText = "Name list";
            this.menuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.menuButton1.Location = new System.Drawing.Point(3, 12);
            this.menuButton1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(144, 50);
            this.menuButton1.TabIndex = 0;
            this.menuButton1.TextLocation = new System.Drawing.Point(10, 10);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = global::Teacher.Properties.Settings.Default.MySize;
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Teacher.Properties.Settings.Default, "MyLocatiton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(238)))));
            this.Location = global::Teacher.Properties.Settings.Default.MyLocatiton;
            this.Name = "Form1";
            this.Text = "先生支援ツール";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Teacher.CustomComponents.Button.MenuButton menuButton1;
        private Teacher.CustomComponents.Button.MenuButton menuButton2;
        private Panel.NameListPanel nameListPanel1;
    }
}

