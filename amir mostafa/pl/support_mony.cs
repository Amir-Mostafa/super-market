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
    public partial class support_mony : Form
    {
        public support_mony()
        {
            InitializeComponent();
        }

        private void support_mony_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.orders bl = new BL.orders();
            bl.update_sup_money(textBox9.Text, textBox8.Text, textBox11.Text);
            MessageBox.Show("تم تعديل قيم الدعم ");
        }
    }
}
