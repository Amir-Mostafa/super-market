namespace amir_mostafa.pl
{
    partial class report_buys
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.supportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamwinDataSet9 = new amir_mostafa.tamwinDataSet9();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.supportsTableAdapter = new amir_mostafa.tamwinDataSet9TableAdapters.supportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DataSource = this.supportsBindingSource;
            this.comboBox1.DisplayMember = "support_name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(452, 37);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "support_id";
            // 
            // supportsBindingSource
            // 
            this.supportsBindingSource.DataMember = "supports";
            this.supportsBindingSource.DataSource = this.tamwinDataSet9;
            // 
            // tamwinDataSet9
            // 
            this.tamwinDataSet9.DataSetName = "tamwinDataSet9";
            this.tamwinDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "اسم المورد";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(481, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "مورد محدد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "الي :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "من :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(254, 261);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(452, 34);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2019, 2, 10, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(452, 34);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(284, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 51);
            this.button2.TabIndex = 19;
            this.button2.Text = "الكل";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // supportsTableAdapter
            // 
            this.supportsTableAdapter.ClearBeforeFill = true;
            // 
            // report_buys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(824, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "report_buys";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير مشتريات";
            this.Load += new System.EventHandler(this.report_buys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private tamwinDataSet9 tamwinDataSet9;
        private System.Windows.Forms.BindingSource supportsBindingSource;
        private tamwinDataSet9TableAdapters.supportsTableAdapter supportsTableAdapter;
    }
}