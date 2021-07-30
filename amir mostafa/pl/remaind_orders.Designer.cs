namespace amir_mostafa.pl
{
    partial class remaind_orders
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
            this.clintsTableAdapter1 = new amir_mostafa.tamwinDataSetTableAdapters.clintsTableAdapter();
            this.العملاءBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
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
            this.label5.Location = new System.Drawing.Point(174, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 57;
            this.label5.Text = "بحث :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(372, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 41);
            this.textBox1.TabIndex = 56;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 480);
            this.dataGridView1.TabIndex = 58;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 44);
            this.label1.TabIndex = 59;
            this.label1.Text = "مبيعات آجل";
            // 
            // remaind_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "remaind_orders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "remaind_orders";
            this.Load += new System.EventHandler(this.remaind_orders_Load);
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
        private tamwinDataSetTableAdapters.clintsTableAdapter clintsTableAdapter1;
        private System.Windows.Forms.BindingSource العملاءBindingSource;
        private System.Windows.Forms.Label label1;

    }
}