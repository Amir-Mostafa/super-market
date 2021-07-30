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
    public partial class weight : Form
    {
        BL.orders bl = new BL.orders();
        public weight()
        {
            InitializeComponent();
        }

        private void weight_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x;
                if(textBox1.Text!=""&&textBox2.Text!="")
                {
                    DataTable d= bl.calc_weight(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    double sum = 0;
                    for(int i=0;i<d.Rows.Count;i++)
                    {
                        if (d.Rows[i]["weight"].ToString()!="")
                        sum += double.Parse(d.Rows[i]["weight"].ToString());
                    }
                    textBox3.Text = sum.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) && c != 8 && c != 46 && c != '.') || (c == '.' && textBox2.Text.Contains('.')))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) && c != 8 && c != 46 && c != '.') || (c == '.' && textBox2.Text.Contains('.')))
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x;
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    DataTable d = bl.calc_weight(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    double sum = 0;
                    for (int i = 0; i < d.Rows.Count; i++)
                    {
                        if (d.Rows[i]["weight"].ToString() != "")
                            sum += double.Parse(d.Rows[i]["weight"].ToString());
                    }
                    textBox3.Text = sum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
