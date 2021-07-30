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
    public partial class new_supply : Form
    {
        public new_supply()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                BL.cls_supports bl = new BL.cls_supports();
                bl.insert(textBox3.Text, textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text);
                suppliers.supply_form.dataGridView1.DataSource = bl.select();
                MessageBox.Show("تم الاضافه");

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ " + ex.Message);
            }
        }

        private void new_supply_Load(object sender, EventArgs e)
        {

        }
    }
}
