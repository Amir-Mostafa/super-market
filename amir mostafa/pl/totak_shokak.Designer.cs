namespace amir_mostafa.pl
{
    partial class totak_shokak
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مجموع حقل الدائن";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(30, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 38);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مجموع حقل المدين";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(30, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 38);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اجمالي الاجل";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(30, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(315, 38);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "0";
            // 
            // totak_shokak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "totak_shokak";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "totak_shokak";
            this.Load += new System.EventHandler(this.totak_shokak_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBox3;
    }
}