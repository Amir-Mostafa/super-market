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
    public partial class remaind_orders : Form
    {
        public remaind_orders()
        {
            InitializeComponent();
            BL.orders bl = new BL.orders();
            dataGridView1.DataSource = bl.remaind_sell_orders();
        }

        private void remaind_orders_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BL.orders bl = new BL.orders();
                dataGridView1.DataSource = bl.searsh_remaind_sell_order(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                BL.orders bl = new BL.orders();
                if (MessageBox.Show("هل تريد فتح تفاصيل الفاتوره ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    oreer_form f = new oreer_form();
                    f.Show();
                    DataTable d1, d2, d3;
                    d1 = new DataTable();
                    d2 = new DataTable();
                    d3 = new DataTable();
                    int x = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    d1 = bl.sp_get_order_by_id(x);
                    d2 = bl.sp_get_operations_by_id(x);
                    //d3 = bl.get_borrow_peoduct(int.Parse((dataGridView1.CurrentRow.Cells[2].Value.ToString())));
                    oreer_form.order_f.textBox1.Text = d1.Rows[0]["order_id"].ToString();
                    oreer_form.order_f.dateTimePicker1.Value = DateTime.Parse(d1.Rows[0]["order_date"].ToString());
                    oreer_form.order_f.textBox23.Text = d1.Rows[0]["user_name"].ToString();
                    oreer_form.order_f.comboBox1.Text = d1.Rows[0]["clint_name"].ToString();
                    //oreer_form.order_f.textBox5.Text = d1.Rows[0]["secrit_number"].ToString();
                    oreer_form.order_f.textBox3.Text = d1.Rows[0]["sons_number"].ToString();
                    oreer_form.order_f.textBox24.Text = d1.Rows[0]["number_card"].ToString();
                    //oreer_form.order_f.textBox7.Text = d1.Rows[0]["points_bread"].ToString();
                    oreer_form.order_f.textBox4.Text = d1.Rows[0]["support"].ToString();
                    oreer_form.order_f.textBox6.Text = d1.Rows[0]["require_mony"].ToString();
                    //oreer_form.order_f.textBox11.Text = d1.Rows[0]["cards_number"].ToString();
                    oreer_form.order_f.textBox12.Text = d1.Rows[0]["tax_cars"].ToString();
                    oreer_form.order_f.textBox13.Text = d1.Rows[0]["add_support"].ToString();
                    oreer_form.order_f.textBox14.Text = d1.Rows[0]["base_support"].ToString();
                    oreer_form.order_f.txttotal.Text = d1.Rows[0]["total"].ToString();
                    oreer_form.order_f.txtpush.Text = d1.Rows[0]["remaind_support"].ToString();
                    oreer_form.order_f.txtremender.Text = d1.Rows[0]["require_mony"].ToString();                    //for (int i = 0; i < d2.Rows.Count; i++)
                    //{
                    //    try
                    //    {
                    //        oreer_form.order_f.dataGridView1.Rows.Add();
                    //        oreer_form.order_f.dataGridView1.Rows[i].Cells["product_name"].Value=  d2.Rows[i]["product_name"].ToString();
                    //        oreer_form.order_f.dataGridView1.Rows[i].Cells["product_num"].Value = d2.Rows[i]["product_number"].ToString();
                    //        oreer_form.order_f.dataGridView1.Rows[i].Cells["price"].Value = d2.Rows[i]["product_price"].ToString();
                    //        oreer_form.order_f.dataGridView1.Rows[i].Cells["total"].Value = d2.Rows[i]["total"].ToString();
                    //    }
                    //    catch { }
                    //}
                    oreer_form.order_f.g = d2;
                    oreer_form.order_f.dataGridView1.DataSource = oreer_form.order_f.g;
                    oreer_form.order_f.gg = d3;
                    oreer_form.order_f.dataGridView2.DataSource = d3;

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
