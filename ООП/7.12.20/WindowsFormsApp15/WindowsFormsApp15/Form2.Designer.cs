namespace WindowsFormsApp15
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.polBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDataSet = new WindowsFormsApp15.PeopleDataSet();
            this.polTableAdapter = new WindowsFormsApp15.PeopleDataSetTableAdapters.PolTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDataSet1 = new WindowsFormsApp15.PeopleDataSet1();
            this.kategoryTableAdapter = new WindowsFormsApp15.PeopleDataSet1TableAdapters.KategoryTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.nosologyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDataSet2 = new WindowsFormsApp15.PeopleDataSet2();
            this.nosologyTableAdapter = new WindowsFormsApp15.PeopleDataSet2TableAdapters.NosologyTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosologyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(852, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(852, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(95, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(95, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 31);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(95, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 31);
            this.textBox3.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(100, 235);
            this.maskedTextBox1.Mask = "+7(000)-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(283, 31);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(100, 293);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(283, 31);
            this.textBox4.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.polBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "id";
            // 
            // polBindingSource
            // 
            this.polBindingSource.DataMember = "Pol";
            this.polBindingSource.DataSource = this.peopleDataSet;
            // 
            // peopleDataSet
            // 
            this.peopleDataSet.DataSetName = "PeopleDataSet";
            this.peopleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polTableAdapter
            // 
            this.polTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 401);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.kategoryBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(504, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(278, 33);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "id";
            // 
            // kategoryBindingSource
            // 
            this.kategoryBindingSource.DataMember = "Kategory";
            this.kategoryBindingSource.DataSource = this.peopleDataSet1;
            // 
            // peopleDataSet1
            // 
            this.peopleDataSet1.DataSetName = "PeopleDataSet1";
            this.peopleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoryTableAdapter
            // 
            this.kategoryTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.nosologyBindingSource;
            this.comboBox3.DisplayMember = "Naimenovanie";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(504, 127);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(278, 33);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.ValueMember = "id";
            // 
            // nosologyBindingSource
            // 
            this.nosologyBindingSource.DataMember = "Nosology";
            this.nosologyBindingSource.DataSource = this.peopleDataSet2;
            // 
            // peopleDataSet2
            // 
            this.peopleDataSet2.DataSetName = "PeopleDataSet2";
            this.peopleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nosologyTableAdapter
            // 
            this.nosologyTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(519, 215);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(263, 217);
            this.textBox5.TabIndex = 11;
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1032, 519);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosologyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.ComboBox comboBox1;
        public PeopleDataSet peopleDataSet;
        public System.Windows.Forms.BindingSource polBindingSource;
        public PeopleDataSetTableAdapters.PolTableAdapter polTableAdapter;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox comboBox2;
        public PeopleDataSet1 peopleDataSet1;
        public System.Windows.Forms.BindingSource kategoryBindingSource;
        public PeopleDataSet1TableAdapters.KategoryTableAdapter kategoryTableAdapter;
        public System.Windows.Forms.ComboBox comboBox3;
        public PeopleDataSet2 peopleDataSet2;
        public System.Windows.Forms.BindingSource nosologyBindingSource;
        public PeopleDataSet2TableAdapters.NosologyTableAdapter nosologyTableAdapter;
        public System.Windows.Forms.TextBox textBox5;
    }
}