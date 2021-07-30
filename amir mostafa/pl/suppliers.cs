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
    public partial class suppliers : Form
    {
        public static suppliers supply_form;
        BL.cls_supports bl = new BL.cls_supports();
        public suppliers()
        {
            InitializeComponent();
            if (supply_form == null)
                supply_form = this;
            dataGridView1.DataSource = bl.select();
        }

        private void suppliers_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new_supply f = new new_supply();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update_supply f = new update_supply();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bl.delete(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم الحذف");
                    dataGridView1.DataSource = bl.select();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = bl.searsh_supply(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
