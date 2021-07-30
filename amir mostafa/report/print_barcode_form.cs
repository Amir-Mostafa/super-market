using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
namespace amir_mostafa.report
{
    public partial class print_barcode_form : Form
    {
    SqlConnection cn;

        public print_barcode_form()
        {
            InitializeComponent();
            string mode = Properties.Settings.Default.mode;
            if (mode == "SQL")
            {
                cn = new SqlConnection(@"data source=" + Properties.Settings.Default.server +
                    ";initial catalog=" + Properties.Settings.Default.database +
                    ";integrated security=false;User ID=" + Properties.Settings.Default.id
                    + ";Password=" + Properties.Settings.Default.password + "");
            }
            else
            {
                cn = new SqlConnection(@"data source=" + Properties.Settings.Default.server +
                    ";initial catalog=" + Properties.Settings.Default.database +
                    ";integrated security=true");
            }
        }
        ReportDocument crystal = new ReportDocument();
        private void print_barcode_form_Load(object sender, EventArgs e)
        {

         //   crystal.Load(@"C:\Users\mosta\OneDrie\Documents\Visual Studio 2013\Projects\amir mostafa\amir mostafa\report\barcode.rpt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x=0;
                string sql = "  select [product_id] as 'رقم الصنف'  ,[product_name]as'اسم الصنف',[parcode]as'باركود' ,[buy_price]as'سعر الشراء' ,[sell_price]as'سعر البيع',[profit]as'هامش الربح',[notes]as'ملاحظات' from products where products.parcode='"+textBox1.Text+"'";
                if (textBox2.Text == "")
                    x = 1;
                else
                    x = int.Parse(textBox2.Text);
                for (int i = 0; i <x-1; i++)
                {
                    sql += " union all select [product_id] as 'رقم الصنف'  ,[product_name]as'اسم الصنف',[parcode]as'باركود' ,[buy_price]as'سعر الشراء' ,[sell_price]as'سعر البيع',[profit]as'هامش الربح',[notes]as'ملاحظات' from products where products.parcode='" + textBox1.Text + "'";
                }
                SqlDataAdapter da = new SqlDataAdapter(sql,cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                BL.products bl = new BL.products();
                report.barcode repor = new report.barcode();
                repor.SetDataSource(dt);
                crystalReportViewer1.ReportSource = repor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BL.products bl = new BL.products();
                report.barcode repor = new report.barcode();
                repor.SetDataSource(bl.all_products());
                //    report.form_report f = new report.form_report();
                crystalReportViewer1.ReportSource = repor;
                // f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
