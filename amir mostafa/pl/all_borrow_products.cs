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
    public partial class all_borrow_products : Form
    {
        BL.orders bl = new BL.orders();
        public all_borrow_products()
        {
            InitializeComponent();
           dataGridView2.DataSource= bl.sp_all_borrow();
        }

        private void all_borrow_products_Load(object sender, EventArgs e)
        {

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = bl.sp_searsh_borrow_product(textBox1.Text);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report.report_borrow r = new report.report_borrow();
            BL.orders bl = new BL.orders();
            r.SetDataSource(bl.sp_all_borrow());
            report.form_print_bprrow f = new report.form_print_bprrow();
            f.crystalReportViewer1.ReportSource = r;
            f.ShowDialog();
        }
    }
}
