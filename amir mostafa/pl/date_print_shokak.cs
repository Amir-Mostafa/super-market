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
    public partial class date_print_shokak : Form
    {
        public date_print_shokak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                report.shokak_report2 repor = new report.shokak_report2();
                int x = int .Parse(shokak.shokak_form.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                BL.products bl = new BL.products();
                repor.SetDataSource(bl.shokak_with_date(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, x));
                report.form_report f = new report.form_report();
                f.crystalReportViewer1.ReportSource = repor;
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
