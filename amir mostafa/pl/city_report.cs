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
    public partial class city_report : Form
    {
        public city_report()
        {
            InitializeComponent();
        }

        private void city_report_Load(object sender, EventArgs e)
        {
            try
            {
                BL.city b = new BL.city();
                comboBox1.DataSource = b.all();
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.city bl = new BL.city();
            
            try
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    

                    ////wwwwwwwwwww
                    //int x = Convert.ToInt32(comboBox1.SelectedValue);
                    //report.city repor = new report.city();
                    //repor.SetDataSource(bl.city_report(x));
                    //report.form_report f = new report.form_report();
                    //repor.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                    //f.crystalReportViewer1.ReportSource = repor;
                    //this.Close();
                    //show dialog
                    report.city repor = new report.city();
                    int x = Convert.ToInt32(comboBox1.SelectedValue);
                    repor.SetDataSource(bl.city_report(x));
                    report.form_report f = new report.form_report();
                    f.crystalReportViewer1.ReportSource = repor;
                    f.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
