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
    
    public partial class add_operation : Form
    {
        BL.shok_clints bl = new BL.shok_clints();
        public static add_operation add_form;
        public add_operation()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            if (add_form == null)
                add_form = this;
        }

        private void add_operation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                    textBox1.Text = "دفعه نقديه من الحساب";
                bl.insert_sho_operaton(int.Parse(textBox2.Text), dateTimePicker1.Value, textBox7.Text, textBox4.Text, textBox1.Text,0);
                MessageBox.Show("تم");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
