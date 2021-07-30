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
    public partial class buy_operations : Form
    {
        BL.buy_order bl = new BL.buy_order();
        public buy_operations()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = bl.all_buy_operations();
            dataGridView1.DataSource = dt;
        }

        private void buy_operations_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
              dataGridView1.DataSource=  bl.searsh_operations(textBox1.Text);
            }
            catch { }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
