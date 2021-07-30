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
    public partial class update_shokak : Form
    {
        public static update_shokak update_sh;
        public update_shokak()
        {
            InitializeComponent();
            update_sh = this;
        }

        private void update_shokak_Load(object sender, EventArgs e)
        {

        }
        public void refresh()
        {
            try
            {

                BL.shok_clints bl = new BL.shok_clints();
                shokak.shokak_form.dataGridView2.DataSource = bl.show_operations_sho(int.Parse(shokak.shokak_form.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                double sum1 = 0, sum2 = 0, sum3 = 0, sum5 = 0, sum4 = 0, r = 0;
                for (int i = 0; i < shokak.shokak_form.dataGridView2.Rows.Count; i++)
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
                textBox3.Text = sum1.ToString();
                textBox2.Text = sum2.ToString();
                sum3 = sum1 - sum2;
                textBox4.Text = (sum3.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string d, t = textBox3.Text, g = textBox4.Text;
                    BL.shok_clints bl = new BL.shok_clints();
                    int id = int.Parse(textBox6.Text);
                    d = textBox5.Text;
                    if (textBox5.Text == "")
                        d = "دفعه نقديه من الحساب";
                    if (textBox3.Text == "")
                        t = "0";
                    if (textBox4.Text == "")
                        g = "0";
                    if (g != "0")
                    {
                        BL.orders b = new BL.orders();
                        b.insert_money(id, id, g, dateTimePicker1.Value.Date);
                    }
                    bl.upadte_sho_operaton(id,int.Parse(textBox1.Text), dateTimePicker1.Value.Date, t, g, d);
                    this.Close();
                    refresh();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("يجب اختيار العميل" + "\n" + ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
