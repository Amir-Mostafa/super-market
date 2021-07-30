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
namespace amir_mostafa.pl
{
    public partial class restory_backup : Form
    {
        SqlConnection cn;

        public restory_backup()
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            DialogResult = f.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                textBox1.Text = f.FileName;
            }
        }

        private void restory_backup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "alter database  "+Properties.Settings.Default.database+" set offline with rollback immediate ;Restore database "+Properties.Settings.Default.database+" from disk ='"+textBox1.Text+"'";
                SqlCommand com = new SqlCommand(query, cn);
                cn.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("تم استرجاع نسخه");
                this.Close();
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
