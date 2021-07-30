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
    public partial class add_new_clint : Form
    {
        public add_new_clint()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                
                
                BL.clints cl = new BL.clints();
                int x = 1;
                //int x = int.Parse(txt_sons.Text);
                int s = 0;
                //if (x > 4)
                //{
                //    s += (x - 4) * 25;
                //    s += 4 * 50;
                //}
                //else
                //    s += x * 50;
                string sup = s.ToString();

                
                txt_card.Text = "1";
                txt_national.Text = "1";
                txt_nots.Text = "1";
                txt_secrit.Text = "1";
                txt_sons.Text = "1";

                cl.New(txt_name.Text, x, txt_national.Text, txt_card.Text, txt_secrit.Text, sup, txt_nots.Text, Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("تم الاضافه");
                txt_card.Text = "";
                txt_name.Text = "";
                txt_national.Text = "";
                txt_nots.Text = "";
                txt_secrit.Text = "";
                txt_sons.Text = "";

                //BL.clints bl_c = new BL.clints();
                //DataTable h = new DataTable();
                //h = bl_c.clints_name_id();
                //oreer_form o = new oreer_form();
                //oreer_form.order_f.comboBox1.DataSource = h;
                //oreer_form.order_f.comboBox1.ValueMember = "clint_id";
                //oreer_form.order_f.comboBox1.DisplayMember = "clint_name";
               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_secrit_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_new_clint_Load(object sender, EventArgs e)
        {
            try
            {
                BL.city b = new BL.city();
                comboBox1.DataSource = b.all();
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
