namespace amir_mostafa.pl
{
    partial class backup_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cachedbarcode1 = new amir_mostafa.report.Cachedbarcode();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 131);
            this.button1.TabIndex = 0;
            this.button1.Text = "نسخه احتياطيه";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(522, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 131);
            this.button2.TabIndex = 1;
            this.button2.Text = "استرجاع نسخه احتياطيه";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(892, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "backup_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "النسخه الاحتياطيه";
            this.Load += new System.EventHandler(this.backup_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private report.Cachedbarcode cachedbarcode1;
    }
}