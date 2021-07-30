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
    public partial class new_user : Form
    {
        public new_user()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.users bl = new BL.users();
                bl.insert(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("تم الاضافه بنجاح");
               users.users_form.dataGridView1.DataSource= bl.select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف البيانات" + ex.Message);
            }
        }

        private void new_user_Load(object sender, EventArgs e)
        {

        }
    }
}
