using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amir_mostafa.pl
{
    public partial class form_confi : Form
    {
        public form_confi()
        {
            InitializeComponent();
            txtServer.Text = Properties.Settings.Default.server;
            txtDatabase.Text = Properties.Settings.Default.database;
            if (Properties.Settings.Default.mode == "SQL")
            {
                rbsql.Checked = true; 
                txtUsername.Text = Properties.Settings.Default.id;
                txtPass.Text = Properties.Settings.Default.password;
            }
            else
            {
                rbwin.Checked = true;
                txtUsername.Text = "";
                txtPass.Text = "";
                txtUsername.ReadOnly = true;
                txtPass.ReadOnly = true;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = txtServer.Text;
            Properties.Settings.Default.database = txtDatabase.Text;
            Properties.Settings.Default.mode = rbwin.Checked == true ? "windows" : "SQL";
            Properties.Settings.Default.id = txtUsername.Text;
            Properties.Settings.Default.password = txtPass.Text;
            Properties.Settings.Default.Save();

        }

        private void form_confi_Load(object sender, EventArgs e)
        {

         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = true;
            txtPass.ReadOnly = true;
        }

        private void rbsql_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = false;
            txtPass.ReadOnly = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
