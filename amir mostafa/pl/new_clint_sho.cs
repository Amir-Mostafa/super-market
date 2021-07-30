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
    public partial class new_clint_sho : Form
    {
        BL.shok_clints bl = new BL.shok_clints();
        public new_clint_sho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bl.new_clint(textBox1.Text);
                MessageBox.Show("تم الاضافه ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void new_clint_sho_Load(object sender, EventArgs e)
        {

        }
    }
}
