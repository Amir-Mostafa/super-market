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
    public partial class report_sells : Form
    {
        
        BL.reports bl = new BL.reports();
        public report_sells()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;

            dateTimePicker2.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                show_report_sells f = new show_report_sells();
                

                DataTable d = new DataTable();
                DateTime d1=dateTimePicker1.Value;
                DateTime d2=dateTimePicker2.Value;
                show_report_sells.show_form_reportl.dataGridView1.DataSource = bl.report_sell(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);

                show_report_sells.show_form_reportl.all = bl.report_sell(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);

                double sum1 = 0, sum2 = 0,sum3=0,sum4=0;
                for (int i = 0; i < show_report_sells.show_form_reportl.dataGridView1.Rows.Count - 1; i++)
                {
                    sum1 += double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[6].Value.ToString());
                    sum2 += double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[4].Value.ToString())
                        *double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[10].Value.ToString());
                    sum3 += double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[12].Value.ToString());
                    sum4 += double.Parse(show_report_sells.show_form_reportl.dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                show_report_sells.show_form_reportl.textBox1.Text = sum1.ToString();
                show_report_sells.show_form_reportl.textBox2.Text = sum2.ToString();
                show_report_sells.show_form_reportl.textBox3.Text = sum3.ToString();
                show_report_sells.show_form_reportl.textBox5.Text = sum4.ToString();
                this.Close();
                f.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void report_sells_Load(object sender, EventArgs e)
        {

        }
    }
}
