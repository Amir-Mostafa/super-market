namespace amir_mostafa.pl
{
    partial class clint_report
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clintssBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tamwinDataSet12 = new amir_mostafa.tamwinDataSet12();
            this.clintssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamwinDataSet8 = new amir_mostafa.tamwinDataSet8();
            this.label4 = new System.Windows.Forms.Label();
            this.clintssTableAdapter = new amir_mostafa.tamwinDataSet8TableAdapters.clintssTableAdapter();
            this.clintssTableAdapter1 = new amir_mostafa.tamwinDataSet12TableAdapters.clintssTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clintssBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clintssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(271, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "تم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "الي :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "من :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 277);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(452, 34);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Value = new System.DateTime(2019, 2, 10, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(452, 34);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(452, 37);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clintssBindingSource1
            // 
            this.clintssBindingSource1.DataMember = "clintss";
            this.clintssBindingSource1.DataSource = this.tamwinDataSet12;
            // 
            // tamwinDataSet12
            // 
            this.tamwinDataSet12.DataSetName = "tamwinDataSet12";
            this.tamwinDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clintssBindingSource
            // 
            this.clintssBindingSource.DataMember = "clintss";
            this.clintssBindingSource.DataSource = this.tamwinDataSet8;
            // 
            // tamwinDataSet8
            // 
            this.tamwinDataSet8.DataSetName = "tamwinDataSet8";
            this.tamwinDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "اسم العميل ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // clintssTableAdapter
            // 
            this.clintssTableAdapter.ClearBeforeFill = true;
            // 
            // clintssTableAdapter1
            // 
            this.clintssTableAdapter1.ClearBeforeFill = true;
            // 
            // clint_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(629, 485);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "clint_report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير عميل";
            this.Load += new System.EventHandler(this.clint_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clintssBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clintssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label4;
        private tamwinDataSet8 tamwinDataSet8;
        private System.Windows.Forms.BindingSource clintssBindingSource;
        private tamwinDataSet8TableAdapters.clintssTableAdapter clintssTableAdapter;
        private tamwinDataSet12 tamwinDataSet12;
        private System.Windows.Forms.BindingSource clintssBindingSource1;
        private tamwinDataSet12TableAdapters.clintssTableAdapter clintssTableAdapter1;
    }
}