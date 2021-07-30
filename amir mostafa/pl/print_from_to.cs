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
    public partial class print_from_to : Form
    {
        public print_from_to()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                BL.orders bl = new BL.orders();
                int from = int.Parse(textBox1.Text);
                int to = int.Parse(textBox2.Text);
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                    for (int x = from; x <= to; x++)
                    {
                        report.rpt2_order repor = new report.rpt2_order();
                        repor.SetDataSource(bl.get_details_for_print(x));
                        report.form_report f = new report.form_report();
                        repor.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                        f.crystalReportViewer1.ReportSource = repor;

                    }
            }
            catch
            {

            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        BL.orders bl = new BL.orders();
                        int from = int.Parse(textBox1.Text);
                        int to = int.Parse(textBox2.Text);
                        PrintDialog printDialog = new PrintDialog();
                        if (printDialog.ShowDialog() == DialogResult.OK)
                            for (int x = from; x <= to; x++)
                            {
                                report.rpt2_order repor = new report.rpt2_order();
                                repor.SetDataSource(bl.get_details_for_print(x));
                                report.form_report f = new report.form_report();
                                repor.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                                f.crystalReportViewer1.ReportSource = repor;

                            }
                        this.Close();
                    }
                }
                catch
                {

                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        BL.orders bl = new BL.orders();
                        int from = int.Parse(textBox1.Text);
                        int to = int.Parse(textBox2.Text);
                        PrintDialog printDialog = new PrintDialog();
                        if (printDialog.ShowDialog() == DialogResult.OK)
                            for (int x = from; x <= to; x++)
                            {
                                report.rpt2_order repor = new report.rpt2_order();
                                repor.SetDataSource(bl.get_details_for_print(x));
                                report.form_report f = new report.form_report();
                                repor.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                                f.crystalReportViewer1.ReportSource = repor;

                            }
                        this.Close();
                    }
                }
                catch
                {

                }
            }
        }
    }
}
