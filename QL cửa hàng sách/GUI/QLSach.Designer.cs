namespace QL_sách
{
    partial class QLSach
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
            this.Date1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewThongTin = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.cbNgonNgu = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.txtNXB1 = new System.Windows.Forms.TextBox();
            this.txtTacGia1 = new System.Windows.Forms.TextBox();
            this.txtISBN1 = new System.Windows.Forms.TextBox();
            this.txtBookID1 = new System.Windows.Forms.TextBox();
            this.txtTenSach1 = new System.Windows.Forms.TextBox();
            this.cbNgonNgu1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date1
            // 
            this.Date1.Controls.Add(this.tabPage1);
            this.Date1.Controls.Add(this.tabPage2);
            this.Date1.Location = new System.Drawing.Point(0, 0);
            this.Date1.Name = "Date1";
            this.Date1.SelectedIndex = 0;
            this.Date1.Size = new System.Drawing.Size(801, 438);
            this.Date1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewThongTin);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewThongTin
            // 
            this.dataGridViewThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewThongTin.Location = new System.Drawing.Point(6, 231);
            this.dataGridViewThongTin.Name = "dataGridViewThongTin";
            this.dataGridViewThongTin.Size = new System.Drawing.Size(781, 175);
            this.dataGridViewThongTin.TabIndex = 1;
            this.dataGridViewThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongTin_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.cbNgonNgu);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.txtBookID);
            this.panel2.Controls.Add(this.txtISBN);
            this.panel2.Controls.Add(this.txtTacGia);
            this.panel2.Controls.Add(this.txtNXB);
            this.panel2.Controls.Add(this.txtTenSach);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 198);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên Tác Giả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngôn Ngữ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên Sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "ISBN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "BookID";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(100, 172);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(284, 172);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(458, 172);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewTimKiem);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(6, 231);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(781, 175);
            this.dataGridViewTimKiem.TabIndex = 0;
            this.dataGridViewTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTimKiem_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbNgonNgu1);
            this.panel1.Controls.Add(this.txtTenSach1);
            this.panel1.Controls.Add(this.txtBookID1);
            this.panel1.Controls.Add(this.txtISBN1);
            this.panel1.Controls.Add(this.txtTacGia1);
            this.panel1.Controls.Add(this.txtNXB1);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 198);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày Công Bố";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhà Xuất Bản";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(86, 126);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(344, 20);
            this.txtTenSach.TabIndex = 11;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(613, 16);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(100, 20);
            this.txtNXB.TabIndex = 12;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(330, 13);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(100, 20);
            this.txtTacGia.TabIndex = 15;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(86, 67);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 16;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(86, 13);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 20);
            this.txtBookID.TabIndex = 17;
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(613, 67);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 20);
            this.Date.TabIndex = 18;
            // 
            // cbNgonNgu
            // 
            this.cbNgonNgu.FormattingEnabled = true;
            this.cbNgonNgu.Location = new System.Drawing.Point(330, 66);
            this.cbNgonNgu.Name = "cbNgonNgu";
            this.cbNgonNgu.Size = new System.Drawing.Size(100, 21);
            this.cbNgonNgu.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BookID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ISBN";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Sách";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngôn Ngữ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Tác Giả";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nhà Xuất Bản";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày Công Bố";
            this.Column7.Name = "Column7";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BookID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ISBN";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(254, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ngôn Ngữ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(254, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tên Tác Giả";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(527, 90);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(94, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Ngày Công Bố";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(527, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(92, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Nhà Xuất Bản";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(18, 160);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(72, 17);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Tên Sách";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // txtNXB1
            // 
            this.txtNXB1.Location = new System.Drawing.Point(628, 18);
            this.txtNXB1.Name = "txtNXB1";
            this.txtNXB1.Size = new System.Drawing.Size(100, 20);
            this.txtNXB1.TabIndex = 8;
            // 
            // txtTacGia1
            // 
            this.txtTacGia1.Location = new System.Drawing.Point(345, 18);
            this.txtTacGia1.Name = "txtTacGia1";
            this.txtTacGia1.Size = new System.Drawing.Size(100, 20);
            this.txtTacGia1.TabIndex = 9;
            // 
            // txtISBN1
            // 
            this.txtISBN1.Location = new System.Drawing.Point(91, 89);
            this.txtISBN1.Name = "txtISBN1";
            this.txtISBN1.Size = new System.Drawing.Size(100, 20);
            this.txtISBN1.TabIndex = 10;
            // 
            // txtBookID1
            // 
            this.txtBookID1.Location = new System.Drawing.Point(91, 16);
            this.txtBookID1.Name = "txtBookID1";
            this.txtBookID1.Size = new System.Drawing.Size(100, 20);
            this.txtBookID1.TabIndex = 11;
            // 
            // txtTenSach1
            // 
            this.txtTenSach1.Location = new System.Drawing.Point(123, 159);
            this.txtTenSach1.Name = "txtTenSach1";
            this.txtTenSach1.Size = new System.Drawing.Size(342, 20);
            this.txtTenSach1.TabIndex = 12;
            // 
            // cbNgonNgu1
            // 
            this.cbNgonNgu1.FormattingEnabled = true;
            this.cbNgonNgu1.Location = new System.Drawing.Point(345, 89);
            this.cbNgonNgu1.Name = "cbNgonNgu1";
            this.cbNgonNgu1.Size = new System.Drawing.Size(100, 21);
            this.cbNgonNgu1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(628, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(613, 172);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnLoad1
            // 
            this.btnLoad1.Location = new System.Drawing.Point(653, 156);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(75, 23);
            this.btnLoad1.TabIndex = 15;
            this.btnLoad1.Text = "Load";
            this.btnLoad1.UseVisualStyleBackColor = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "BookID";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ISBN";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tên Sách";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ngôn Ngữ";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Tên Tác Giả";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Nhà Xuất Bản";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Ngày Công Bố";
            this.Column14.Name = "Column14";
            // 
            // QLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date1);
            this.Name = "QLSach";
            this.Text = "Form1";
            this.Date1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Date1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewThongTin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cbNgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtTenSach1;
        private System.Windows.Forms.TextBox txtBookID1;
        private System.Windows.Forms.TextBox txtISBN1;
        private System.Windows.Forms.TextBox txtTacGia1;
        private System.Windows.Forms.TextBox txtNXB1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbNgonNgu1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}

