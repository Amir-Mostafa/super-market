namespace amir_mostafa.pl
{
    partial class support_mony
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
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Info;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(314, 203);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(328, 38);
            this.textBox11.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Info;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(314, 131);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(328, 38);
            this.textBox8.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(314, 65);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(328, 38);
            this.textBox9.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 32);
            this.label12.TabIndex = 31;
            this.label12.Text = "ضريبه البطاقه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 32);
            this.label9.TabIndex = 30;
            this.label9.Text = "الدعم الاضافي";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "الدعم الاساسي";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(314, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 55);
            this.button1.TabIndex = 39;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // support_mony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(690, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Name = "support_mony";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل الدعم";
            this.Load += new System.EventHandler(this.support_mony_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox11;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox textBox9;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button button1;
    }
}