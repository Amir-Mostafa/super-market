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
    public partial class add_shokak : Form
    {
        public static add_shokak add_sh;
        public add_shokak()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;

            add_sh = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string d,t=textBox3.Text,g=textBox4.Text;
                 BL.shok_clints bl=new BL.shok_clints();
                 int id=int.Parse(textBox1.Text);
                d = textBox5.Text;
                if (textBox5.Text == "")
                    d = "دفعه نقديه من الحساب";
                if(textBox5.Text==""&&textBox4.Text=="")
                {
                    d = "فاتوره";
                }
                 if(textBox3.Text=="")
                     t="0";
                 if(textBox4.Text=="")
                     g="0";
                 if (g != "0")
                 {
                     BL.orders b = new BL.orders();
                     b.insert_money(id, id,g,dateTimePicker1.Value.Date);
                 }
                bl.insert_sho_operaton(id,dateTimePicker1.Value.Date, t, g, d,0);
                this.Close();
                refresh();


            }
            catch (Exception ex)
            {

                MessageBox.Show("يجب اختيار العميل" + "\n" + ex.Message);
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string d, t = textBox3.Text, g = textBox4.Text;
                    BL.shok_clints bl = new BL.shok_clints();
                    int id = int.Parse(shokak.shokak_form.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    string name = shokak.shokak_form.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    d = textBox5.Text;
                    if (textBox5.Text == "")
                        d = "دفعه نقديه من الحساب";
                    if (textBox3.Text == "")
                        t = "0";
                    if (textBox4.Text == "")
                        g = "0";
                    if (g != "0" || t != "")
                        bl.insert_sho_operaton(id, dateTimePicker1.Value.Date, t, g, d,0);
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("خطأ في البيانات!" + "\n" + ex.Message);
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string d, t = textBox3.Text, g = textBox4.Text;
                    BL.shok_clints bl = new BL.shok_clints();
                    int id = int.Parse(shokak.shokak_form.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    string name = shokak.shokak_form.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    d = textBox5.Text;
                    if (textBox5.Text == "")
                        d = "دفعه نقديه من الحساب";

                    if (textBox5.Text == "" && textBox4.Text == "")
                    {
                        d = "فاتوره";
                    }
                    if (textBox3.Text == "")
                        t = "0";
                    if (textBox4.Text == "")
                        g = "0";
                    if (g != "0" || t != "")
                        bl.insert_sho_operaton(id, dateTimePicker1.Value.Date, t, g, d, 0);
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("خطأ في البيانات!" + "\n" + ex.Message);
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string d, t = textBox3.Text, g = textBox4.Text;
                    BL.shok_clints bl = new BL.shok_clints();
                    int id = int.Parse(shokak.shokak_form.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    string name = shokak.shokak_form.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    d = textBox5.Text;
                    if (textBox5.Text == "")
                        d = "دفعه نقديه من الحساب";

                    if (textBox5.Text == "" && textBox4.Text == "")
                    {
                        d = "فاتوره";
                    }
                    if (textBox3.Text == "")
                        t = "0";
                    if (textBox4.Text == "")
                        g = "0";
                    if(g!="0"||t!="")
                        bl.insert_sho_operaton(id, dateTimePicker1.Value.Date, t, g, d, 0);
                    this.Close();

                    refresh();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("خطأ في البيانات!" + "\n" + ex.Message);
                }
            }
        }

        private void add_shokak_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) && c != 8 && c != 46 && c != '.') || (c == '.' && textBox2.Text.Contains('.')))
                e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void refresh()
        {
            try
            {

                BL.shok_clints bl = new BL.shok_clints();
                shokak.shokak_form.dataGridView2.DataSource = bl.show_operations_sho(int.Parse(shokak.shokak_form.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                double sum1 = 0, sum2 = 0, sum3 = 0, sum5 = 0, sum4 = 0, r = 0;
                for (int i = 0; i < shokak.shokak_form.dataGridView2.Rows.Count; i++)
                {
                    sum1 += double.Parse(shokak.shokak_form.dataGridView2.Rows[i].Cells[1].Value.ToString());
                    sum2 += double.Parse(shokak.shokak_form.dataGridView2.Rows[i].Cells[2].Value.ToString());
                    sum4 = double.Parse(shokak.shokak_form.dataGridView2.Rows[i].Cells[1].Value.ToString());
                    sum5 = double.Parse(shokak.shokak_form.dataGridView2.Rows[i].Cells[2].Value.ToString());

                    if (i == 0)
                        shokak.shokak_form.dataGridView2.Rows[i].Cells[3].Value = (sum4 - sum5).ToString();
                    else
                        shokak.shokak_form.dataGridView2.Rows[i].Cells[3].Value = (sum4 - sum5 + double.Parse(shokak.shokak_form.dataGridView2.Rows[i - 1].Cells[3].Value.ToString())).ToString();
                }
                textBox3.Text = sum1.ToString();
                textBox2.Text = sum2.ToString();
                sum3 = sum1 - sum2;
                textBox4.Text = (sum3.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
