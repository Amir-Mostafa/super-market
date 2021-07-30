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
    public partial class storage_products : Form
    {
        DataTable all = new DataTable();
        BL.products bl1 = new BL.products();
        BL.reports bl2 = new BL.reports();
        

        public storage_products()
        {
            InitializeComponent();
            try
            {
                DataTable dt = new System.Data.DataTable();
                DataTable dt2 = new System.Data.DataTable();
                DataTable dt3 = new System.Data.DataTable();
                DataTable dt4 = new System.Data.DataTable();

                all.Columns.Add("اسم الصنف");
                all.Columns.Add("المشتريات");
                all.Columns.Add("المبيعات");
                all.Columns.Add("المتوفر في المخزن");
                all.Columns.Add("الاجمالي");
               dt=bl1.all_products();
               double totalPrice = 0;
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   int x=int.Parse(dt.Rows[i]["رقم الصنف"].ToString());
                   string s = dt.Rows[i]["اسم الصنف"].ToString();
                   double price = double.Parse(dt.Rows[i]["سعر الشراء"].ToString());
                   dt2 = bl2.all_products_by_id(x);
                   dt3 = bl2.all_products_by_id_from_borrow(x);
                   dt4 = bl2.all_products_from_buy_operations(x);
                   double sum1=0,sum2=0,sum3=0,sum4=0;
                   for (int j = 0; j < dt2.Rows.Count; j++)
                       sum1 += double.Parse(dt2.Rows[j]["product_number"].ToString());
                   for (int j = 0; j < dt3.Rows.Count; j++)
                       sum2 += double.Parse(dt3.Rows[j]["product_number"].ToString());
                   for (int j = 0; j < dt4.Rows.Count; j++)
                       sum3 += double.Parse(dt4.Rows[j]["product_number"].ToString());
                   sum4 = sum1 + sum2;
                   //dataGridView1.Rows.Add();

                   DataRow r = all.NewRow();
                   r[0] = s;
                   r[1] = sum3.ToString(); ;
                   r[2] = sum4.ToString();
                   r[3] = (sum3 - sum4).ToString();
                   r[4] = ((sum3 - sum4) * price).ToString();
                   all.Rows.Add(r);
                   //dataGridView1.Rows[i].Cells[0].Value = s;
                   //dataGridView1.Rows[i].Cells[1].Value = sum3.ToString();
                   //dataGridView1.Rows[i].Cells[2].Value = sum4.ToString();
                   //dataGridView1.Rows[i].Cells[3].Value = (sum3-sum4).ToString();
                   //dataGridView1.Rows[i].Cells[4].Value = ((sum3 - sum4)*price).ToString();
                   totalPrice += ((sum3 - sum4) * price);
                   
               }
               textBox1.Text = totalPrice.ToString();
               dataGridView1.DataSource = all;
               
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void storage_products_Load(object sender, EventArgs e)
        {
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable result = all.Clone();

                int c = 0;


                for (int i = 0; i < all.Rows.Count; i++)
                {
                    if (all.Rows[i][0].ToString().Contains(textBox4.Text))
                    {
                        DataRow r = result.NewRow();
                        r.ItemArray = all.Rows[i].ItemArray;
                        result.Rows.Add(r);
                    }
                }
                if (textBox4.Text == "")
                {
                    dataGridView1.DataSource = all;
                }
                else
                    dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
