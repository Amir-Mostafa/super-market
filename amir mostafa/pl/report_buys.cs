using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace amir_mostafa.pl
{
    public partial class report_buys : Form
    {
        
        public report_buys()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;

            dateTimePicker2.Value = DateTime.Now;
            DataTable q = new DataTable();
            BL.buy_order b = new BL.buy_order();
            q = b.all_supports_buy_order();
            comboBox1.DataSource = q;
            comboBox1.DisplayMember = "support_name";
            comboBox1.ValueMember = "support_id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BL.reports bl = new BL.reports();
                show_buy_operations f = new show_buy_operations();
                DateTime d1 = dateTimePicker1.Value.Date;
                DateTime d2 = dateTimePicker2.Value.Date;
                show_buy_operations.show_buy_form.dataGridView1.DataSource = bl.get_buy_operatoin_in_date(d1, d2);
                double sum1 = 0, sum2 = 0;
                for (int i = 0; i < show_buy_operations.show_buy_form.dataGridView1.Rows.Count - 1; i++)
                    sum1 += double.Parse(show_buy_operations.show_buy_form.dataGridView1.Rows[i].Cells[6].Value.ToString());
                show_buy_operations.show_buy_form.textBox1.Text = sum1.ToString();
                f.Show();
                this.Close();
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
                BL.reports bl = new BL.reports();
                show_buy_operations f = new show_buy_operations();
                int x = int.Parse(comboBox1.SelectedValue.ToString());
                DateTime d1 = dateTimePicker1.Value.Date;
                DateTime d2 = dateTimePicker2.Value.Date;
                show_buy_operations.show_buy_form.dataGridView1.DataSource = bl.get_buy_operatoin_in_date_for_supplay(x,d1, d2);
                double sum1 = 0, sum2 = 0;
                for (int i = 0; i < show_buy_operations.show_buy_form.dataGridView1.Rows.Count - 1; i++)
                    sum1 += double.Parse(show_buy_operations.show_buy_form.dataGridView1.Rows[i].Cells[6].Value.ToString());
                show_buy_operations.show_buy_form.textBox1.Text = sum1.ToString();
                f.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void report_buys_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tamwinDataSet9.supports' table. You can move, or remove it, as needed.
            //this.supportsTableAdapter.Fill(this.tamwinDataSet9.supports);

        }
    }
}
