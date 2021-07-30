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
    public partial class show_report_sells : Form
    {
        public DataTable all = new DataTable();
        public static show_report_sells show_form_reportl;
        public show_report_sells()
        {
            InitializeComponent();
            show_form_reportl = this;
            
        }

        private void show_report_sells_Load(object sender, EventArgs e)
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
            
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 16);
            dataGridView1.RowTemplate.Height = 40;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable result = all.Clone();
                int c=0;
                for(int i=0;i<all.Rows.Count;i++)
                {
                    if (all.Rows[i][3].ToString().Contains(textBox4.Text))
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                double sum1 = 0, sum2 = 0, sum3 = 0,sum4=0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    sum1 += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                    sum2 += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString())
                        * double.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString());
                    sum3 += double.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString());
                    sum4 += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());

                }
                textBox1.Text = sum1.ToString();
                textBox2.Text = sum2.ToString();
                textBox3.Text = sum3.ToString();
                textBox5.Text = sum4.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
