namespace QLBANHANG
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_chungtugoc = new System.Windows.Forms.TextBox();
            this.dtp_ngaypn = new System.Windows.Forms.DateTimePicker();
            this.cb_ncc = new System.Windows.Forms.ComboBox();
            this.cb_nv = new System.Windows.Forms.ComboBox();
            this.bt_themncc = new System.Windows.Forms.Button();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_diengiai = new System.Windows.Forms.TextBox();
            this.txt_sopn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txt_tongcong = new System.Windows.Forms.TextBox();
            this.txt_chietkhau = new System.Windows.Forms.TextBox();
            this.txt_thue = new System.Windows.Forms.TextBox();
            this.txt_tienhang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_timten = new System.Windows.Forms.RadioButton();
            this.rd_timma = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtg_hanghoa = new System.Windows.Forms.DataGridView();
            this.dtg_ctpn = new System.Windows.Forms.DataGridView();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_themsp = new System.Windows.Forms.Button();
            this.bt_taomoi = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ctpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_chungtugoc);
            this.groupBox1.Controls.Add(this.dtp_ngaypn);
            this.groupBox1.Controls.Add(this.cb_ncc);
            this.groupBox1.Controls.Add(this.cb_nv);
            this.groupBox1.Controls.Add(this.bt_themncc);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.txt_diengiai);
            this.groupBox1.Controls.Add(this.txt_sopn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(519, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập kho";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_chungtugoc
            // 
            this.txt_chungtugoc.Location = new System.Drawing.Point(160, 68);
            this.txt_chungtugoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chungtugoc.Name = "txt_chungtugoc";
            this.txt_chungtugoc.Size = new System.Drawing.Size(341, 27);
            this.txt_chungtugoc.TabIndex = 6;
            // 
            // dtp_ngaypn
            // 
            this.dtp_ngaypn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaypn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaypn.Location = new System.Drawing.Point(389, 30);
            this.dtp_ngaypn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngaypn.Name = "dtp_ngaypn";
            this.dtp_ngaypn.Size = new System.Drawing.Size(112, 27);
            this.dtp_ngaypn.TabIndex = 5;
            this.dtp_ngaypn.Value = new System.DateTime(2022, 4, 2, 0, 0, 0, 0);
            // 
            // cb_ncc
            // 
            this.cb_ncc.FormattingEnabled = true;
            this.cb_ncc.Location = new System.Drawing.Point(160, 104);
            this.cb_ncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ncc.Name = "cb_ncc";
            this.cb_ncc.Size = new System.Drawing.Size(256, 28);
            this.cb_ncc.TabIndex = 4;
            this.cb_ncc.SelectedIndexChanged += new System.EventHandler(this.cb_ncc_SelectedIndexChanged);
            // 
            // cb_nv
            // 
            this.cb_nv.FormattingEnabled = true;
            this.cb_nv.Location = new System.Drawing.Point(387, 178);
            this.cb_nv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(116, 28);
            this.cb_nv.TabIndex = 2;
            this.cb_nv.SelectedIndexChanged += new System.EventHandler(this.cb_nv_SelectedIndexChanged);
            // 
            // bt_themncc
            // 
            this.bt_themncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themncc.Location = new System.Drawing.Point(421, 101);
            this.bt_themncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_themncc.Name = "bt_themncc";
            this.bt_themncc.Size = new System.Drawing.Size(80, 30);
            this.bt_themncc.TabIndex = 3;
            this.bt_themncc.Text = "+";
            this.bt_themncc.UseVisualStyleBackColor = true;
            this.bt_themncc.Click += new System.EventHandler(this.bt_themncc_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(160, 182);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(100, 27);
            this.txt_ghichu.TabIndex = 1;
            // 
            // txt_diengiai
            // 
            this.txt_diengiai.Location = new System.Drawing.Point(160, 137);
            this.txt_diengiai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_diengiai.Name = "txt_diengiai";
            this.txt_diengiai.Size = new System.Drawing.Size(343, 27);
            this.txt_diengiai.TabIndex = 1;
            // 
            // txt_sopn
            // 
            this.txt_sopn.Location = new System.Drawing.Point(160, 32);
            this.txt_sopn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sopn.Name = "txt_sopn";
            this.txt_sopn.ReadOnly = true;
            this.txt_sopn.Size = new System.Drawing.Size(100, 27);
            this.txt_sopn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhân viên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Diễn giải :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà cung cấp* :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Chứng từ gốc :";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày* :";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số PN* :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.txt_tongcong);
            this.groupBox2.Controls.Add(this.txt_chietkhau);
            this.groupBox2.Controls.Add(this.txt_thue);
            this.groupBox2.Controls.Add(this.txt_tienhang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(537, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(395, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng cộng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(131, 102);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(131, 69);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txt_tongcong
            // 
            this.txt_tongcong.Location = new System.Drawing.Point(131, 178);
            this.txt_tongcong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongcong.Name = "txt_tongcong";
            this.txt_tongcong.Size = new System.Drawing.Size(257, 27);
            this.txt_tongcong.TabIndex = 1;
            // 
            // txt_chietkhau
            // 
            this.txt_chietkhau.Location = new System.Drawing.Point(261, 101);
            this.txt_chietkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chietkhau.Name = "txt_chietkhau";
            this.txt_chietkhau.Size = new System.Drawing.Size(127, 27);
            this.txt_chietkhau.TabIndex = 1;
            // 
            // txt_thue
            // 
            this.txt_thue.Location = new System.Drawing.Point(261, 69);
            this.txt_thue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_thue.Name = "txt_thue";
            this.txt_thue.Size = new System.Drawing.Size(127, 27);
            this.txt_thue.TabIndex = 1;
            // 
            // txt_tienhang
            // 
            this.txt_tienhang.Location = new System.Drawing.Point(131, 37);
            this.txt_tienhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tienhang.Name = "txt_tienhang";
            this.txt_tienhang.Size = new System.Drawing.Size(257, 27);
            this.txt_tienhang.TabIndex = 1;
            this.txt_tienhang.TextChanged += new System.EventHandler(this.txt_tienhang_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tổng cộng :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chiết khấu :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thuế :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiền hàng :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_timten);
            this.groupBox3.Controls.Add(this.rd_timma);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 287);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(192, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn tìm kiếm";
            // 
            // rd_timten
            // 
            this.rd_timten.AutoSize = true;
            this.rd_timten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_timten.Location = new System.Drawing.Point(11, 66);
            this.rd_timten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rd_timten.Name = "rd_timten";
            this.rd_timten.Size = new System.Drawing.Size(164, 24);
            this.rd_timten.TabIndex = 1;
            this.rd_timten.TabStop = true;
            this.rd_timten.Text = "Tìm theo tên hàng";
            this.rd_timten.UseVisualStyleBackColor = true;
            // 
            // rd_timma
            // 
            this.rd_timma.AutoSize = true;
            this.rd_timma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_timma.Location = new System.Drawing.Point(11, 26);
            this.rd_timma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rd_timma.Name = "rd_timma";
            this.rd_timma.Size = new System.Drawing.Size(164, 24);
            this.rd_timma.TabIndex = 1;
            this.rd_timma.TabStop = true;
            this.rd_timma.Text = "Tìm theo mã hàng";
            this.rd_timma.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 110);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Tìm từ kí tự bắt đầu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtg_hanghoa
            // 
            this.dtg_hanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hanghoa.Location = new System.Drawing.Point(232, 278);
            this.dtg_hanghoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_hanghoa.Name = "dtg_hanghoa";
            this.dtg_hanghoa.RowHeadersWidth = 51;
            this.dtg_hanghoa.RowTemplate.Height = 24;
            this.dtg_hanghoa.Size = new System.Drawing.Size(694, 160);
            this.dtg_hanghoa.TabIndex = 3;
            this.dtg_hanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hanghoa_CellContentClick);
            // 
            // dtg_ctpn
            // 
            this.dtg_ctpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ctpn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.TENHANG,
            this.SOLUONG,
            this.GIANHAP,
            this.THANHTIEN});
            this.dtg_ctpn.Location = new System.Drawing.Point(12, 444);
            this.dtg_ctpn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_ctpn.Name = "dtg_ctpn";
            this.dtg_ctpn.RowHeadersWidth = 51;
            this.dtg_ctpn.RowTemplate.Height = 24;
            this.dtg_ctpn.Size = new System.Drawing.Size(914, 153);
            this.dtg_ctpn.TabIndex = 4;
            this.dtg_ctpn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ctpn_CellContentClick);
            // 
            // MAHANG
            // 
            this.MAHANG.DataPropertyName = "MaHH";
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.MinimumWidth = 6;
            this.MAHANG.Name = "MAHANG";
            this.MAHANG.Width = 125;
            // 
            // TENHANG
            // 
            this.TENHANG.DataPropertyName = "TenHH";
            this.TENHANG.HeaderText = "Tên hàng";
            this.TENHANG.MinimumWidth = 6;
            this.TENHANG.Name = "TENHANG";
            this.TENHANG.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "DonGia";
            this.GIANHAP.HeaderText = "Gía nhập";
            this.GIANHAP.MinimumWidth = 6;
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tìm kiếm :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(148, 246);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(269, 22);
            this.txt_timkiem.TabIndex = 1;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(423, 242);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(83, 31);
            this.bt_tim.TabIndex = 3;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(512, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số lượng :";
            this.label13.Click += new System.EventHandler(this.label12_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(602, 247);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown3.TabIndex = 5;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(712, 243);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(77, 31);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_themsp
            // 
            this.bt_themsp.Location = new System.Drawing.Point(798, 243);
            this.bt_themsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_themsp.Name = "bt_themsp";
            this.bt_themsp.Size = new System.Drawing.Size(109, 31);
            this.bt_themsp.TabIndex = 7;
            this.bt_themsp.Text = "Thêm sp";
            this.bt_themsp.UseVisualStyleBackColor = true;
            this.bt_themsp.Click += new System.EventHandler(this.bt_themsp_Click);
            // 
            // bt_taomoi
            // 
            this.bt_taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_taomoi.Location = new System.Drawing.Point(624, 602);
            this.bt_taomoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_taomoi.Name = "bt_taomoi";
            this.bt_taomoi.Size = new System.Drawing.Size(119, 38);
            this.bt_taomoi.TabIndex = 8;
            this.bt_taomoi.Text = "Tạo mới";
            this.bt_taomoi.UseVisualStyleBackColor = true;
            this.bt_taomoi.Click += new System.EventHandler(this.bt_taomoi_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(755, 602);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(119, 38);
            this.bt_luu.TabIndex = 8;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 652);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_taomoi);
            this.Controls.Add(this.bt_themsp);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.dtg_ctpn);
            this.Controls.Add(this.dtg_hanghoa);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ctpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_themncc;
        private System.Windows.Forms.ComboBox cb_nv;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_diengiai;
        private System.Windows.Forms.TextBox txt_sopn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngaypn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txt_tongcong;
        private System.Windows.Forms.TextBox txt_chietkhau;
        private System.Windows.Forms.TextBox txt_thue;
        private System.Windows.Forms.TextBox txt_tienhang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_timten;
        private System.Windows.Forms.RadioButton rd_timma;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dtg_hanghoa;
        private System.Windows.Forms.DataGridView dtg_ctpn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_chungtugoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_themsp;
        private System.Windows.Forms.Button bt_taomoi;
        private System.Windows.Forms.Button bt_luu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.ComboBox cb_ncc;
    }
}

