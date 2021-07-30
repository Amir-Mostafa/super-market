namespace amir_mostafa.pl
{
    partial class all_orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamwinDataSet = new amir_mostafa.tamwinDataSet();
            this.clintsTableAdapter = new amir_mostafa.tamwinDataSetTableAdapters.clintsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clintsTableAdapter1 = new amir_mostafa.tamwinDataSetTableAdapters.clintsTableAdapter();
            this.العملاءBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.clintsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.العملاءBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 54;
            this.label5.Text = "بحث :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(372, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 41);
            this.textBox1.TabIndex = 53;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clintsBindingSource
            // 
            this.clintsBindingSource.DataMember = "clints";
            this.clintsBindingSource.DataSource = this.tamwinDataSet;
            // 
            // tamwinDataSet
            // 
            this.tamwinDataSet.DataSetName = "tamwinDataSet";
            this.tamwinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clintsTableAdapter
            // 
            this.clintsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 532);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // clintsTableAdapter1
            // 
            this.clintsTableAdapter1.ClearBeforeFill = true;
            // 
            // العملاءBindingSource
            // 
            this.العملاءBindingSource.DataMember = "العملاء";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1061, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 43);
            this.radioButton2.TabIndex = 63;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "الكل";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(948, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 43);
            this.radioButton1.TabIndex = 62;
            this.radioButton1.Text = "آجل";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // all_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "all_orders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كل الفواتير";
            this.Load += new System.EventHandler(this.all_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clintsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.العملاءBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource clintsBindingSource;
        private tamwinDataSet tamwinDataSet;
        private tamwinDataSetTableAdapters.clintsTableAdapter clintsTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource العملاءBindingSource;
        private tamwinDataSetTableAdapters.clintsTableAdapter clintsTableAdapter1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}