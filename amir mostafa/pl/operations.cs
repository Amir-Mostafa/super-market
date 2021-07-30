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
    public partial class operations : Form
    {
        BL.orders bl = new BL.orders();
        public operations()
        {
            InitializeComponent();
            dataGridView1.DataSource= bl.sp_all_operations();
        }

        private void operations_Load(object sender, EventArgs e)
        {
            
               dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= bl.searsh_in_operations(textBox1.Text);
        }
    }
}
