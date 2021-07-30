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
    
    
    public partial class buy_order : Form
    {


        public static buy_order form_buy_order;
        //public static void form_closed(object sender, FormClosedEventArgs e)
        //{
        //    form_buy_order = null;
        //}
        //public static buy_order getform
        //{
        //    get
        //    {
        //        if (form_buy_order == null)
        //        {
        //            form_buy_order = new buy_order();
        //            form_buy_order.FormClosed += new FormClosedEventHandler(form_closed);
        //        }
        //        return form_buy_order;
        //    }

        //}



        BL.buy_order bl = new BL.buy_order();

        public DataTable g = new DataTable();
        public buy_order()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
                DataTable q = new DataTable();
                BL.buy_order b = new BL.buy_order();
                q = b.all_supports_buy_order();
                comboBox1.DataSource = q;
                comboBox1.DisplayMember = "support_name";
                comboBox1.ValueMember = "support_id";
                BL.orders bs = new BL.orders();
                DataTable t = new DataTable();
                t = bs.sp_get_products_name();
                comboBox3.DataSource = t;
                comboBox3.DisplayMember = "product_name";
                comboBox3.ValueMember = "product_id";
                g.Columns.Add("رقم الصنف");
                g.Columns.Add("اسم الصنف");
                g.Columns.Add("عدد الصنف");
                g.Columns.Add("سعر الوحده");
                g.Columns.Add("الاجمالي");
                dataGridView2.DataSource = g;
                form_buy_order = this;

                int index = comboBox2.FindString("شراء");
                comboBox2.SelectedIndex = index;
            try
            {
                BL.buy_order bl = new BL.buy_order();
                DataTable dd = new DataTable();
                dd = bl.maax_buy_id();
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

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataSource = g;
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
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
        }

        private void buy_order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tamwinDataSet7.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.tamwinDataSet7.products);
            //comboBox1.Text = "";

           
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.Maroon;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan;
            this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 16);
            dataGridView2.RowTemplate.Height = 40;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            new_order();
        }
        public void new_order()
        {

            try
            {
                BL.buy_order bl = new BL.buy_order();
                DataTable dd = new DataTable();
                dd = bl.maax_buy_id();
                int y = dd.Rows.Count;
                if (dd.Rows.Count > 0)
                {
                    int x = int.Parse(dd.Rows[0]["order_id"].ToString()) + 1;
                    textBox1.Text = x.ToString();
                }
                count.Text = (int.Parse(dataGridView2.Rows.Count.ToString()) - 1).ToString();

            }
            catch (Exception ex)
            {
                int x = 1;
                textBox1.Text = x.ToString();
            }

            textBox5.Text = "";
            g.Rows.Clear();
            dataGridView2.DataSource = g;
            textBox7.Text = "";
            textBox8.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "0";
            paid.Text = "";
            remaind.Text = "";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            save_order();
            count.Text = (int.Parse(dataGridView2.Rows.Count.ToString()) - 1).ToString();
        }
        public void save_order()
        {
            try
            {
                count.Text = (int.Parse(dataGridView2.Rows.Count.ToString())-1).ToString();
                BL.buy_order bl = new BL.buy_order();
                int max = 0;
                if (bl.maax_buy_id().Rows[0]["order_id"].ToString() != "")
                    max = int.Parse(bl.maax_buy_id().Rows[0]["order_id"].ToString());
                if (int.Parse(textBox1.Text) > max)
                {

                    bl.insert_buy_order(int.Parse(textBox1.Text), Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value.Date, textBox5.Text, textBox2.Text, comboBox2.Text,paid.Text,remaind.Text);


                    //second

                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        bl.insert_operations(
                            int.Parse(textBox1.Text),
                            Convert.ToInt32(comboBox1.SelectedValue),
                            int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                            dataGridView2.Rows[i].Cells[2].Value.ToString(),
                            dataGridView2.Rows[i].Cells[3].Value.ToString(),
                            dateTimePicker1.Value.Date,
                            dataGridView2.Rows[i].Cells[4].Value.ToString(),
                            textBox5.Text,
                            comboBox2.Text
                            );
                    }


                  //  MessageBox.Show("تم حفظ بيانات الفاتوره");
                }
                else
                {
                    try
                    {
                        //BL.buy_order bl = new BL.buy_order();
                        bl.update_buy_order(int.Parse(textBox1.Text), Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value, textBox5.Text, textBox2.Text, comboBox2.Text, paid.Text, remaind.Text);


                        //second
                        bl.delete_buy_operations(int.Parse(textBox1.Text));

                        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                        {
                            bl.insert_operations(
                                int.Parse(textBox1.Text),
                                Convert.ToInt32(comboBox1.SelectedValue),
                                int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                                dataGridView2.Rows[i].Cells[2].Value.ToString(),
                                dataGridView2.Rows[i].Cells[3].Value.ToString(),
                                dateTimePicker1.Value,
                                dataGridView2.Rows[i].Cells[4].Value.ToString(),
                                textBox5.Text,
                                comboBox2.Text
                                );
                        }


                    //    MessageBox.Show("تم تعديل بيانات الفاتوره");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable g = new DataTable();
            //    BL.buy_order b = new BL.buy_order();
            //    g = b.all_supports_buy_order();
            //    comboBox1.DataSource = g;
            //    comboBox1.DisplayMember = "support_name";
            //    comboBox1.ValueMember = "support_id";

            //    textBox6.Text = g.Rows[0]["address"].ToString();
            //    textBox7.Text = g.Rows[0]["phone_numer"].ToString();
            //    textBox4.Text = g.Rows[0]["support_id"].ToString();
            //    textBox8.Text = g.Rows[0]["banq_name"].ToString();
            //    textBox3.Text = g.Rows[0]["banq_number"].ToString();
            //    textBox5.Text = form_login.user_name;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            DataTable g = new DataTable();
            BL.buy_order b = new BL.buy_order();
            g = b.all_supports_buy_order();
            textBox6.Text = g.Rows[0]["address"].ToString();
            textBox7.Text = g.Rows[0]["phone_numer"].ToString();
            textBox4.Text = g.Rows[0]["support_id"].ToString();
            textBox8.Text = g.Rows[0]["banq_name"].ToString();
            textBox3.Text = g.Rows[0]["banq_number"].ToString();
            textBox5.Text = form_login.user_name;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double y=0,g=0;
                DataTable d = new DataTable();
                int x=Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                d = bl.select_product_by_id(x);
                dataGridView2.CurrentRow.Cells[0].Value = (x).ToString();
                dataGridView2.CurrentRow.Cells[3].Value = (d.Rows[0]["buy_price"]).ToString();
                g=double.Parse(d.Rows[0]["buy_price"].ToString());
                if (dataGridView2.CurrentRow.Cells[2].Value.ToString() != "")
                {
                    y = double.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    dataGridView2.CurrentRow.Cells[4].Value = (y*g).ToString();
                }
                else
                {
                    dataGridView2.CurrentRow.Cells[4].Value = (0).ToString();
                }

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(comboBox3.SelectedValue);
                textBox10.Text = x.ToString();
                DataTable f = new DataTable();
                BL.orders b = new BL.orders();
                f = b.select_one_product(comboBox3.Text);
                textBox10.Text = "0";
                if (f.Rows.Count > 0)
                {
                    textBox9.Text = f.Rows[0]["buy_price"].ToString();
                    textBox10.Text = f.Rows[0]["product_id"].ToString();
                }
                else
                {
                    //messagebox.show("صنف غير مسجل");
                    //combobox3.focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في ادخال البيانات");
                comboBox3.Focus();
            }

        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            comboBox3.Focus();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (textBox16.Text == "")
                //    textBox16.Text = "0";
                //if (textBox9.Text == "")
                //    textBox9.Text = "0";

                double y = 0;
                double z = 0;
                if(textBox16.Text!="")
                 y = double.Parse(textBox16.Text);
                if(textBox9.Text!="")
                 z = double.Parse(textBox9.Text);
                textBox17.Text = (y * z).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (textBox16.Text == "")
                //    textBox16.Text = "0";
                //if (textBox9.Text == "")
                //    textBox9.Text = "0";
                //double y = double.Parse(textBox16.Text);
                //double z = double.Parse(textBox9.Text);
                //textBox17.Text = (y * z).ToString();
                double y = 0;
                double z = 0;
                if (textBox16.Text != "")
                    y = double.Parse(textBox16.Text);
                if (textBox9.Text != "")
                    z = double.Parse(textBox9.Text);
                textBox17.Text = (y * z).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox16.Text == "")
                    textBox16.Text = "0";
                if (textBox9.Text == "")
                    textBox9.Text = "0";
                double y = double.Parse(textBox16.Text);
                double z = double.Parse(textBox9.Text);
                textBox17.Text = (y * z).ToString();

                BL.buy_order b = new BL.buy_order();
                if(textBox10.Text!="")
                b.update_buy(int.Parse(textBox10.Text), textBox9.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    add();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في ادخال البيانات");
                }
            }
        }
        public void add()
        {
            try
            {
                if(comboBox2.Text==""||comboBox1.Text=="")
                {
                    MessageBox.Show(" ادخل اسم المورد والفاتوره"); 
                    return;
                }
                if (textBox10.Text != "0" && textBox10.Text != "")
                {
                    DataRow r = g.NewRow();
                    r[0] = textBox10.Text;
                    r[1] = comboBox3.Text;
                    r[2] = textBox16.Text;
                    r[3] = textBox9.Text;
                    r[4] = textBox17.Text;
                    g.Rows.Add(r);
                    dataGridView2.DataSource = g;
                    comboBox3.Text = "";
                    textBox10.Text = "0";
                    textBox16.Text = "0";
                    textBox17.Text = "0";
                    textBox9.Text = "";
                    double s = 0;
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                        s += double.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                    textBox2.Text = s.ToString();
                    textBox16.Text = "0";
                    textBox17.Text = "0";
                    textBox9.Text = "0";
                    save_order();
                    comboBox3.Focus();
                }
                else
                {
                    MessageBox.Show("اختر صنف");
                }
            }
            catch
            {
                MessageBox.Show("خطأ في البيانات");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BL.orders bl = new BL.orders();
                DataTable dt = new DataTable();
                dt = bl.select_one_product(comboBox3.Text);
                if (dt.Rows.Count > 0)
                {
                    if (textBox16.Text == "")
                        textBox16.Text = "0";
                    string s;
                    textBox10.Text = dt.Rows[0]["product_id"].ToString();
                    textBox9.Text = dt.Rows[0]["buy_price"].ToString();
                    
                    
                    textBox17.Text = (double.Parse(textBox16.Text) * double.Parse(textBox9.Text)).ToString();
                    
                }
            }
            catch {
                comboBox3.Focus();
            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter&&textBox16.Text!="0")
            {
                try
                {

                    add();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في ادخال البيانات");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
           try
           {
               save_order();
           }
            catch
           {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataTable d1, d2;
            d1 = new DataTable();
            d2 = new DataTable();
            int x = int.Parse(textBox1.Text);
            if (x > 1)
            {
            f:
                g.Rows.Clear();
                x--;
                g.Rows.Clear();
                d1.Rows.Clear();
                d2.Rows.Clear();
                d1 = bl.get_buy_order_by_id(x);
                try

                {
                    textBox1.Text = d1.Rows[0]["order_id"].ToString();
                    dateTimePicker1.Text = d1.Rows[0]["date_order"].ToString();
                    comboBox1.Text = d1.Rows[0]["support_name"].ToString();
                    comboBox2.Text = d1.Rows[0]["order_type"].ToString();
                    textBox5.Text = d1.Rows[0]["user_name"].ToString();
                    textBox6.Text = d1.Rows[0]["address"].ToString();
                    textBox4.Text = d1.Rows[0]["support_id"].ToString();
                    textBox7.Text = d1.Rows[0]["phone_numer"].ToString();
                    textBox8.Text = d1.Rows[0]["banq_name"].ToString();
                    textBox3.Text = d1.Rows[0]["banq_number"].ToString();
                    textBox2.Text = d1.Rows[0]["total"].ToString();
                    paid.Text = d1.Rows[0]["paid"].ToString();
                    remaind.Text = d1.Rows[0]["remaind"].ToString();
                    d2 = bl.get_operations_by_order_id(x);
                    g = d2;
                    dataGridView2.DataSource = g;
                       dataGridView2.Refresh();
                       count.Text = (int.Parse(dataGridView2.Rows.Count.ToString()) - 1).ToString();

                }
                   
                catch (Exception ex)
                {
                  //  MessageBox.Show("لا نوجد فاتوره برقم "+"  " +x);
                goto f;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable d1, d2,d3;
            d1 = new DataTable();
            d2 = new DataTable();
            d3=new DataTable();
            int x = int.Parse(textBox1.Text);
            d3=bl.maax_buy_id();
            int z;
            if (d3.Rows[0]["order_id"].ToString() == "")
                z = 0;
            else
            z=int.Parse(d3.Rows[0]["order_id"].ToString());
            if (x<z)
            {
            f:
                g.Rows.Clear();
                x++;
                d1 = bl.get_buy_order_by_id(x);
                try
                {
                    textBox1.Text = d1.Rows[0]["order_id"].ToString();
                    dateTimePicker1.Text = d1.Rows[0]["date_order"].ToString();
                    comboBox1.Text = d1.Rows[0]["support_name"].ToString();
                    comboBox2.Text = d1.Rows[0]["order_type"].ToString();
                    textBox5.Text = d1.Rows[0]["user_name"].ToString();
                    textBox6.Text = d1.Rows[0]["address"].ToString();
                    textBox4.Text = d1.Rows[0]["support_id"].ToString();
                    textBox7.Text = d1.Rows[0]["phone_numer"].ToString();
                    textBox8.Text = d1.Rows[0]["banq_name"].ToString();
                    textBox3.Text = d1.Rows[0]["banq_number"].ToString();
                    textBox2.Text = d1.Rows[0]["total"].ToString();
                    paid.Text = d1.Rows[0]["paid"].ToString();
                    remaind.Text = d1.Rows[0]["remaind"].ToString();
                    d2 = bl.get_operations_by_order_id(x);
                   g = d2;
                    dataGridView2.DataSource = g;
                    dataGridView2.Refresh();
                    count.Text = (int.Parse(dataGridView2.Rows.Count.ToString()) - 1).ToString();

                }
                catch (Exception ex)
                {// MessageBox.Show("لا نوجد فاتوره برقم " + "  " + x);
                goto f;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bl.delete_buy_order(int.Parse(textBox1.Text));
                    bl.delete_buy_operations(int.Parse(textBox1.Text));
                    MessageBox.Show("تم الحذف");
                    new_order();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public bool test_amount(int x, double amount)
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
            if (amount <= av)
            {
                return true;
            }
            else
            {
                MessageBox.Show("الكميه المتاحه " + av.ToString());
                return false;
            }


        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();

                int currentMouseOverRow = dataGridView2.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    my_menu.Items.Add("تعديل").Name = "تحديث";
                    my_menu.Items.Add("حذف").Name = "حذف";
                }

                my_menu.Show(dataGridView2, new Point(e.X, e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);

            }
        }

        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "تحديث")
            {
                try
                {
                    
                        textBox10.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                        comboBox3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                        textBox16.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                        textBox9.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                        textBox17.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();


                        indexOfRow.Text = dataGridView2.CurrentRow.Index.ToString();
                        dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                        double s = 0;
                        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                            s += double.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                        textBox2.Text = s.ToString();
                        
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                comboBox3.Focus();
            }
            else
            {
                try
                {
                    if (test_amount(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), double.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString())))
                    {
                        textBox10.Text = "";
                        comboBox3.SelectedIndex = -1;
                        textBox9.Text = "0";
                        textBox16.Text = "0";
                        textBox17.Text = "0";

                        dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                        double s = 0;
                        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                            s += double.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                        textBox2.Text = s.ToString();
                        comboBox3.Focus();
                        save_order();
                    }
                    comboBox3.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                    textBox2.Text = "0";

                if (paid.Text == "")
                    paid.Text = "0";

                remaind.Text = (double.Parse(textBox2.Text) - double.Parse(paid.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                    textBox2.Text = "0";

                if (paid.Text == "")
                    paid.Text = "0";

                remaind.Text=(double.Parse(textBox2.Text) - double.Parse(paid.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void remaind_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BL.orders bs = new BL.orders();
                DataTable t = new DataTable();
                t = bs.sp_get_products_name();
                comboBox3.DataSource = t;
                comboBox3.DisplayMember = "product_name";
                comboBox3.ValueMember = "product_id";
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.buy_order bl = new BL.buy_order();
            save_order();
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

                    ////wwwwwwwwwww
                    //int x = int.Parse(textBox1.Text);
                    //report.buy_order repor = new report.buy_order();
                    //repor.SetDataSource(bl.get_operations_by_order_id(x));
                    //report.form_report f = new report.form_report();
                    //repor.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                    //f.crystalReportViewer1.ReportSource = repor;

                     //show dialog
                    report.buy_order repor = new report.buy_order();
                    int x = int.Parse(textBox1.Text);
                    repor.SetDataSource(bl.get_operations_by_order_id(x));
                    report.form_report f = new report.form_report();
                    f.crystalReportViewer1.ReportSource = repor;
                    f.ShowDialog();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void indexOfRow_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            oreer_form f = new oreer_form();
            if (Program.isOpen(f.Text))
            {

            }
            else
                f.Show();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    dataGridView2.Rows[i].Selected = false;

                }
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    string x = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    if (x.Contains(textBox21.Text) && textBox21.Text != "")
                    {
                        dataGridView2.Rows[i].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) && c != 8 && c != 46 && c != '.') || (c == '.' && textBox16.Text.Contains('.')))
                e.Handled = true;
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    add();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في ادخال البيانات");
                }
            }
        }
    }
}
