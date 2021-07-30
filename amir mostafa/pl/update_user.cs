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
    public partial class update_user : Form
    {
        public update_user()
        {
            InitializeComponent();
            try
            {
                textBox1.Text = users.users_form.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = users.users_form.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = users.users_form.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.users bl = new BL.users();
                bl.update(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("تم التحديث بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف البيانات " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
