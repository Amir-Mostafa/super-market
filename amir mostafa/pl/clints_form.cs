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
    public partial class clints_form : Form
    {
        BL.clints BL = new BL.clints();
        public static clints_form clints_formm;
        public clints_form()
        {
            InitializeComponent();
            clints_formm = this;
            dataGridView1.DataSource =BL.all_clints();


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

            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void clints_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tamwinDataSet.clints' table. You can move, or remove it, as needed.
          //  this.clintsTableAdapter.Fill(this.tamwinDataSet.clints);

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = BL.clint_search(textBox1.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new add_new_clint();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد حذف العميل المحدد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            try
            {
                int x=int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                BL.delete(x);
                dataGridView1.DataSource = BL.all_clints();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pl.update_clint f = new pl.update_clint();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }
    }
}
