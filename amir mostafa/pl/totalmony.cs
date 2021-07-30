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
    public partial class totalmony : Form
    {
        public totalmony()
        {
            InitializeComponent();
        }

        private void totalmony_Load(object sender, EventArgs e)
        {
            try
            {
                BL.reports bl = new BL.reports();
                DataTable d1 = bl.calc_money();
                DataTable d2 = bl.calc_buy();
                
                total_sell.Text = "0";
                total_paid_s.Text = "0";
                total_remaind_s.Text = "0";
                if (d1.Rows[0]["total orders"].ToString() != "")
                total_sell.Text = d1.Rows[0]["total orders"].ToString();
                if (d1.Rows[0]["total money"].ToString()!="")
                total_paid_s.Text = d1.Rows[0]["total money"].ToString();
                if (d1.Rows[0]["total remainder"].ToString()!="")
                total_remaind_s.Text = d1.Rows[0]["total remainder"].ToString();
                
                total_buy.Text = "0";
                total_paid_b.Text = "0";
                total_remaind_b.Text = "0";
                if (d2.Rows[0]["total buy"].ToString()!="")
                total_buy.Text = d2.Rows[0]["total buy"].ToString();
                if (d2.Rows[0]["total paid"].ToString()!="")
                total_paid_b.Text = d2.Rows[0]["total paid"].ToString();
                if (d2.Rows[0]["total remaind"].ToString()!="")
                total_remaind_b.Text = d2.Rows[0]["total remaind"].ToString();

                total.Text = (double.Parse(total_paid_s.Text) - double.Parse(total_paid_b.Text)).ToString();
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
