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
    public partial class update_clint : Form
    {
        public update_clint()
        {
            InitializeComponent();
           textBox1.Text= clints_form.clints_formm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
           txt_name.Text = clints_form.clints_formm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
           txt_sons.Text = clints_form.clints_formm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
           txt_card.Text = clints_form.clints_formm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
           txt_national.Text = clints_form.clints_formm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
           txt_secrit.Text = clints_form.clints_formm.dataGridView1.CurrentRow.Cells[5].Value.ToString();
           txt_sup.Text = clints_form.clints_formm.dataGridView1.CurrentRow.Cells[6].Value.ToString();
           txt_nots.Text = clints_form.clints_formm.dataGridView1.CurrentRow.Cells[7].Value.ToString();
           
           comboBox1.SelectedValue = int.Parse(clints_form.clints_formm.dataGridView1.CurrentRow.Cells[8].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.clints bl = new BL.clints();

                txt_card.Text = "1";
                txt_national.Text = "1";
                txt_nots.Text = "1";
                txt_secrit.Text = "1";
                txt_sons.Text = "1";
                bl.update(int.Parse(textBox1.Text), txt_name.Text, int.Parse(txt_sons.Text), txt_card.Text, txt_national.Text, txt_secrit.Text, txt_sup.Text, txt_nots.Text,Convert.ToInt32(comboBox1.SelectedValue));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_clint_Load(object sender, EventArgs e)
        {
            try
            {
                BL.city b = new BL.city();
                comboBox1.DataSource = b.all();
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedValue = int.Parse(clints_form.clints_formm.dataGridView1.CurrentRow.Cells[8].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
