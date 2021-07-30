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
    public partial class update_supply : Form
    {
        public update_supply()
        {
            InitializeComponent();
            textBox1.Text = suppliers.supply_form.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = suppliers.supply_form.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = suppliers.supply_form.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = suppliers.supply_form.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = suppliers.supply_form.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = suppliers.supply_form.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void update_supply_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.cls_supports bl = new BL.cls_supports();
                bl.update(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("تم التعديل");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
