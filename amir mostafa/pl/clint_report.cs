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
    public partial class clint_report : Form
    {
        public clint_report()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            try
            {
                BL.clints bl_c = new BL.clints();
                DataTable h = new DataTable();
                h = bl_c.clints_name_id();
                comboBox1.DataSource = h;
                comboBox1.ValueMember = "clint_id";
                comboBox1.DisplayMember = "clint_name";

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void clint_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tamwinDataSet12.clintss' table. You can move, or remove it, as needed.
           // this.clintssTableAdapter1.Fill(this.tamwinDataSet12.clintss);
            // TODO: This line of code loads data into the 'tamwinDataSet8.clintss' table. You can move, or remove it, as needed.
            //this.clintssTableAdapter.Fill(this.tamwinDataSet8.clintss);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.reports bl = new BL.reports();
                show_report_sells f = new show_report_sells();
                int x = int.Parse(comboBox1.SelectedValue.ToString());
                DateTime d1 = dateTimePicker1.Value.Date;
                DateTime d2 = dateTimePicker2.Value.Date;
                show_report_sells.show_form_reportl.dataGridView1.DataSource = bl.get_operations_for_clint(x, d1, d2);
                double sum1 = 0, sum2 = 0,sum3=0;
                for (int i = 0; i < show_report_sells.show_form_reportl.dataGridView1.Rows.Count - 1; i++)
                {
                    sum1 += double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[6].Value.ToString());
                    sum2 += double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[4].Value.ToString())
                        *double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[10].Value.ToString());
                    sum3 += double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[12].Value.ToString());
                }
                show_report_sells.show_form_reportl.textBox1.Text = sum1.ToString();
                show_report_sells.show_form_reportl.textBox2.Text = sum2.ToString();
                show_report_sells.show_form_reportl.textBox3.Text = sum3.ToString();
                f.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
