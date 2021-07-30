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
    
    public partial class form_main : Form
    {
        public static form_main form_control;

        public form_main()
        {
            InitializeComponent();
       //  pictureBox1.Image = Image.FromFile("C:\\Users\\mosta\\OneDrive\\Documents\\Visual Studio 2013\\Projects\\amir mostafa\\logo.jpg");
            //
            string s = Properties.Settings.Default.image;
            if(System.IO.File.Exists(Properties.Settings.Default.image))
            {
                pictureBox1.Image = Image.FromFile(Properties.Settings.Default.image);
            }
            form_control = this;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
        //    button4.Enabled = false;
            button3.Enabled = false;
            button21.Enabled = false;
  //          button20.Enabled = false;
            button2.Enabled = false;
            button19.Enabled = false;
      //      button18.Enabled = false;
      //      button17.Enabled = false;
            button16.Enabled = false;
            button15.Enabled = false;
    //        button14.Enabled = false;
   //         button13.Enabled = false;
           button12.Enabled = false;
           // button11.Enabled = false;
            button10.Enabled = false;
            button4.Enabled = false;
            button11.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new form_login();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void form_main_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new clints_form();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            product_form f = new product_form();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void تغييرالخلفيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult d = op.ShowDialog();
            if (d==DialogResult.OK)
            {
                Properties.Settings.Default.image = op.FileName;
                Properties.Settings.Default.Save();
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            users f = new users();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            suppliers f = new suppliers();

            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            all_orders f = new all_orders();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            pl.oreer_form f = new oreer_form();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
            
        }
        public bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == form.Name)
                    return true;
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pl.operations f = new pl.operations();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            all_borrow_products f = new all_borrow_products();

            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buy_order f = new buy_order();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            all_buy_orders f = new all_buy_orders();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buy_operations f = new buy_operations();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            shokak f = new shokak();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            reports_form f = new reports_form();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            report.print_barcode_form f = new report.print_barcode_form();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            backup_form f = new backup_form();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void اعداداتالاتصالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_confi f = new form_confi();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            city f = new city();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
 
    }
}
