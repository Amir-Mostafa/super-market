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
    public partial class users : Form
    {
        public static users users_form;
        BL.users bl = new BL.users();
        public users()
        {
            InitializeComponent();
            if (users_form == null)
                users_form = this;
            dataGridView1.DataSource = bl.select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void users_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.Tan;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_user f = new new_user();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_user f = new update_user();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العنصر المحدد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bl.delete(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource= bl.select();
                    MessageBox.Show("تم الحذف");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ" + ex.Message);
                }
            }
        }
    }
}
