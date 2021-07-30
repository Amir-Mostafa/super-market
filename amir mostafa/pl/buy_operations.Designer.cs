namespace amir_mostafa.pl
{
    partial class buy_operations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamwinDataSet = new amir_mostafa.tamwinDataSet();
            this.clintsTableAdapter = new amir_mostafa.tamwinDataSetTableAdapters.clintsTableAdapter();
            this.clintsTableAdapter1 = new amir_mostafa.tamwinDataSetTableAdapters.clintsTableAdapter();
            this.العملاءBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clintsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.العملاءBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 60;
            this.label5.Text = "بحث :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(224, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(580, 41);
            this.textBox1.TabIndex = 59;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 543);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // clintsTableAdapter1
            // 
            this.clintsTableAdapter1.ClearBeforeFill = true;
            // 
            // العملاءBindingSource
            // 
            this.العملاءBindingSource.DataMember = "العملاء";
            // 
            // buy_operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1117, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "buy_operations";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عمليات الشراء";
            this.Load += new System.EventHandler(this.buy_operations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clintsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.العملاءBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clintsBindingSource;
        private tamwinDataSet tamwinDataSet;
        private tamwinDataSetTableAdapters.clintsTableAdapter clintsTableAdapter;
        private tamwinDataSetTableAdapters.clintsTableAdapter clintsTableAdapter1;
        private System.Windows.Forms.BindingSource العملاءBindingSource;
    }
}