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
using System.Data.SqlClient;
namespace amir_mostafa.pl
{
    public partial class all_buy_orders : Form
    {
        public DataTable d1, d2;
      public static  all_buy_orders all_buy_orders_form;
        BL.buy_order bl = new BL.buy_order();
        public all_buy_orders()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = bl.all_buy_orders();
            dataGridView1.DataSource = dt;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.Maroon;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 16);
            dataGridView1.RowTemplate.Height = 40;
        }

        private void all_buy_orders_Load(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(radioButton1.Checked)
                {
                    dataGridView1.DataSource = bl.searsh_remaind_buy_order(textBox1.Text);
                }
                else
                dataGridView1.DataSource = bl.searsh_buy__order(textBox1.Text);
            }
            catch { }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فتح بيانات الفاتوره ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                buy_order f = new buy_order();
                f.Show();
                
                d1 = new DataTable();
                d2 = new DataTable();
                d1 = bl.get_buy_order_by_id(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                try
                {
                    buy_order.form_buy_order.textBox1.Text = d1.Rows[0]["order_id"].ToString();

                    buy_order.form_buy_order.dateTimePicker1.Text = d1.Rows[0]["date_order"].ToString();
                    buy_order.form_buy_order.comboBox1.Text = d1.Rows[0]["support_name"].ToString();
                    buy_order.form_buy_order.comboBox2.Text = d1.Rows[0]["order_type"].ToString();
                    buy_order.form_buy_order.textBox5.Text = d1.Rows[0]["user_name"].ToString();
                    buy_order.form_buy_order.textBox6.Text = d1.Rows[0]["address"].ToString();
                    buy_order.form_buy_order.textBox4.Text = d1.Rows[0]["support_id"].ToString();
                    buy_order.form_buy_order.textBox7.Text = d1.Rows[0]["phone_numer"].ToString();
                    buy_order.form_buy_order.textBox8.Text = d1.Rows[0]["banq_name"].ToString();
                    buy_order.form_buy_order.textBox3.Text = d1.Rows[0]["banq_number"].ToString();
                    buy_order.form_buy_order.textBox2.Text = d1.Rows[0]["total"].ToString();

                    d2 = bl.get_operations_by_order_id(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    buy_order.form_buy_order.g = d2;
                    buy_order.form_buy_order.dataGridView2.DataSource = buy_order.form_buy_order.g;
                    this.Close();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bl.all_remaind_buy_orders();
                dataGridView1.DataSource = dt;
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bl.all_buy_orders();
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
