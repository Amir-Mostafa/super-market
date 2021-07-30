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
    public partial class form_login : Form
    {
        public static string user_name;
        
        public form_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                BL.cls_login BL= new BL.cls_login();
                dt = BL.login(textBox1.Text, textBox2.Text);
                if (dt.Rows.Count > 0)
                {

                    if (form_main.form_control.button1.Enabled == true)
                        form_main.form_control.button1.Enabled = false;
                    form_main.form_control.button9.Enabled = true;
                    form_main.form_control.button8.Enabled = true;
                    form_main.form_control.button7.Enabled = true;
                    form_main.form_control.button6.Enabled = true;
                    form_main.form_control.button5.Enabled = true;
                    form_main.form_control.button4.Enabled = true;
                    form_main.form_control.button3.Enabled = true;
                    form_main.form_control.button21.Enabled = true;
                 //   form_main.form_control.button20.Enabled = true;
                    form_main.form_control.button2.Enabled = true;
                    form_main.form_control.button19.Enabled = true;
                //    form_main.form_control.button18.Enabled = true;
               //     form_main.form_control.button17.Enabled = true;
                    form_main.form_control.button16.Enabled = true;
                    form_main.form_control.button15.Enabled = true;
            //        form_main.form_control.button14.Enabled = true;
            //        form_main.form_control.button13.Enabled = true;
                    form_main.form_control.button12.Enabled = true;
                  //form_main.form_control.button11.Enabled = true;
                    form_main.form_control.button10.Enabled = true;
                    form_main.form_control.button11.Enabled = true;

                      user_name=textBox1.Text;
                    this.Close();
                    
                }
                else
                    MessageBox.Show("كلمه المرور او اسم المستخدم خطأ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = new DataTable();
                    BL.cls_login BL = new BL.cls_login();
                    dt = BL.login(textBox1.Text, textBox2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        if (form_main.form_control.button1.Enabled == true)
                            form_main.form_control.button1.Enabled = false;
                        form_main.form_control.button9.Enabled = true;
                      form_main.form_control.button8.Enabled = true;
                        form_main.form_control.button7.Enabled = true;
                        form_main.form_control.button6.Enabled = true;
                        form_main.form_control.button5.Enabled = true;
                      form_main.form_control.button4.Enabled = true;
                        form_main.form_control.button3.Enabled = true;
                        form_main.form_control.button21.Enabled = true;
                 //       form_main.form_control.button20.Enabled = true;
                        form_main.form_control.button2.Enabled = true;
                        form_main.form_control.button19.Enabled = true;
                 //       form_main.form_control.button18.Enabled = true;
               //         form_main.form_control.button17.Enabled = true;
                        form_main.form_control.button16.Enabled = true;
                        form_main.form_control.button15.Enabled = true;
                //        form_main.form_control.button14.Enabled = true;
               //         form_main.form_control.button13.Enabled = true;
                       form_main.form_control.button12.Enabled = true;
                       // form_main.form_control.button11.Enabled = true;
                        form_main.form_control.button10.Enabled = true;
                        form_main.form_control.button11.Enabled = true;

                         user_name = textBox1.Text;
                        this.Close();
                    }
                    else
                        MessageBox.Show("كلمه المرور او اسم المستخدم خطأ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
