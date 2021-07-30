namespace amir_mostafa.pl
{
    partial class form_confi
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.rbwin = new System.Windows.Forms.RadioButton();
            this.rbsql = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(241, 67);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(362, 37);
            this.txtServer.TabIndex = 0;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم السيرفر :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "قاعده البيانات :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(241, 127);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(362, 37);
            this.txtDatabase.TabIndex = 2;
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "كلمه المرور :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(241, 352);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(362, 37);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "اسم المستخدم :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(241, 408);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(362, 37);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // rbwin
            // 
            this.rbwin.AutoSize = true;
            this.rbwin.Checked = true;
            this.rbwin.Location = new System.Drawing.Point(241, 206);
            this.rbwin.Name = "rbwin";
            this.rbwin.Size = new System.Drawing.Size(295, 34);
            this.rbwin.TabIndex = 8;
            this.rbwin.TabStop = true;
            this.rbwin.Text = "Windows Authentication";
            this.rbwin.UseVisualStyleBackColor = true;
            this.rbwin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbsql
            // 
            this.rbsql.AutoSize = true;
            this.rbsql.Location = new System.Drawing.Point(241, 263);
            this.rbsql.Name = "rbsql";
            this.rbsql.Size = new System.Drawing.Size(314, 34);
            this.rbsql.TabIndex = 9;
            this.rbsql.Text = "SQL Server Authentication";
            this.rbsql.UseVisualStyleBackColor = true;
            this.rbsql.CheckedChanged += new System.EventHandler(this.rbsql_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "طريقه الدخول :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Brown;
            this.btnsave.Location = new System.Drawing.Point(206, 486);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(147, 51);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "حفظ ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Brown;
            this.btnClose.Location = new System.Drawing.Point(423, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 51);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_confi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(617, 609);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbsql);
            this.Controls.Add(this.rbwin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "form_confi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الاتصال بالسيرفر";
            this.Load += new System.EventHandler(this.form_confi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton rbwin;
        private System.Windows.Forms.RadioButton rbsql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnClose;
    }
}