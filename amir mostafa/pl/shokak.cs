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
    public partial class shokak : Form
    {
        public static shokak shokak_form;
        BL.shok_clints bl = new BL.shok_clints();
        public shokak()
        {
            InitializeComponent();
          //  dataGridView1.DataSource = bl.all_clints();
                        shokak_form = this;
            try
            {
                dataGridView1.DataSource = bl.searsh_clints("");
                this.dataGridView1.Columns["clint_id"].Visible = false;
                dataGridView1.Columns[1].HeaderCell.Value = "اسم العميل";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView2.AllowUserToAddRows = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totak_shokak f = new totak_shokak();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_new_clint f = new add_new_clint();
           // new_clint_sho f = new new_clint_sho();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void shokak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tamwinDataSet11.clintss' table. You can move, or remove it, as needed.
           // this.clintssTableAdapter1.Fill(this.tamwinDataSet11.clintss);
            // TODO: This line of code loads data into the 'tamwinDataSet10.clintss' table. You can move, or remove it, as needed.
         //   this.clintssTableAdapter.Fill(this.tamwinDataSet10.clintss);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            /*
            this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 16);
            dataGridView2.RowTemplate.Height = 40;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 14);
            dataGridView1.RowTemplate.Height = 40;
            */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                add_operation f = new add_operation();
                if (Program.isOpen(f.Text))
                {

                }
                else
                    f.Show();
                add_operation.add_form.textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                add_operation.add_form.textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = bl.show_operations_sho(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                double sum1 = 0, sum2 = 0, sum3 = 0, sum5 = 0, sum4 = 0, r = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    sum1 += double.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    sum2 += double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    sum4 = double.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    sum5 = double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());

                    if (i == 0)
                        dataGridView2.Rows[i].Cells[3].Value = (sum4 - sum5).ToString();
                    else
                        dataGridView2.Rows[i].Cells[3].Value = (sum4 - sum5 + double.Parse(dataGridView2.Rows[i - 1].Cells[3].Value.ToString())).ToString();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bl.delete_shok_operation(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
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
        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اغلاق الحساب ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string d, t = "0", g = textBox4.Text;
                    BL.shok_clints bl = new BL.shok_clints();
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    d = "دفعه نقديه من الحساب";
                    BL.orders b = new BL.orders();
                    b.insert_money(id, id, g, DateTime.Now.Date);
                    bl.insert_sho_operaton(id, DateTime.Now.Date, t, g, d, 0);
                    MessageBox.Show("تم تصفيه الحساب ");
                    refresh();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("يجب اختيار العميل" + "\n" + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           dataGridView1.DataSource= bl.searsh_clints(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            date_print_shokak f = new date_print_shokak();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                add_shokak f = new add_shokak();
                add_shokak.add_sh.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                add_shokak.add_sh.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            delete_date f = new delete_date();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = bl.show_operations_sho(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                double sum1 = 0, sum2 = 0, sum3 = 0, sum5 = 0, sum4 = 0, r = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    sum1 += double.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    sum2 += double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    sum4 = double.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    sum5 = double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());

                    if (i == 0)
                        dataGridView2.Rows[i].Cells[3].Value = (sum4 - sum5).ToString();
                    else
                        dataGridView2.Rows[i].Cells[3].Value = (sum4 - sum5 + double.Parse(dataGridView2.Rows[i - 1].Cells[3].Value.ToString())).ToString();
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

        private void button6_Click(object sender, EventArgs e)
        {
            city_report f = new city_report();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                update_shokak f = new update_shokak();
                update_shokak.update_sh.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                update_shokak.update_sh.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                update_shokak.update_sh.textBox6.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                update_shokak.update_sh.textBox3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                update_shokak.update_sh.textBox4.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();


                update_shokak.update_sh.textBox5.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();


                update_shokak.update_sh.dateTimePicker1.Value = (DateTime)(dataGridView2.CurrentRow.Cells[4].Value);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
