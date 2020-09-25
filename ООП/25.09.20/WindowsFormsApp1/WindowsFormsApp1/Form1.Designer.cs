namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vbcvbcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xvbcvbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xcbxcbxvbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xbxbxvbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vbcvnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cvncvncvnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vncvncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.Location = new System.Drawing.Point(0, 115);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(390, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(759, 495);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("https://www.google.ru/", System.UriKind.Absolute);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 523);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 31);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(826, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Открыть страницу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1600, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vbcvbcToolStripMenuItem,
            this.xbxbxvbToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vbcvbcToolStripMenuItem
            // 
            this.vbcvbcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xvbcvbToolStripMenuItem,
            this.xcbxcbxvbToolStripMenuItem});
            this.vbcvbcToolStripMenuItem.Name = "vbcvbcToolStripMenuItem";
            this.vbcvbcToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.vbcvbcToolStripMenuItem.Text = "Файл";
            this.vbcvbcToolStripMenuItem.Click += new System.EventHandler(this.vbcvbcToolStripMenuItem_Click);
            // 
            // xvbcvbToolStripMenuItem
            // 
            this.xvbcvbToolStripMenuItem.Name = "xvbcvbToolStripMenuItem";
            this.xvbcvbToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xvbcvbToolStripMenuItem.Text = "Создать";
            this.xvbcvbToolStripMenuItem.Click += new System.EventHandler(this.xvbcvbToolStripMenuItem_Click);
            // 
            // xcbxcbxvbToolStripMenuItem
            // 
            this.xcbxcbxvbToolStripMenuItem.Name = "xcbxcbxvbToolStripMenuItem";
            this.xcbxcbxvbToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xcbxcbxvbToolStripMenuItem.Text = "Открыть";
            this.xcbxcbxvbToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // xbxbxvbToolStripMenuItem
            // 
            this.xbxbxvbToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vbcvnToolStripMenuItem});
            this.xbxbxvbToolStripMenuItem.Name = "xbxbxvbToolStripMenuItem";
            this.xbxbxvbToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.xbxbxvbToolStripMenuItem.Text = "Правка";
            // 
            // vbcvnToolStripMenuItem
            // 
            this.vbcvnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cvncvncvnToolStripMenuItem,
            this.vncvncToolStripMenuItem});
            this.vbcvnToolStripMenuItem.Name = "vbcvnToolStripMenuItem";
            this.vbcvnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vbcvnToolStripMenuItem.Text = "vbcvn";
            // 
            // cvncvncvnToolStripMenuItem
            // 
            this.cvncvncvnToolStripMenuItem.Name = "cvncvncvnToolStripMenuItem";
            this.cvncvncvnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cvncvncvnToolStripMenuItem.Text = "cvncvncvn";
            // 
            // vncvncToolStripMenuItem
            // 
            this.vncvncToolStripMenuItem.Name = "vncvncToolStripMenuItem";
            this.vncvncToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vncvncToolStripMenuItem.Text = "vncvnc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vbcvbcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xvbcvbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xcbxcbxvbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xbxbxvbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vbcvnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cvncvncvnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vncvncToolStripMenuItem;
    }
}

