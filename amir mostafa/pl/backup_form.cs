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
    public partial class backup_form : Form
    {
        public backup_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            take_path f = new take_path();
            this.Close();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            restory_backup f = new restory_backup();
            this.Close();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void backup_form_Load(object sender, EventArgs e)
        {

        }
    }
}
