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
    public partial class reports_form : Form
    {
        public reports_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report_sells f = new report_sells();

            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clint_report f = new clint_report();

            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report_buys f = new report_buys();

            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            storage_products f = new storage_products();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //repor_money f = new repor_money();
            totalmony f = new totalmony();

            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void reports_form_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new order_from_to();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new products_order_from_to();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new weight();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new print_from_to();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            remaind_orders f = new remaind_orders();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }
    }
}
