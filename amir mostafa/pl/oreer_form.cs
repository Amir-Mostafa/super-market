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
    public partial class oreer_form : Form
    {
        public static oreer_form order_f;
        bool t = false;
        string s;
         public DataTable g = new DataTable();
         public DataTable gg = new DataTable();
        public oreer_form()
        {

          
            InitializeComponent();
          dateTimePicker1.Value = DateTime.Now;
          BL.orders bl = new BL.orders();
          DataTable t = new DataTable();
          t = bl.sp_get_products_name();
          comboBox2.DataSource = t;
          comboBox2.DisplayMember = "product_name";
          comboBox2.ValueMember = "product_id";
            try
            {
                


                BL.clints bl_c = new BL.clints();
                DataTable h = new DataTable();
                h = bl_c.clints_name_id();
                comboBox1.DataSource = h;
                comboBox1.ValueMember = "clint_id";
                comboBox1.DisplayMember = "clint_name";
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            /*
            BL.clints bll = new BL.clints();
            DataTable tt = new DataTable();
            tt = bll.all_clints();
            comboBox1.DataSource = tt;
            comboBox1.DisplayMember =  "[اسم العميل]";
            comboBox1.ValueMember = "[رقم العميل]";


            */



            g.Columns.Add("رقم الصنف");
            g.Columns.Add("اسم الصنف");
            g.Columns.Add("عدد الصنف");
            g.Columns.Add("سعر الوحده");
            g.Columns.Add("الاجمالي");
            g.Columns.Add("ملاحاظات");
            g.Columns.Add("الوزن");
            dataGridView1.DataSource = g;
            dataGridView1.Columns["رقم الصنف"].Visible = false;

            gg.Columns.Add("رقم الصنف");
            gg.Columns.Add("اسم الصنف");
            gg.Columns.Add("عدد الصنف");
            gg.Columns.Add("سعر الوحده");
            gg.Columns.Add("الاجمالي");
            gg.Columns.Add("اسم المستلم");
            gg.Columns.Add("التاريخ");
            dataGridView2.DataSource = gg;
            try
            {
                DataTable dd = new DataTable();
                dd = bl.max_id();
                int y = dd.Rows.Count;
                if (dd.Rows.Count > 0)
                {
                    int x = int.Parse(dd.Rows[0]["order_id"].ToString()) + 1;
                    textBox1.Text = x.ToString();
                }
            }
            catch (Exception ex)
            {
                int x = 1;
                textBox1.Text = x.ToString();
            }
            DataTable dt1 = new DataTable();
           
            dt1 = bl.select_supp();
            if (dt1.Rows.Count > 0)
            {
                textBox14.Text = dt1.Rows[0]["base_support"].ToString();
                textBox13.Text = dt1.Rows[0]["add_support"].ToString();
                textBox12.Text = dt1.Rows[0]["tax_card"].ToString();
            }
            order_f = this;
            textBox23.Text = form_login.user_name;
            //textBox2.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            comboBox2.SelectedIndex = -1;

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns["رقم الصنف"].Visible = false;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void oreer_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tamwinDataSet4.clintss' table. You can move, or remove it, as needed.
           // this.clintssTableAdapter.Fill(this.tamwinDataSet4.clintss);
            // TODO: This line of code loads data into the 'tamwinDataSet3.products' table. You can move, or remove it, as needed.
           // this.productsTableAdapter2.Fill(this.tamwinDataSet3.products);
            // TODO: This line of code loads data into the 'tamwinDataSet2.products' table. You can move, or remove it, as needed.
           // this.productsTableAdapter1.Fill(this.tamwinDataSet2.products);
            // TODO: This line of code loads data into the 'tamwinDataSet1.products' table. You can move, or remove it, as needed.
           // this.productsTableAdapter.Fill(this.tamwinDataSet1.products);
            
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.Maroon;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 16);
            dataGridView1.RowTemplate.Height = 40;



            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.Maroon;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan;


            //try
            //{
            //    BL.shok_clints bl = new BL.shok_clints();
            //    DataTable dt = new DataTable();
            //    // MessageBox.Show(comboBox1.Text);

            //    if (comboBox1.Text != "System.Data.DataRowView")
            //    {
            //        dt = bl.show_operations_sho(Convert.ToInt32(comboBox1.SelectedValue));
            //        double sum1 = 0, sum2 = 0, sum3 = 0, sum5 = 0, sum4 = 0, r = 0;
            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            sum1 += double.Parse(dt.Rows[i][1].ToString());
            //            sum2 += double.Parse(dt.Rows[i][2].ToString());

            //        }
            //        //textBox3.Text = sum1.ToString();
            //        //textBox2.Text = sum2.ToString();
            //        sum3 = sum1 - sum2;
                    
            //        if (txttotal.Text == "")
            //            txttotal.Text = "0";
            //        sum3 -= double.Parse(txttotal.Text);
            //        lastMoney.Text = (sum3.ToString());
            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    // comboBox1.Text = "";
            //}   
            //get_last_money();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            try
            {

                BL.orders bl = new BL.orders();
                DataTable dt = new DataTable();

                dt = bl.select(comboBox1.Text);
                if (dt.Rows.Count > 0)
                {
                    textBox3.Text = dt.Rows[0]["sons_number"].ToString();
                    textBox5.Text = dt.Rows[0]["secrit_number"].ToString();
                    textBox24.Text = dt.Rows[0]["number_card"].ToString();
                    t = true;
                }

                comboBox2.Focus();
            }
            catch (Exception ex)
            {
                return;
            }
            try
            {
                if (textBox3.Text != "")
                {
                    double x = double.Parse(textBox3.Text);
                    if (x > 4)
                    {
                        double f = (x - 4) * int.Parse(textBox13.Text) + (4 * int.Parse(textBox14.Text)) - (int.Parse(textBox12.Text)) + (int.Parse(textBox7.Text));
                        textBox4.Text = (f).ToString();
                    }
                    else
                    {
                        double f = x * int.Parse(textBox14.Text) - int.Parse(textBox12.Text) + int.Parse(textBox7.Text);
                        textBox4.Text = (f).ToString();
                    }
                }
                BL.orders bl = new BL.orders();
                DataTable q = new DataTable();
                gg = bl.get_borrow_peoduct(Convert.ToInt32(comboBox1.SelectedValue));
               dataGridView2.DataSource = gg;
                double sum=0;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    sum += double.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                }
                textBox19.Text = sum.ToString();
            }
            catch(Exception ex)
            { return; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
             
            try
            {
              
                BL.orders bl=new BL.orders();
                DataTable dt = new DataTable();

               dt= bl.select(comboBox1.Text);
                if(dt.Rows.Count>0)
                {
               textBox3.Text=dt.Rows[0]["sons_number"].ToString();
                textBox5.Text = dt.Rows[0]["secrit_number"].ToString();
                textBox24.Text = dt.Rows[0]["number_card"].ToString();
                t = true;
                }


            }
            catch(Exception ex)
            {
                return;
            }

           // get_last_money();
        }

        //public void  get_last_money()
        //{
        //     try
        //    {
        //        BL.shok_clints bl = new BL.shok_clints();
        //        DataTable dt=new DataTable();
        //       // MessageBox.Show(comboBox1.Text);

        //        if (comboBox1.Text != "System.Data.DataRowView")
        //        {
        //            dt = bl.show_operations_sho(Convert.ToInt32(comboBox1.SelectedValue));
        //            double sum1 = 0, sum2 = 0, sum3 = 0, sum5 = 0, sum4 = 0, r = 0;
        //            for (int i = 0; i < dt.Rows.Count; i++)
        //            {
        //                sum1 += double.Parse(dt.Rows[i][1].ToString());
        //                sum2 += double.Parse(dt.Rows[i][2].ToString());

        //            }
        //            //textBox3.Text = sum1.ToString();
        //            //textBox2.Text = sum2.ToString();
        //            sum3 = sum1 - sum2;
        //            if (txttotal.Text == "")
        //                txttotal.Text = "0";
        //            if(sum3!=0)
        //            sum3 -= double.Parse(txttotal.Text);
        //            sum3 += double.Parse(txtpush.Text);
        //           // textBox29.Text = (sum3.ToString());
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //       // comboBox1.Text = "";
        //    }   

        //}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (textBox3.Text == "")
            //        textBox3.Text = "0";
            //        double x = double.Parse(textBox3.Text);
            //        if (x > 4)
            //        {
            //            double f = (x - 4) * double.Parse(textBox13.Text) + (4 * double.Parse(textBox14.Text)) - (double.Parse(textBox12.Text)) + (double.Parse(textBox7.Text));
            //            textBox4.Text = (f).ToString();
            //            textBox10.Text = (f - (double.Parse(textBox15.Text))).ToString();
            //        }
            //        else
            //        {
            //            double f = x * double.Parse(textBox14.Text) - double.Parse(textBox12.Text) + double.Parse(textBox7.Text);
            //            textBox4.Text = (f).ToString();
            //            textBox10.Text = (f - (double.Parse(textBox15.Text))).ToString();
            //        }
            //}
            //catch (Exception ex)
            //{ return; }
            try
            {
                if (textBox7.Text == "")
                    textBox7.Text = "0";
                if (textBox3.Text == "")
                    textBox3.Text = "0";
                double x = double.Parse(textBox3.Text);
                if (x > 4)
                {
                    double f = (x - 4) * double.Parse(textBox13.Text) + (4 * double.Parse(textBox14.Text)) - (double.Parse(textBox12.Text)) + (double.Parse(textBox7.Text));
                    textBox4.Text = (f).ToString();
                    textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                }
                else
                {
                    double f = x * double.Parse(textBox14.Text) - double.Parse(textBox12.Text) + double.Parse(textBox7.Text);
                    textBox4.Text = (f).ToString();
                    textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                }
                if (textBox8.Text == "")
                    textBox8.Text = "0";
                double y = double.Parse(textBox8.Text) * double.Parse(textBox13.Text);
                double z = double.Parse(textBox4.Text);
                double d = double.Parse(textBox9.Text) * double.Parse(textBox14.Text);
                //    double g = double.Parse(textBox7.Text);
                textBox4.Text = (z + y + d).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            support_mony f = new support_mony();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (textBox7.Text == "")
            //        textBox7.Text = "0";
            //    double z = double.Parse(textBox7.Text);
            //    if (textBox3.Text != "")
            //    {
            //        double x = double.Parse(textBox3.Text);
            //        if (x > 4)
            //        {
            //            double f = (x - 4) * double.Parse(textBox13.Text) + (4 * double.Parse(textBox14.Text)) - (double.Parse(textBox12.Text)) + (double.Parse(textBox7.Text));
            //            textBox4.Text = (f).ToString();
            //            textBox10.Text = (f - (double.Parse(textBox15.Text))).ToString();
            //        }
            //        else
            //        {
            //            double f = x * double.Parse(textBox14.Text) - double.Parse(textBox12.Text) + double.Parse(textBox7.Text);
            //            textBox4.Text = (f).ToString();
            //            textBox10.Text = (f - (double.Parse(textBox15.Text))).ToString();
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{ return; }
            try
            {
                if (textBox7.Text == "")
                    textBox7.Text = "0";
                if (textBox3.Text == "")
                    textBox3.Text = "0";
                double x = double.Parse(textBox3.Text);
                if (x > 4)
                {
                    double f = (x - 4) * double.Parse(textBox13.Text) + (4 * double.Parse(textBox14.Text)) - (double.Parse(textBox12.Text)) + (double.Parse(textBox7.Text));
                    textBox4.Text = (f).ToString();
                    textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                }
                else
                {
                    double f = x * double.Parse(textBox14.Text) - double.Parse(textBox12.Text) + double.Parse(textBox7.Text);
                    textBox4.Text = (f).ToString();
                    textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                }
                if (textBox8.Text == "")
                    textBox8.Text = "0";
                double y = double.Parse(textBox8.Text) * double.Parse(textBox13.Text);
                double z = double.Parse(textBox4.Text);
                double d = double.Parse(textBox9.Text) * double.Parse(textBox14.Text);
            //    double g = double.Parse(textBox7.Text);
                textBox4.Text =  (z + y + d).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox10.Text = (double.Parse(textBox4.Text) - double.Parse(txttotal.Text)).ToString();
            }
            catch { }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox4.Text);
                double t = double.Parse(txttotal.Text);
                double s = x - t;
                textBox10.Text = s.ToString();
            }
            catch { }
            calcMoeny();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "")
                {
                    double x = double.Parse(textBox3.Text);
                    if (x > 4)
                    {
                        double f = (x - 4) * double.Parse(textBox13.Text) + (4 * double.Parse(textBox14.Text)) - (double.Parse(textBox12.Text)) + (double.Parse(textBox7.Text));
                        textBox4.Text = (f).ToString();
                        textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                    }
                    else
                    {
                        double f = x * double.Parse(textBox14.Text) - double.Parse(textBox12.Text) + double.Parse(textBox7.Text);
                        textBox4.Text = (f).ToString();
                        textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                    }
                }
            }
            catch (Exception ex)
            { return; }
        }


         private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
          {
            /*
             a:
            ComboBox box = e.Control as ComboBox;
                if (box != null)
                {
                    try
                    {
                        box.DropDownStyle = ComboBoxStyle.DropDown;
                        box.AutoCompleteSource = AutoCompleteSource.ListItems;
                        box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    }
                    catch { }

                }
             try
            {
                ComboBox edit = (ComboBox)e.Control;
                if (edit != null)
                {
                    edit.SelectedIndexChanged += new System.EventHandler(this.edit_cmb_select);
                }
            }
            catch { }
             */
            }
        private void edit_cmb_select(object sender, System.EventArgs e)
        {
            //ComboBox con = (ComboBox)sender;
            //BL.orders bl = new BL.orders();
            //DataTable dt = new DataTable();
            //dt=bl.select_one_product(con.Text);
            //if (dt.Rows.Count > 0)
            //{
            //    dataGridView1.CurrentRow.Cells[1].Value = "0";
            //    dataGridView1.CurrentRow.Cells[2].Value = dt.Rows[0]["sell_price"].ToString();
            //    s = dt.Rows[0]["sell_price"].ToString();
            //    dataGridView1.CurrentRow.Cells[3].Value = (double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * double.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())).ToString();
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    dataGridView1.CurrentRow.Cells[3].Value = (double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * double.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())).ToString();
            //}
            //catch { }
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    dataGridView1.CurrentRow.Cells[3].Value = (double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * double.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())).ToString();

            //}
            //catch { }
            try
            {
                double s = 0, ss = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
                txttotal.Text = s.ToString();
                textBox28.Text = ss.ToString();
                //if (txtpush.Text == "")
                //    txtpush.Text = "0";
                //double x = double.Parse(txttotal.Text);
                //double y = double.Parse(txtpush.Text);
                //double z = x - y;
                //if (z > 0)
                //    txtremender.Text = (z.ToString());
                //else
                //    txtremender.Text = "0";
                calcMoeny();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    dataGridView1.CurrentRow.Cells[3].Value = (double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * double.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())).ToString();
            //}
            //catch { }
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    textBox15.Text = "0";
            //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //    {
            //        if (dataGridView1.Rows[i].Cells[3].Value.ToString()!="")
            //        textBox15.Text = (double.Parse(textBox15.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())).ToString();
            //    }
            //}
            //catch
            //{ }
        }

        public void save_update_order()
        {
            BL.orders bl = new BL.orders();
            try
            {

                BL.orders bn = new BL.orders();
                DataTable dd = new DataTable();
                int xx = 0;
                dd = bn.max_id();
                int y = dd.Rows.Count;
                if (dd.Rows.Count > 0 && dd.Rows[0]["order_id"].ToString() != "")
                {
                    xx = int.Parse(dd.Rows[0]["order_id"].ToString()) + 1;
                }
                else
                {
                    xx++;
                }

                if (int.Parse(textBox1.Text) < xx)
                {
                    try
                    {
                        // update first part from order
                        BL.orders bl5 = new BL.orders();
                        bl5.sp_update_order(int.Parse(textBox1.Text), dateTimePicker1.Value, Convert.ToInt32(comboBox1.SelectedValue), txttotal.Text, int.Parse(textBox3.Text),
                            int.Parse(textBox11.Text), textBox7.Text, textBox4.Text,
                            textBox23.Text, txtpush.Text, txtremender.Text, textBox13.Text, textBox14.Text, textBox12.Text, textBox28.Text
                            );

                        //delete operations

                        bl5.sp_delete_to_update(int.Parse(textBox1.Text));
                        //save second part from order
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            DataTable d = new DataTable();
                            int h = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            d = bl5.slect_product(h);
                            int id = int.Parse(textBox1.Text);
                            int clint_id = Convert.ToInt32(comboBox1.SelectedValue);
                            int product_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            string product_name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            string product_num = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            string total = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            string profit = d.Rows[0]["profit"].ToString();
                            string parcode = d.Rows[0]["parcode"].ToString();
                            string notes = dataGridView1.Rows[i].Cells[5].Value.ToString();
                            float weight = float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            bl5.insert_operation(
                                id,
                                clint_id,
                                product_id,
                                product_name,
                                product_num,
                                total,
                                profit,
                                dateTimePicker1.Value.Date,
                                textBox23.Text,
                                parcode,
                                notes,
                                weight);
                        }
                        //save mony

                        if ( (txtremender.Text != "0" || txtremender.Text != "") &&save.Checked)
                        {
                            BL.shok_clints bb = new BL.shok_clints();
                            int id = int.Parse(comboBox1.SelectedValue.ToString());
                            string take = txttotal.Text;
                            string give = txtpush.Text;
                            string explain = "باقي فاتوره";

                            DataTable d = bb.get_shokak_op(int.Parse(textBox1.Text));
                            if (d.Rows.Count != 0)
                            {

                                int x = int.Parse(d.Rows[0]["operation_id"].ToString());

                                int clint = 0;
                                if (comboBox1.SelectedIndex != -1)
                                    clint = int.Parse(comboBox1.SelectedValue.ToString());
                                bb.upadte_sho_operaton(x, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date, take, give, explain);
                            }
                            else
                            {
                                if ((txtremender.Text != "0" || txtremender.Text != "") && save.Checked)
                                {
                                    bb.insert_sho_operaton(id, dateTimePicker1.Value.Date, take, give, explain, int.Parse(textBox1.Text));
                                }
                            }
                        }
                         
                       // MessageBox.Show("تم تعديل الفاتوره ");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (comboBox1.SelectedIndex != -1)
                    {
                        bl.insert_order(int.Parse(textBox1.Text), dateTimePicker1.Value.Date, Convert.ToInt32(comboBox1.SelectedValue), txttotal.Text, int.Parse(textBox3.Text),
                           int.Parse(textBox11.Text), textBox7.Text, textBox4.Text,
                           textBox23.Text, txtpush.Text, txtremender.Text, textBox13.Text, textBox14.Text, textBox12.Text,textBox28.Text
                           );
                        //save second part from order

                        DataTable t = new DataTable();
                        t = bl.sp_get_products_name();
                        comboBox2.DataSource = t;
                        comboBox2.DisplayMember = "product_name";
                        comboBox2.ValueMember = "product_id";
                        comboBox2.Refresh();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            DataTable d = new DataTable();
                            int h = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            d = bl.slect_product(h);
                            int id = int.Parse(textBox1.Text);
                            int clint_id = Convert.ToInt32(comboBox1.SelectedValue);
                            int product_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            string product_name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            string product_num = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            string total = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            string profit = d.Rows[0]["profit"].ToString();
                            string parcode = d.Rows[0]["parcode"].ToString();
                            string notes = dataGridView1.Rows[i].Cells[5].Value.ToString();
                            float weight = float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            bl.insert_operation(
                                id,
                                clint_id,
                                product_id,
                                product_name,
                                product_num,
                                total,
                                profit,
                                dateTimePicker1.Value.Date,
                                textBox23.Text,
                                parcode,
                                notes,
                                weight);
                        }


                        bl.delete_borrow_product(Convert.ToInt32(comboBox1.SelectedValue));

                        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                        {
                            string s1, s2, s3, s4;
                            DateTime d = DateTime.Parse(dataGridView2.Rows[i].Cells[6].Value.ToString());
                            int a = int.Parse(comboBox1.SelectedValue.ToString());//clint_id
                            int x = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());//product_id
                            s1 = dataGridView2.Rows[i].Cells[2].Value.ToString();//product_num
                            s2 = dataGridView2.Rows[i].Cells[3].Value.ToString();//price
                            s3 = dataGridView2.Rows[i].Cells[4].Value.ToString();//total
                            s4 = dataGridView2.Rows[i].Cells[5].Value.ToString();//name
                            bl.insert_borrow(a, x, s1, s3, s4, d, s2);
                        }
                        // save shokak


                        if ((txtremender.Text != "0" || txtremender.Text != "")&&save.Checked)
                        {
                            BL.shok_clints bb = new BL.shok_clints();
                            int id = int.Parse(comboBox1.SelectedValue.ToString());
                            string take = txttotal.Text;
                            string give = txtpush.Text;
                            string explain = "باقي فاتوره";
                            bb.insert_sho_operaton(id, dateTimePicker1.Value.Date, take, give, explain,int.Parse(textBox1.Text));
                        }
                         

                        // save money
                        bl.insert_money(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(textBox1.Text), txtpush.Text, dateTimePicker1.Value.Date);

                        //MessageBox.Show("تم حفظ الفاتوره ")
                    }
                    comboBox2.SelectedIndex = -1;
                    comboBox2.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            save_update_order();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BL.orders bl = new BL.orders();
            DataTable dd = new DataTable();
        
            
            try
            {
                int x, y;
                dd = bl.max_id();
                 y = dd.Rows.Count;
                if (dd.Rows.Count > 0)
                {
                     x = int.Parse(dd.Rows[0]["order_id"].ToString()) + 1;
                    textBox1.Text = x.ToString();
                }
            }
            catch (Exception ex)
            {
                 int x = 1;
                textBox1.Text = x.ToString();
            }
            
            textBox7.Text = "0";
            textBox3.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox9.Text = "0";
            textBox24.Text = "";
            textBox11.Text = "1";
            g.Rows.Clear();
            dataGridView1.DataSource=g;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
            textBox10.Text = "0";
            textBox4.Text = "0";
            txttotal.Text = "0";
            txtpush.Text = "0";
            txtremender.Text = "0";
            txtcount.Text = "0";
            textBox28.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";

            textBox18.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox27.Text = "0";

            textBox26.Text = "0";

           // textBox25.Text = "0";
            //textBox29.Text = "0";
            comboBox1.Focus();

           
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
 
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            save_update_order();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    BL.orders bl = new BL.orders();
                    bl.sp_delete_order(int.Parse(textBox1.Text));
                    bl.sp_delete_to_update(int.Parse(textBox1.Text));

                    BL.shok_clints bb = new BL.shok_clints();
                    DataTable d = bb.get_shokak_op(int.Parse(textBox1.Text));
                    if (d.Rows.Count!=0)
                    bb.delete_shok_operation(int.Parse(d.Rows[0]["operation_id"].ToString()));
                    MessageBox.Show("تم الحذف");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    BL.orders bl = new BL.orders();
                    DataTable dd = new DataTable();
                    dd = bl.max_id();
                    int y = dd.Rows.Count;
                    if (dd.Rows.Count > 0)
                    {
                        int x = int.Parse(dd.Rows[0]["order_id"].ToString()) + 1;
                        textBox1.Text = x.ToString();
                    }
                }
                catch (Exception ex)
                {
                    int x = 1;
                    textBox1.Text = x.ToString();
                }

                comboBox1.SelectedIndex = -1;
                textBox7.Text = "0";
                textBox3.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox9.Text = "0";
                textBox24.Text = "";
                textBox11.Text = "1";
                g.Rows.Clear();
                dataGridView1.DataSource = g;
                dataGridView2.DataSource = null;
                textBox10.Text = "0";
                textBox4.Text = "0";
                txttotal.Text = "0";
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            BL.orders bl = new BL.orders();
            save_update_order();
            try
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    //int x = int.Parse(textBox1.Text);
                    //CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    //reportDocument.SetDataSource(bl.get_details_for_print(x));
                    //reportDocument.Load(Application.StartupPath + "rpt2_order.rpt");
                    
                    //reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                    //reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);

                    //wwwwwwwwwww
                    int x = int.Parse(textBox1.Text);
                    report.rpt2_order repor = new report.rpt2_order();
                    repor.SetDataSource(bl.get_details_for_print(x));
                    report.form_report f = new report.form_report();
                    repor.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                    f.crystalReportViewer1.ReportSource = repor;

                    // show dialog
                    //report.rpt2_order repor = new report.rpt2_order();
                    //int x = int.Parse(textBox1.Text);
                    //repor.SetDataSource(bl.get_details_for_print(x));
                    //report.form_report f = new report.form_report();
                    //f.crystalReportViewer1.ReportSource = repor;
                    //f.ShowDialog();
                    //f.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                BL.orders bl = new BL.orders();
                DataTable dt = new DataTable();
                dt = bl.select_one_product(comboBox2.Text);
                if (dt.Rows.Count > 0)
                {
                    textBox16.Text = dt.Rows[0]["sell_price"].ToString();
                    s = dt.Rows[0]["sell_price"].ToString();
                    textBox17.Text = (double.Parse(textBox16.Text) * double.Parse(textBox2.Text)).ToString();
                    textBox18.Text = comboBox2.SelectedValue.ToString();
                    textBox26.Text = dt.Rows[0]["weightt"].ToString();

                }
                else
                    textBox16.Text = "0";
            }
            catch { }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                textBox17.Text = (double.Parse(textBox16.Text) * double.Parse(textBox2.Text)).ToString();
            }
            catch
            { }
        }

        private void comboBox2_LocationChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BL.orders bl = new BL.orders();
                DataTable dt = new DataTable();
                dt = bl.select_one_product(comboBox2.Text);
                if (dt.Rows.Count > 0)
                {

                    textBox16.Text = dt.Rows[0]["sell_price"].ToString();
                    s = dt.Rows[0]["sell_price"].ToString();
                    textBox17.Text = (double.Parse(textBox16.Text) * double.Parse(textBox2.Text)).ToString();
                    textBox18.Text = comboBox2.SelectedValue.ToString();
                    double b=double.Parse(dt.Rows[0]["weightt"].ToString());
                    textBox26.Text = b.ToString();



                    BL.reports bl2 = new BL.reports();
                    DataTable dt2 = new System.Data.DataTable();
                    DataTable dt4 = new System.Data.DataTable();
                    dt2 = bl2.all_products_by_id(int.Parse(textBox18.Text));
                    dt4 = bl2.all_products_from_buy_operations(int.Parse(textBox18.Text));
                    double sum1 = 0, sum2 = 0;
                    for (int j = 0; j < dt2.Rows.Count; j++)
                        sum1 += double.Parse(dt2.Rows[j]["product_number"].ToString());
                    for (int j = 0; j < dt4.Rows.Count; j++)
                        sum2 += double.Parse(dt4.Rows[j]["product_number"].ToString());
                    double av = sum2 - sum1;
                    avelable.Text = av.ToString();


                }
            }
            catch { }

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox17.Text = (double.Parse(textBox16.Text) * double.Parse(textBox2.Text)).ToString();
            }
            catch
            { }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
                if (textBox2.Text == "")
                    textBox2.Text = "0";
            comboBox2.Focus();

        }

        private void textBox17_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                textBox17.Text = (double.Parse(textBox16.Text) * double.Parse(textBox2.Text)).ToString();
            }
            catch
            { }
        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox16.Text == "")
                {
                    BL.orders bl = new BL.orders();
                    DataTable dt = new DataTable();
                    dt = bl.select_one_product(comboBox2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        textBox16.Text = dt.Rows[0]["sell_price"].ToString();
                        s = dt.Rows[0]["sell_price"].ToString();
                        textBox17.Text = (double.Parse(textBox16.Text) * double.Parse(textBox2.Text)).ToString();
                        textBox26.Text = dt.Rows[0]["weightt"].ToString();
                    }
                }
            }
            catch { }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && comboBox2.Text != "" && (textBox2.Text != "" && textBox2.Text != "0"))
            {

                add_product();

            }
        }

        public bool test_price()
        {

            DataTable dt = new DataTable();
            BL.orders b = new BL.orders();
            dt = b.select_one_product(comboBox2.Text);
            double x = double.Parse(textBox16.Text);
            double y = double.Parse(dt.Rows[0]["buy_price"].ToString());

            double max=y+(y/100)*20;
            if(x<=y)
            {
                
                if (MessageBox.Show(@"سعر الشراء = "+y.ToString()+" هل موافق؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    return true;
                }
                else
                    return false;
            }
            else if(x>=max)
            {
                if (MessageBox.Show(@"سعر الشراء = " + y.ToString() + " هل موافق؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    return true;
                }
                else
                    return false;
            }


            return true;
        }
        public void add_product()
        {
            try
            {
                if(comboBox1.Text=="")
                {
                    MessageBox.Show("ادخل الاسم ");
                    return;
                        
                }
                if (test_amount(int.Parse(textBox18.Text), double.Parse(textBox2.Text)) && test_price())
                {
                    if (textBox26.Text == "")
                        textBox26.Text = "0";
                    DataRow r = g.NewRow();
                    r[0] = textBox18.Text;
                    r[1] = comboBox2.Text;
                    r[2] = textBox2.Text;
                    r[3] = textBox16.Text;
                    r[4] = textBox17.Text;
                    r[5] = textBox27.Text;
                    r[6] = (double.Parse(textBox26.Text) * double.Parse(textBox2.Text)).ToString();
                    textBox18.Text = "";
                    if (indexOfRow.Text != "")
                        g.Rows.InsertAt(r, int.Parse(indexOfRow.Text));
                    else
                        g.Rows.InsertAt(r, 0);
                    dataGridView1.DataSource = g;
                    comboBox2.Text = "";
                    textBox2.Text = "0";
                    textBox16.Text = "0";
                    textBox17.Text = "0";
                    textBox27.Text = "";
                    textBox26.Text = "0";

                    double s = 0, ss = 0;
                    int v = 0;
                    double h = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                        v++;
                        h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    txtcount.Text = v.ToString();
                    txttotal.Text = s.ToString();
                    textBox28.Text = ss.ToString();
                    textBox15.Text = h.ToString();
                    //if (txtpush.Text == "")
                    //    txtpush.Text = "0";
                    //double x = double.Parse(txttotal.Text);
                    //double y = double.Parse(txtpush.Text);
                    //double z = x - y;
                    //if (z > 0)
                    //    txtremender.Text = (z.ToString());
                    //else
                    //    txtremender.Text = "0";

                    calcMoeny();
                    save_update_order();


                    int rowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;

                    // Refresh your DGV.

                    dataGridView1.FirstDisplayedScrollingRowIndex = 0;

                    comboBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter&&comboBox2.Text!=""&&(textBox2.Text!=""&&textBox2.Text!="0"))
            {
                //try
                //{
                //    if (test_amount(int.Parse(textBox18.Text), double.Parse(textBox2.Text)))
                //    {
                //        if (textBox26.Text == "")
                //            textBox26.Text = "0";
                //        DataRow r = g.NewRow();
                //        r[0] = textBox18.Text;
                //        r[1] = comboBox2.Text;
                //        r[2] = textBox2.Text;
                //        r[3] = textBox16.Text;
                //        r[4] = textBox17.Text;
                //        r[5] = textBox27.Text;
                //        r[6] = (double.Parse(textBox26.Text) * double.Parse(textBox2.Text)).ToString();
                //        textBox18.Text = "";
                //        if (indexOfRow.Text != "")
                //            g.Rows.InsertAt(r, int.Parse(indexOfRow.Text));
                //        else
                //            g.Rows.InsertAt(r, 0);
                //        dataGridView1.DataSource = g;
                //        comboBox2.Text = "";
                //        textBox2.Text = "0";
                //        textBox16.Text = "0";
                //        textBox17.Text = "0";
                //        textBox27.Text = "";
                //        textBox26.Text = "0";
                //        double s = 0, ss = 0;
                //        int v = 0;
                //        double h = 0;
                //        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                //        {
                //            s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                //            ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                //            v++;
                //            h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                //        }
                //        txtcount.Text = v.ToString();
                //        txttotal.Text = s.ToString();
                //        textBox28.Text = ss.ToString();
                //        textBox15.Text = h.ToString();
                //        if (txtpush.Text == "")
                //            txtpush.Text = "0";
                //        double x = double.Parse(txttotal.Text);
                //        double y = double.Parse(txtpush.Text);
                //        double z = x - y;
                //        if (z > 0)
                //            txtremender.Text = (z.ToString());
                //        else
                //            txtremender.Text = "0";
                //        save_update_order();
                //        comboBox2.Focus();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

                add_product();

            }
        }

        private void comboBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox2.Text != "" && (textBox2.Text != "" && textBox2.Text != "0"))
            {

                add_product();
                //try
                //{
                //    if (test_amount(int.Parse(textBox18.Text), double.Parse(textBox2.Text)))
                //    {
                //        if (textBox26.Text == "")
                //            textBox26.Text = "0";
                //        DataRow r = g.NewRow();
                //        r[0] = textBox18.Text;
                //        r[1] = comboBox2.Text;
                //        r[2] = textBox2.Text;
                //        r[3] = textBox16.Text;
                //        r[4] = textBox17.Text;
                //        r[5] = textBox27.Text;
                //        r[6] = (double.Parse(textBox26.Text) * double.Parse(textBox2.Text)).ToString();
                //        textBox18.Text = "";
                //        //g.Rows.InsertAt(r, 0);
                //        if (indexOfRow.Text != "")
                //            g.Rows.InsertAt(r, int.Parse(indexOfRow.Text));
                //        else
                //            g.Rows.InsertAt(r, 0);
                //        indexOfRow.Text = "";
                //        dataGridView1.DataSource = g;
                //        comboBox2.Text = "";
                //        textBox2.Text = "0";
                //        textBox16.Text = "0";
                //        textBox17.Text = "0";
                //        textBox27.Text = "";
                //        textBox26.Text = "0";


                //        update_textbox_value();
                //        save_update_order();

                //        int rowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;



                //        dataGridView1.FirstDisplayedScrollingRowIndex = 0;
                //    }
                //}

                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}


            }
        }

        public bool test_amount(int x,double amount)
        {
            BL.reports bl2 = new BL.reports();
            DataTable dt2 = new System.Data.DataTable();
            DataTable dt4 = new System.Data.DataTable();
            dt2 = bl2.all_products_by_id(x);
            dt4 = bl2.all_products_from_buy_operations(x);
            double sum1 = 0, sum2 = 0;
            for (int j = 0; j < dt2.Rows.Count; j++)
                sum1 += double.Parse(dt2.Rows[j]["product_number"].ToString());
            for (int j = 0; j < dt4.Rows.Count; j++)
                sum2 += double.Parse(dt4.Rows[j]["product_number"].ToString());
            double av = sum2 - sum1;
            if(amount<=av)
            {
                return true;
            }
            else
            {
                MessageBox.Show("الكميه المتاحه "+ av.ToString());
                return false;
            }


        }
        public void update_textbox_value()
        {
            double s = 0, ss = 0;
            int v = 0;
            double h = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                v++;
                h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            txtcount.Text = v.ToString();
            txttotal.Text = s.ToString();
            textBox28.Text = ss.ToString();
            textBox15.Text = h.ToString();
            //if (txtpush.Text == "")
            //    txtpush.Text = "0";
            //double x = double.Parse(txttotal.Text);
            //double y = double.Parse(txtpush.Text);
            //double z = x - y;
            //if (z > 0)
            //    txtremender.Text = (z.ToString());
            //else
            //    txtremender.Text = "0";

            calcMoeny();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            product_form f = new product_form();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    textBox18.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    textBox16.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //    textBox17.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //    textBox27.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //    double xx = double.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            //    xx /= double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            //    textBox26.Text = xx.ToString();
            //    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                

            //    double s = 0, ss = 0;
            //    int v = 0;
            //    double h = 0;
            //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //    {
            //        s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            //        ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            //        v++;
            //        h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            //    }
            //    txtcount.Text = v.ToString();
            //    txttotal.Text = s.ToString();
            //    textBox28.Text = ss.ToString();
            //    textBox15.Text = h.ToString();
            //    if (txtpush.Text == "")
            //        txtpush.Text = "0";
            //    double x = double.Parse(txttotal.Text);
            //    double y = double.Parse(txtpush.Text);
            //    double z = x - y;
            //    if (z > 0)
            //        txtremender.Text = (z.ToString());
            //    else
            //        txtremender.Text = "0";
            //    save_update_order();
            //}
            //catch { }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            borrow_product f = new borrow_product();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BL.orders bl = new BL.orders();
                bl.sp_delete_borrow(Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("تم تصفيه الحساب");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double x = double.Parse(textBox10.Text);
            if (x < 0)
            {
                textBox6.Text = (Math.Abs(x)).ToString();
            }
            else
            {
                textBox6.Text = "0";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (textBox3.Text == "")
                    textBox3.Text = "0";
                double x = double.Parse(textBox3.Text);
                if (x > 4)
                {
                    double f = (x - 4) * double.Parse(textBox13.Text) + (4 * double.Parse(textBox14.Text)) - (double.Parse(textBox12.Text)) + (double.Parse(textBox7.Text));
                    textBox4.Text = (f).ToString();
                    textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                }
                else
                {
                    double f = x * double.Parse(textBox14.Text) - double.Parse(textBox12.Text) + double.Parse(textBox7.Text);
                    textBox4.Text = (f).ToString();
                    textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                }


                if (textBox8.Text == "")
                    textBox8.Text = "0";
                double y = double.Parse(textBox8.Text) * double.Parse(textBox13.Text);
                double z = double.Parse(textBox4.Text);
                double d = double.Parse(textBox9.Text) * double.Parse(textBox14.Text);
                textBox4.Text = (z + y + d).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "")
                    textBox3.Text = "0";
                double x = double.Parse(textBox3.Text);
                if (x > 4)
                {
                    double f = (x - 4) * double.Parse(textBox13.Text) + (4 * double.Parse(textBox14.Text)) - (double.Parse(textBox12.Text)) + (double.Parse(textBox7.Text));
                    textBox4.Text = (f).ToString();
                    textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                }
                else
                {
                    double f = x * double.Parse(textBox14.Text) - double.Parse(textBox12.Text) + double.Parse(textBox7.Text);
                    textBox4.Text = (f).ToString();
                    textBox10.Text = (f - (double.Parse(txttotal.Text))).ToString();
                }


                if (textBox8.Text == "")
                    textBox8.Text = "0";
                double y = double.Parse(textBox8.Text) * double.Parse(textBox13.Text);
                double z = double.Parse(textBox4.Text);
                double d = double.Parse(textBox9.Text) * double.Parse(textBox14.Text);
                textBox4.Text = (z + y+d).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            if (x > 0)
            {
            f:
            try
            {
               
                BL.orders bl = new BL.orders();
                DataTable d1, d2, d3;
                d1 = new DataTable();
                d2 = new DataTable();
                d3 = new DataTable();
                    x--;
                d1 = bl.sp_get_order_by_id(x);
                d2 = bl.sp_get_operations_by_id(x);
                d3 = bl.get_borrow_peoduct(Convert.ToInt32(comboBox1.SelectedValue));
                oreer_form.order_f.textBox1.Text = d1.Rows[0]["order_id"].ToString();
                oreer_form.order_f.dateTimePicker1.Value = DateTime.Parse(d1.Rows[0]["order_date"].ToString());
                oreer_form.order_f.textBox23.Text = d1.Rows[0]["user_name"].ToString();
                //oreer_form.order_f.comboBox1.SelectedValue = Convert.ToInt32(d1.Rows[0]["clint_id"].ToString());
                oreer_form.order_f.comboBox1.Text = d1.Rows[0]["clint_name"].ToString();
                //oreer_form.order_f.textBox5.Text = d1.Rows[0]["secrit_number"].ToString();
                oreer_form.order_f.textBox3.Text = d1.Rows[0]["sons_number"].ToString();
                oreer_form.order_f.textBox24.Text = d1.Rows[0]["number_card"].ToString();
                //oreer_form.order_f.textBox7.Text = d1.Rows[0]["points_bread"].ToString();
                oreer_form.order_f.textBox4.Text = d1.Rows[0]["support"].ToString();
                oreer_form.order_f.textBox6.Text = d1.Rows[0]["require_mony"].ToString();
                //oreer_form.order_f.textBox11.Text = d1.Rows[0]["cards_number"].ToString();
                oreer_form.order_f.textBox12.Text = d1.Rows[0]["tax_cars"].ToString();
                oreer_form.order_f.textBox13.Text = d1.Rows[0]["add_support"].ToString();
                oreer_form.order_f.textBox14.Text = d1.Rows[0]["base_support"].ToString();
                oreer_form.order_f.txttotal.Text = d1.Rows[0]["total"].ToString();
                oreer_form.order_f.txtpush.Text = d1.Rows[0]["remaind_support"].ToString();
                oreer_form.order_f.txtremender.Text = d1.Rows[0]["require_mony"].ToString();                //for (int i = 0; i < d2.Rows.Count; i++)
                //{
                //    try
                //    {
                //        oreer_form.order_f.dataGridView1.Rows.Add();
                //        oreer_form.order_f.dataGridView1.Rows[i].Cells["product_name"].Value=  d2.Rows[i]["product_name"].ToString();
                //        oreer_form.order_f.dataGridView1.Rows[i].Cells["product_num"].Value = d2.Rows[i]["product_number"].ToString();
                //        oreer_form.order_f.dataGridView1.Rows[i].Cells["price"].Value = d2.Rows[i]["product_price"].ToString();
                //        oreer_form.order_f.dataGridView1.Rows[i].Cells["total"].Value = d2.Rows[i]["total"].ToString();
                //    }
                //    catch { }
                //}
                oreer_form.order_f.g = d2;
                oreer_form.order_f.dataGridView1.DataSource = oreer_form.order_f.g;
                gg = d3;
                oreer_form.order_f.dataGridView2.DataSource = d3;
                dataGridView1.Columns["رقم الصنف"].Visible = false;
                //get_last_money();
                update_textbox_value();
                  }
            catch {
                if (x > 0)
                {
               // MessageBox.Show("لا نوجد فاتوره برقم " + "  " + x);
                  goto f;
                }
                }
            
           }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BL.orders bl = new BL.orders();
            DataTable d1, d2, d3;
            d1 = new DataTable();
            d2 = new DataTable();
            d3 = new DataTable();
            int x = int.Parse(textBox1.Text);
            DataTable gg = new DataTable();
            gg = bl.max_id();
            if ( gg.Rows[0]["order_id"].ToString()!=""&& x < int.Parse(gg.Rows[0]["order_id"].ToString()))
            {
            f:
                try
                {
                    x++;
                    d1 = bl.sp_get_order_by_id(x);
                    d2 = bl.sp_get_operations_by_id(x);
                    d3 = bl.get_borrow_peoduct(Convert.ToInt32(comboBox1.SelectedValue));
                    oreer_form.order_f.textBox1.Text = d1.Rows[0]["order_id"].ToString();
                    oreer_form.order_f.dateTimePicker1.Value = DateTime.Parse(d1.Rows[0]["order_date"].ToString());
                    oreer_form.order_f.textBox23.Text = d1.Rows[0]["user_name"].ToString();
                    oreer_form.order_f.comboBox1.Text = d1.Rows[0]["clint_name"].ToString();
                    oreer_form.order_f.textBox5.Text = d1.Rows[0]["secrit_number"].ToString();
                    oreer_form.order_f.textBox3.Text = d1.Rows[0]["sons_number"].ToString();
                    oreer_form.order_f.textBox24.Text = d1.Rows[0]["number_card"].ToString();
                    oreer_form.order_f.textBox7.Text = d1.Rows[0]["points_bread"].ToString();
                    oreer_form.order_f.textBox4.Text = d1.Rows[0]["support"].ToString();
                    oreer_form.order_f.textBox6.Text = d1.Rows[0]["require_mony"].ToString();
                    oreer_form.order_f.textBox11.Text = d1.Rows[0]["cards_number"].ToString();
                    oreer_form.order_f.textBox12.Text = d1.Rows[0]["tax_cars"].ToString();
                    oreer_form.order_f.textBox13.Text = d1.Rows[0]["add_support"].ToString();
                    oreer_form.order_f.textBox14.Text = d1.Rows[0]["base_support"].ToString();
                    oreer_form.order_f.txttotal.Text = d1.Rows[0]["total"].ToString();
                    oreer_form.order_f.txtpush.Text = d1.Rows[0]["remaind_support"].ToString();
                    oreer_form.order_f.txtremender.Text = d1.Rows[0]["require_mony"].ToString();
                    //for (int i = 0; i < d2.Rows.Count; i++)
                    //{
                    //    try
                    //    {
                    //        oreer_form.order_f.dataGridView1.Rows.Add();
                    //        oreer_form.order_f.dataGridView1.Rows[i].Cells["product_name"].Value=  d2.Rows[i]["product_name"].ToString();
                    //        oreer_form.order_f.dataGridView1.Rows[i].Cells["product_num"].Value = d2.Rows[i]["product_number"].ToString();
                    //        oreer_form.order_f.dataGridView1.Rows[i].Cells["price"].Value = d2.Rows[i]["product_price"].ToString();
                    //        oreer_form.order_f.dataGridView1.Rows[i].Cells["total"].Value = d2.Rows[i]["total"].ToString();
                    //    }
                    //    catch { }
                    //}
                    oreer_form.order_f.g = d2;
                    oreer_form.order_f.dataGridView1.DataSource = oreer_form.order_f.g;
                    gg = d3;
                    oreer_form.order_f.dataGridView2.DataSource = d3;
                    dataGridView1.Columns["رقم الصنف"].Visible = false;
                    //get_last_money();
                    update_textbox_value();
                }
                catch {
                 //   MessageBox.Show("لا نوجد فاتوره برقم " + "  " + x);
                    if (x < int.Parse(gg.Rows[0]["order_id"].ToString()))
                    goto f;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shokak f = new shokak();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void oreer_form_Leave(object sender, EventArgs e)
        {
            save_update_order();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //textBox25.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                //textBox22.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                //textBox21.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                //textBox20.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                //dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox21_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox20_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {

        }

        private void textBox21_Leave(object sender, EventArgs e)
        {
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            try
            {
                BL.orders b = new BL.orders();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string s1, s2, s3,s4;
                    DateTime d = dateTimePicker1.Value.Date;
                    int a = int.Parse(comboBox1.SelectedValue.ToString());
                    int x=int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    s1 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    s2 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    s3 = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    s4= textBox20.Text;
                    b.insert_borrow(a, x, s1, s3, s4, d, s2);
                }
                MessageBox.Show("تم حفظ بيانات الفاتوره ");
                g.Rows.Clear();
                dataGridView1.DataSource = g;
                textBox20.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    BL.orders bl = new BL.orders();
                    DataTable dt = new DataTable();
                    dt = bl.sp_select_one_product_by_barcode(decimal.Parse(textBox22.Text));
                    DataRow r = g.NewRow();
                    r[0] = dt.Rows[0]["product_id"].ToString();
                    r[1] = dt.Rows[0]["product_name"].ToString();
                    r[2] = (1).ToString();
                    r[3] = dt.Rows[0]["sell_price"].ToString();
                    r[4] = dt.Rows[0]["sell_price"].ToString();
                    g.Rows.InsertAt(r, 0);
                    dataGridView1.DataSource = g;
                    comboBox2.Text = "";
                    textBox2.Text = "0";
                    textBox16.Text = "0";
                    textBox17.Text = "0";
                    textBox18.Text = "";
                    textBox26.Text = "0";
                    double s = 0, ss = 0;
                    int v = 0;
                    double h = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                        v++;
                        h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    txtcount.Text = v.ToString();
                    txttotal.Text = s.ToString();
                    textBox28.Text = ss.ToString();
                    textBox15.Text = h.ToString();
                    textBox22.SelectAll();
                    //if (txtpush.Text == "")
                    //    txtpush.Text = "0";
                    //double x = double.Parse(txttotal.Text);
                    //double y = double.Parse(txtpush.Text);
                    //double z = x - y;
                    //if (z > 0)
                    //    txtremender.Text = (z.ToString());
                    //else
                    //    txtremender.Text = "0";
                    calcMoeny();
                    save_update_order();
                }
                catch { }   
            }

        }

        public void calcMoeny()
        {
            try
            {
                if (txtpush.Text == "")
                    txtpush.Text = "0";
                if (txttotal.Text == "")
                    txttotal.Text = "0";

                //if (textBox29.Text == "")
                //    textBox29.Text = "0";
                //if (textBox25.Text == "")
                //    textBox25.Text = "0";


                double x = double.Parse(txttotal.Text);
                double y = double.Parse(txtpush.Text);
                //double dis = double.Parse(textBox25.Text);
                
                //double last = double.Parse(textBox29.Text);

                //lastMoney.Text = last.ToString();
                double z = x - y ;
                //if (z > 0)
               // textBox25.Text = (x  - dis).ToString();
                    txtremender.Text = (z.ToString());
                //else
                 //   txtremender.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox21_Leave_1(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtpush.Text == "")
            //        txtpush.Text = "0";
            //    double x = double.Parse(txttotal.Text);
            //    double y = double.Parse(txtpush.Text);
            //    double z = x - y;
            //    if (z > 0)
            //        txtremender.Text = (z.ToString());
            //    else
            //        txtremender.Text = "0";
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            calcMoeny();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox15_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged_2(object sender, EventArgs e)
        {
            //calcMoeny();
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) && c != 8 && c != 46 && c != '.') || (c == '.' && textBox2.Text.Contains('.')))
                e.Handled = true;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox2.Text != "" && (textBox2.Text != "" && textBox2.Text != "0"))
            {
                //try
                //{
                //    if (test_amount(int.Parse(textBox18.Text), double.Parse(textBox2.Text)))
                //    {
                //        if (textBox26.Text == "")
                //            textBox26.Text = "0";
                //        DataRow r = g.NewRow();
                //        r[0] = textBox18.Text;
                //        r[1] = comboBox2.Text;
                //        r[2] = textBox2.Text;
                //        r[3] = textBox16.Text;
                //        r[4] = textBox17.Text;
                //        r[5] = textBox27.Text;
                //        r[6] = (double.Parse(textBox26.Text) * double.Parse(textBox2.Text)).ToString();
                //        textBox18.Text = "";
                //        if (indexOfRow.Text != "")
                //            g.Rows.InsertAt(r, int.Parse(indexOfRow.Text));
                //        else
                //            g.Rows.InsertAt(r, 0);
                //        dataGridView1.DataSource = g;
                //        comboBox2.Text = "";
                //        textBox2.Text = "0";
                //        textBox16.Text = "0";
                //        textBox17.Text = "0";
                //        textBox27.Text = "";
                //        textBox26.Text = "0";

                //        double s = 0, ss = 0;
                //        int v = 0;
                //        double h = 0;
                //        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                //        {
                //            s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                //            ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                //            v++;
                //            h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                //        }
                //        txtcount.Text = v.ToString();
                //        txttotal.Text = s.ToString();
                //        textBox28.Text = ss.ToString();
                //        textBox15.Text = h.ToString();
                //        if (txtpush.Text == "")
                //            txtpush.Text = "0";
                //        double x = double.Parse(txttotal.Text);
                //        double y = double.Parse(txtpush.Text);
                //        double z = x - y;
                //        if (z > 0)
                //            txtremender.Text = (z.ToString());
                //        else
                //            txtremender.Text = "0";
                //        save_update_order();
                //        comboBox2.Focus();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                add_product();

            }
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox2.Text != "" && (textBox2.Text != "" && textBox2.Text != "0"))
            {
                try
                {
                    if (test_amount(int.Parse(textBox18.Text), double.Parse(textBox2.Text)))
                    {
                        if (textBox26.Text == "")
                            textBox26.Text = "0";
                        DataRow r = g.NewRow();
                        r[0] = textBox18.Text;
                        r[1] = comboBox2.Text;
                        r[2] = textBox2.Text;
                        r[3] = textBox16.Text;
                        r[4] = textBox17.Text;
                        r[5] = textBox27.Text;
                        r[6] = (double.Parse(textBox26.Text) * double.Parse(textBox2.Text)).ToString();
                        textBox18.Text = "";
                        if (indexOfRow.Text != "")
                            g.Rows.InsertAt(r, int.Parse(indexOfRow.Text));
                        else
                            g.Rows.InsertAt(r, 0);
                        dataGridView1.DataSource = g;
                        comboBox2.Text = "";
                        textBox2.Text = "0";
                        textBox16.Text = "0";
                        textBox17.Text = "0";
                        textBox27.Text = "";
                        textBox26.Text = "0";
                        double s = 0, ss = 0;
                        int v = 0;
                        double h = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            v++;
                            h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        }
                        txtcount.Text = v.ToString();
                        txttotal.Text = s.ToString();
                        textBox28.Text = ss.ToString();
                        textBox15.Text = h.ToString();
                        //if (txtpush.Text == "")
                        //    txtpush.Text = "0";
                        //double x = double.Parse(txttotal.Text);
                        //double y = double.Parse(txtpush.Text);
                        //double z = x - y;
                        //if (z > 0)
                        //    txtremender.Text = (z.ToString());
                        //else
                        //    txtremender.Text = "0";
                        calcMoeny();
                        save_update_order();
                        comboBox2.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form f = new add_new_clint();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void textBox2_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    my_menu.Items.Add("تعديل").Name="تحديث";
                    my_menu.Items.Add("حذف").Name = "حذف";
                }

                my_menu.Show(dataGridView1, new Point(e.X, e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);

            }
        }

        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString()=="تحديث")
            {
                try
                {
                textBox18.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox16.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox17.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox27.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                double xx = double.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                xx /= double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                textBox26.Text = xx.ToString();
                indexOfRow.Text = dataGridView1.CurrentRow.Index.ToString();

                comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                double s = 0, ss = 0;
                int v = 0;
                double h = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                    v++;
                    h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                txtcount.Text = v.ToString();
                txttotal.Text = s.ToString();
                textBox28.Text = ss.ToString();
                textBox15.Text = h.ToString();
                //if (txtpush.Text == "")
                //    txtpush.Text = "0";
                //double x = double.Parse(txttotal.Text);
                //double y = double.Parse(txtpush.Text);
                //double z = x - y;
                //if (z > 0)
                //    txtremender.Text = (z.ToString());
                //else
                //    txtremender.Text = "0";

                calcMoeny();
                save_update_order();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                comboBox2.Focus();
            }
            else
            {
                try
                {
                    textBox18.Text = "";
                    comboBox2.SelectedIndex = -1;
                    textBox2.Text = "0";
                    textBox16.Text = "0";
                    textBox17.Text = "0";
                    textBox27.Text = "0";
                    
                    textBox26.Text = "0";
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    double s = 0, ss = 0;
                    int v = 0;
                    double h = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        s += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        ss += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                        v++;
                        h += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    txtcount.Text = v.ToString();
                    txttotal.Text = s.ToString();
                    textBox28.Text = ss.ToString();
                    textBox15.Text = h.ToString();
                    //if (txtpush.Text == "")
                    //    txtpush.Text = "0";
                    //double x = double.Parse(txttotal.Text);
                    //double y = double.Parse(txtpush.Text);
                    //double z = x - y;
                    //if (z > 0)
                    //    txtremender.Text = (z.ToString());
                    //else
                    //    txtremender.Text = "0";
                    calcMoeny();
                    save_update_order();
                    comboBox2.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
            
        }



        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reports_form f = new reports_form();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            storage_products f = new storage_products();

            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            buy_order f = new buy_order();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void textBox21_TextChanged_3(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                        dataGridView1.Rows[i].Selected = false;
                    
                }
                for(int i=0;i<dataGridView1.Rows.Count-1;i++)
                {
                    string x=dataGridView1.Rows[i].Cells[1].Value.ToString();
                    if(x.Contains(textBox21.Text)&&textBox21.Text!="")
                    {
                        dataGridView1.Rows[i].Selected = true ;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = DateTime.Now;


                BL.clints bl_c = new BL.clints();
                DataTable h = new DataTable();
                h = bl_c.clints_name_id();
                comboBox1.DataSource = h;
                comboBox1.ValueMember = "clint_id";
                comboBox1.DisplayMember = "clint_name";


                BL.orders bl = new BL.orders();
                DataTable t = new DataTable();
                t = bl.sp_get_products_name();
                comboBox2.DataSource = t;
                comboBox2.DisplayMember = "product_name";
                comboBox2.ValueMember = "product_id";



            }
            catch
            {

            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged_1(object sender, EventArgs e)
        {
            calcMoeny();
        }

        private void lastMoney_TextChanged(object sender, EventArgs e)
        {
            calcMoeny();
        }
    }
}
