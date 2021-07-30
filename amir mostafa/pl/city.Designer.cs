namespace amir_mostafa.pl
{
    partial class city
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 36);
            this.label5.TabIndex = 51;
            this.label5.Text = "اسم البلد :";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(234, 134);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(470, 41);
            this.txt_name.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 63);
            this.button1.TabIndex = 52;
            this.button1.Text = "اضافه";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // city
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Name = "city";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "city";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button1;
    }
}