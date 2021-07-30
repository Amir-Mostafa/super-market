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
    public partial class repor_money : Form
    {
        public repor_money()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.reports bl = new BL.reports();
                money_report f = new money_report();
                DataTable d = new DataTable();
                money_report.m_r_form.dataGridView1.DataSource = bl.money_repory(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                d = bl.money_repory(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date); 
                double sum = 0;
                for (int i = 0; i <d.Rows.Count; i++)
                {
                    sum += double.Parse(d.Rows[i]["المبلغ"] .ToString());
                }
                money_report.m_r_form.textBox1.Text = sum.ToString();
                f.Show();
                this.Close();
            }
            catch { }
        }

        private void repor_money_Load(object sender, EventArgs e)
        {

        }
    }
}
