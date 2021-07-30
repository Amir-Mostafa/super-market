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
    public partial class order_from_to : Form
    {
        public order_from_to()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) && c != 8 && c != 46 && c != '.'))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BL.reports bl = new BL.reports();
                report.collect_mony repor = new report.collect_mony();
                repor.SetDataSource(bl.collect_report(int.Parse(textBox1.Text),int.Parse(textBox2.Text)));

                report.form_report f = new report.form_report();
                f.crystalReportViewer1.ReportSource = repor;
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        BL.reports bl = new BL.reports();
                        report.collect_mony repor = new report.collect_mony();
                        repor.SetDataSource(bl.collect_report(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));

                        report.form_report f = new report.form_report();
                        f.crystalReportViewer1.ReportSource = repor;
                        f.ShowDialog();
                        this.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                        BL.reports bl = new BL.reports();
                        report.collect_mony repor = new report.collect_mony();
                        repor.SetDataSource(bl.collect_report(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));

                        report.form_report f = new report.form_report();
                        f.crystalReportViewer1.ReportSource = repor;
                        f.ShowDialog();
                        this.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
