namespace amir_mostafa.pl
{
    partial class clints_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamwinDataSet = new amir_mostafa.tamwinDataSet();
            this.clintsTableAdapter = new amir_mostafa.tamwinDataSetTableAdapters.clintsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clintsTableAdapter1 = new amir_mostafa.tamwinDataSetTableAdapters.clintsTableAdapter();
            this.العملاءBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label5.Location = new System.Drawing.Point(91, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 40;
            this.label5.Text = "بحث :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(289, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(779, 41);
            this.textBox1.TabIndex = 39;
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 468);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(806, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 64);
            this.button3.TabIndex = 52;
            this.button3.Text = "تعديل بيانات العميل";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(590, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 64);
            this.button2.TabIndex = 51;
            this.button2.Text = "حذف العميل المحدد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(347, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 64);
            this.button1.TabIndex = 50;
            this.button1.Text = "جديد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clintsTableAdapter1
            // 
            this.clintsTableAdapter1.ClearBeforeFill = true;
            // 
            // العملاءBindingSource
            // 
            this.العملاءBindingSource.DataMember = "العملاء";
            // 
            // clints_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1292, 624);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "clints_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clints_form";
            this.Load += new System.EventHandler(this.clints_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clintsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.العملاءBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource العملاءBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private tamwinDataSet tamwinDataSet;
        private System.Windows.Forms.BindingSource clintsBindingSource;
        private tamwinDataSetTableAdapters.clintsTableAdapter clintsTableAdapter;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private tamwinDataSetTableAdapters.clintsTableAdapter clintsTableAdapter1;
    }
}