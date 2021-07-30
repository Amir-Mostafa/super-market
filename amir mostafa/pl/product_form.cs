using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace amir_mostafa.pl
{
  
    public partial class product_form : Form
    {
        BL.products bl = new BL.products();
        BindingManagerBase bmb;
        public product_form()
        {
            InitializeComponent();
                DataTable dt=new DataTable();
                
            dt = bl.all_products();
            dataGridView1.DataSource=dt;


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            
            /*
            pro_id.DataBindings.Add("text", dt, "رقم الصنف");
            pro_name.DataBindings.Add("text", dt, "اسم الصنف");
            pro_notes.DataBindings.Add("text", dt, "ملاحظات");
                pro_parcode.DataBindings.Add("text", dt, "باركود");
               pro_sell.DataBindings.Add("text", dt, "سعر البيع");
               buy_price.DataBindings.Add("text", dt, "سعر الشراء");
               bmb = this.BindingContext[dt];
               label6.Text = (bmb.Position+1) + " / " + bmb.Count;
             */

        }

        private void product_form_Load(object sender, EventArgs e)
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
            pro_id.Text = "";
            pro_name.Text = "";
            pro_notes.Text = "";
            pro_parcode.Text = "";
            pro_sell.Text = "";
            buy_price.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBox1.Text == "")
                    textBox1.Text = "0";
                double x = double.Parse(buy_price.Text);
                double y = double.Parse(pro_sell.Text);
                string s = (y - x).ToString();
                DataTable h = new DataTable();
                h=bl.get_parcode();
                decimal v=0;
                string vv="";
                if (h.Rows.Count > 0)

                {
                    v = decimal.Parse(h.Rows[0]["barcode"].ToString());
                    v++;
                    bl.insert_barcode(v);
                }
                else
                {
                    v = 10000000000;
                    bl.insert_barcode(v);
                }

                bl.insert(pro_name.Text, v.ToString(), buy_price.Text, pro_sell.Text, s, pro_notes.Text, double.Parse(textBox1.Text));
                dataGridView1.DataSource = bl.all_products();
                pro_id.Text = "";
                pro_name.Text = "";
                pro_notes.Text = "";
                pro_parcode.Text = "";
                pro_sell.Text = "";
                buy_price.Text = "";
                textBox1.Text = "";
                pro_name.Focus();
                try
                {
                    DataTable t = new DataTable();
                    BL.orders o = new BL.orders();
                    t = o.sp_get_products_name();
                    oreer_form.order_f.comboBox2.DataSource = t;
                    oreer_form.order_f.comboBox2.DisplayMember = "product_name";
                    oreer_form.order_f.comboBox2.ValueMember = "product_id";
                }
                catch
                { }
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطأ في البيانات"+ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = bl.searsh_products(textBox3.Text);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                    textBox1.Text = "";
                int id = int.Parse(pro_id.Text);
                double x = double.Parse(pro_sell.Text);
                double y = double.Parse(buy_price.Text);
                string s = (x - y).ToString();
                if (MessageBox.Show("هل تريد تحديث البيانات", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bl.update(id, pro_name.Text, decimal.Parse(pro_parcode.Text), pro_sell.Text, buy_price.Text, s, pro_notes.Text,float.Parse(textBox1.Text));
                    MessageBox.Show("تم تحديث البيانات");
                    dataGridView1.DataSource = bl.all_products();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطأ في البيانات" +ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("هل تريد حذف المنتج ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bl.delete(x);
                    MessageBox.Show("نم الحذف بنجاح");
                    dataGridView1.DataSource = bl.all_products();
                }
                
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            label6.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            label6.Text = (bmb.Position+1) + " / " + bmb.Count;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bmb.Position += 1;
            label6.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            label6.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pro_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                pro_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                pro_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                pro_parcode.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                buy_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pro_sell.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                pro_notes.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
                
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                try
                {
                    if (textBox1.Text == "")
                        textBox1.Text = "0";
                    double x = double.Parse(buy_price.Text);
                    double y = double.Parse(pro_sell.Text);
                    string s = (y - x).ToString();
                    DataTable h = new DataTable();
                    h = bl.get_parcode();
                    decimal v = 0;
                    string vv = "";
                    if (h.Rows.Count > 0)
                    {
                        v = decimal.Parse(h.Rows[0]["barcode"].ToString());
                        v++;
                        bl.insert_barcode(v);
                    }
                    else
                    {
                        v = 10000000000;
                        bl.insert_barcode(v);
                    }

                    bl.insert(pro_name.Text, v.ToString(), buy_price.Text, pro_sell.Text, s, pro_notes.Text, float.Parse(textBox1.Text));
                    MessageBox.Show("تم الاضاقه");
                    dataGridView1.DataSource = bl.all_products();
                    pro_id.Text = "";
                    pro_name.Text = "";
                    pro_notes.Text = "";
                    pro_parcode.Text = "";
                    pro_sell.Text = "";
                    buy_price.Text = "";
                    textBox1.Text = "";
                    pro_name.Focus();
                    DataTable t = new DataTable();
                    BL.orders o = new BL.orders();
                    t = o.sp_get_products_name();
                    oreer_form.order_f.comboBox2.DataSource = t;
                    oreer_form.order_f.comboBox2.DisplayMember = "product_name";
                    oreer_form.order_f.comboBox2.ValueMember = "product_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في البيانات" + ex.Message);
                }
            }
        }

        private void pro_notes_Leave(object sender, EventArgs e)
        {
            button7.Focus();
        }
    }
}
