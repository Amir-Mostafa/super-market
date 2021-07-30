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
    public partial class totak_shokak : Form
    {
        public totak_shokak()
        {
            InitializeComponent();
            BL.shok_clints bl = new BL.shok_clints();
            DataTable d = new DataTable();
            d=bl.total_shokak();
            textBox2.Text = d.Rows[0]["give"].ToString();
            textBox1.Text = d.Rows[0]["take"].ToString();
            textBox3.Text = d.Rows[0]["total"].ToString();

        }

        private void totak_shokak_Load(object sender, EventArgs e)
        {

        }
    }
}
