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
    public partial class borrow_product : Form
    {
        BL.orders bl = new BL.orders();
        BL.clints c = new BL.clints();
        DataTable t = new DataTable();
        public borrow_product()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void borrow_product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tamwinDataSet6.clintss' table. You can move, or remove it, as needed.
            //this.clintssTableAdapter1.Fill(this.tamwinDataSet6.clintss);
            // TODO: This line of code loads data into the 'tamwinDataSet5.clintss' table. You can move, or remove it, as needed.
            //this.clintssTableAdapter.Fill(this.tamwinDataSet5.clintss);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bl.sp_insert_borrow_product(Convert.ToInt32(comboBox1.SelectedValue), textBox10.Text, textBox1.Text, textBox2.Text, dateTimePicker1.Value);
                MessageBox.Show("تم الاضافه");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف البيانات");
            }

        }
    }
}
