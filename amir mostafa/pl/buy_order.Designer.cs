namespace amir_mostafa.pl
{
    partial class buy_order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamwinDataSet7 = new amir_mostafa.tamwinDataSet7();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.remaind = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.productsTableAdapter = new amir_mostafa.tamwinDataSet7TableAdapters.productsTableAdapter();
            this.button15 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.indexOfRow = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 403);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1236, 327);
            this.dataGridView2.TabIndex = 49;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.tamwinDataSet7;
            // 
            // tamwinDataSet7
            // 
            this.tamwinDataSet7.DataSetName = "tamwinDataSet7";
            this.tamwinDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox21);
            this.groupBox1.Controls.Add(this.count);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.remaind);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.paid);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(32, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 220);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتوره";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.Info;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(126, 171);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(301, 38);
            this.textBox21.TabIndex = 78;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // count
            // 
            this.count.BackColor = System.Drawing.SystemColors.Info;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(126, 131);
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Size = new System.Drawing.Size(301, 34);
            this.count.TabIndex = 80;
            this.count.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(444, 174);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 32);
            this.label34.TabIndex = 79;
            this.label34.Text = "بحث";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(433, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 29);
            this.label14.TabIndex = 79;
            this.label14.Text = "العدد :";
            // 
            // remaind
            // 
            this.remaind.BackColor = System.Drawing.SystemColors.Info;
            this.remaind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaind.Location = new System.Drawing.Point(126, 91);
            this.remaind.Name = "remaind";
            this.remaind.ReadOnly = true;
            this.remaind.Size = new System.Drawing.Size(301, 34);
            this.remaind.TabIndex = 78;
            this.remaind.Text = "0";
            this.remaind.TextChanged += new System.EventHandler(this.remaind_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(433, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 29);
            this.label13.TabIndex = 77;
            this.label13.Text = "الباقي :";
            // 
            // paid
            // 
            this.paid.BackColor = System.Drawing.SystemColors.Info;
            this.paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid.Location = new System.Drawing.Point(126, 54);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(301, 34);
            this.paid.TabIndex = 76;
            this.paid.Text = "0";
            this.paid.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(433, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 29);
            this.label12.TabIndex = 75;
            this.label12.Text = "المدفوع :";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Info;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(-246, 129);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(281, 34);
            this.textBox8.TabIndex = 74;
            this.textBox8.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(-246, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(281, 34);
            this.textBox7.TabIndex = 73;
            this.textBox7.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(-246, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(281, 34);
            this.textBox4.TabIndex = 72;
            this.textBox4.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(-246, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(281, 34);
            this.textBox6.TabIndex = 71;
            this.textBox6.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(-246, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(281, 34);
            this.textBox3.TabIndex = 70;
            this.textBox3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 69;
            this.label7.Text = "رقم حساب البنك :";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 68;
            this.label8.Text = "موبايل المورد :";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 29);
            this.label9.TabIndex = 67;
            this.label9.Text = "اسم البنك :";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 29);
            this.label10.TabIndex = 66;
            this.label10.Text = "رقم المورد :";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 29);
            this.label11.TabIndex = 65;
            this.label11.Text = "العنوان :";
            this.label11.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(-246, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(281, 34);
            this.textBox5.TabIndex = 2;
            this.textBox5.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(126, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 34);
            this.textBox2.TabIndex = 62;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "اسم المستخدم :";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 61;
            this.label6.Text = "الاجمالي :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1052, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "اسم المورد :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1052, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 56;
            this.label4.Text = "نوع الفاتوره :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1052, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "تاريخ الفاتوره :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1052, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "رقم الفاتوره :";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "شراء",
            "افتتاحيه"});
            this.comboBox2.Location = new System.Drawing.Point(596, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(422, 37);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(596, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(422, 34);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(596, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(422, 37);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(596, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(422, 34);
            this.textBox1.TabIndex = 47;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(267, 309);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(259, 27);
            this.textBox10.TabIndex = 71;
            this.textBox10.Visible = false;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Sienna;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Location = new System.Drawing.Point(519, 25);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(172, 82);
            this.button15.TabIndex = 61;
            this.button15.Text = "حذف فاتوره";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Sienna;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(350, 25);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(172, 82);
            this.button12.TabIndex = 60;
            this.button12.Text = "تعديل فاتوره";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Sienna;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(188, 25);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(165, 82);
            this.button11.TabIndex = 58;
            this.button11.Text = "حفظ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Sienna;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(33, 25);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 82);
            this.button10.TabIndex = 57;
            this.button10.Text = "فاتوره جديده";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Info;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(758, 371);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(268, 34);
            this.textBox17.TabIndex = 66;
            this.textBox17.Text = "0";
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Info;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(267, 372);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(245, 34);
            this.textBox16.TabIndex = 4;
            this.textBox16.Text = "0";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            this.textBox16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox16_KeyDown);
            this.textBox16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox16_KeyPress);
            this.textBox16.Leave += new System.EventHandler(this.textBox16_Leave);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(511, 372);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(250, 34);
            this.textBox9.TabIndex = 64;
            this.textBox9.Text = "0";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox9_KeyDown);
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox3.DisplayMember = "clint_name";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(17, 368);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 37);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.ValueMember = "clint_id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox3_KeyDown);
            this.comboBox3.Leave += new System.EventHandler(this.comboBox3_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(865, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 29);
            this.label21.TabIndex = 70;
            this.label21.Text = "الاجمالي";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(566, 340);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 29);
            this.label22.TabIndex = 69;
            this.label22.Text = "سعر الوحده";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(338, 340);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 29);
            this.label20.TabIndex = 68;
            this.label20.Text = "العدد";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(77, 336);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 29);
            this.label19.TabIndex = 67;
            this.label19.Text = "اسم الصنف";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Sienna;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(1041, 25);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(104, 82);
            this.button13.TabIndex = 59;
            this.button13.Text = "السابق";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1151, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 82);
            this.button1.TabIndex = 71;
            this.button1.Text = "التالي";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // indexOfRow
            // 
            this.indexOfRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexOfRow.Location = new System.Drawing.Point(558, 305);
            this.indexOfRow.Name = "indexOfRow";
            this.indexOfRow.Size = new System.Drawing.Size(150, 27);
            this.indexOfRow.TabIndex = 72;
            this.indexOfRow.Visible = false;
            this.indexOfRow.TextChanged += new System.EventHandler(this.indexOfRow_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 52);
            this.button2.TabIndex = 73;
            this.button2.Text = "تحديث";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Sienna;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(692, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 82);
            this.button3.TabIndex = 74;
            this.button3.Text = "طباعه";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Sienna;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(863, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 82);
            this.button4.TabIndex = 75;
            this.button4.Text = "فاتوره بيع";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buy_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1272, 849);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.indexOfRow);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "buy_order";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتوره شراء";
            this.Load += new System.EventHandler(this.buy_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamwinDataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.Button button15;
        public System.Windows.Forms.Button button12;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBox17;
        public System.Windows.Forms.TextBox textBox16;
        public System.Windows.Forms.TextBox textBox9;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox textBox10;
        public System.Windows.Forms.GroupBox groupBox1;
        public tamwinDataSet7 tamwinDataSet7;
        public System.Windows.Forms.BindingSource productsBindingSource;
        public tamwinDataSet7TableAdapters.productsTableAdapter productsTableAdapter;
        public System.Windows.Forms.Button button13;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox indexOfRow;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox remaind;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox paid;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox count;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox textBox21;
        public System.Windows.Forms.Label label34;

    }
}