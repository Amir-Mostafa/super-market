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
    public partial class delete_date : Form
    {
        public delete_date()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int clint_id = int.Parse(shokak.shokak_form.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    BL.products bl = new BL.products();
                    BL.shok_clints bll = new BL.shok_clints();
                    bl.delete_shokak(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, clint_id);
                    MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    shokak.shokak_form.dataGridView2.DataSource = bll.show_operations_sho(int.Parse(shokak.shokak_form.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    double sum1 = 0, sum2 = 0, sum3 = 0, sum5 = 0, sum4 = 0, r = 0;
                    for (int i = 0; i < shokak.shokak_form.dataGridView2.Rows.Count - 1; i++)
                    {
                        sum1 += double.Parse(shokak.shokak_form.dataGridView2.Rows[i].Cells[1].Value.ToString());
                        sum2 += double.Parse(shokak.shokak_form.dataGridView2.Rows[i].Cells[2].Value.ToString());
                        sum4 = double.Parse(shokak.shokak_form.dataGridView2.Rows[i].Cells[1].Value.ToString());
                        sum5 = double.Parse(shokak.shokak_form.dataGridView2.Rows[i].Cells[2].Value.ToString());

                        if (i == 0)
                            shokak.shokak_form.dataGridView2.Rows[i].Cells[3].Value = (sum4 - sum5).ToString();
                        else
                            shokak.shokak_form.dataGridView2.Rows[i].Cells[3].Value = (sum4 - sum5 + double.Parse(shokak.shokak_form.dataGridView2.Rows[i - 1].Cells[3].Value.ToString())).ToString();
                    }
                    shokak.shokak_form.textBox3.Text = sum1.ToString();
                    shokak.shokak_form.textBox2.Text = sum2.ToString();
                    sum3 = sum1 - sum2;
                    shokak.shokak_form.textBox4.Text = (sum3.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
