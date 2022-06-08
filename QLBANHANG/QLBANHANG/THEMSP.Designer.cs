namespace QLBANHANG
{
    partial class THEMSP
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
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_tenhh = new System.Windows.Forms.TextBox();
            this.txt_mahh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_taomoi = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.dtg_hanghoa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dongia);
            this.groupBox1.Controls.Add(this.txt_tenhh);
            this.groupBox1.Controls.Add(this.txt_mahh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(363, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(181, 124);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(152, 28);
            this.txt_dongia.TabIndex = 1;
            // 
            // txt_tenhh
            // 
            this.txt_tenhh.Location = new System.Drawing.Point(181, 86);
            this.txt_tenhh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenhh.Name = "txt_tenhh";
            this.txt_tenhh.Size = new System.Drawing.Size(152, 28);
            this.txt_tenhh.TabIndex = 1;
            // 
            // txt_mahh
            // 
            this.txt_mahh.Location = new System.Drawing.Point(181, 46);
            this.txt_mahh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mahh.Name = "txt_mahh";
            this.txt_mahh.ReadOnly = true;
            this.txt_mahh.Size = new System.Drawing.Size(152, 28);
            this.txt_mahh.TabIndex = 1;
            this.txt_mahh.TextChanged += new System.EventHandler(this.txt_mahh_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hàng hóa:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hóa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_taomoi
            // 
            this.bt_taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_taomoi.Location = new System.Drawing.Point(405, 46);
            this.bt_taomoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_taomoi.Name = "bt_taomoi";
            this.bt_taomoi.Size = new System.Drawing.Size(100, 34);
            this.bt_taomoi.TabIndex = 1;
            this.bt_taomoi.Text = "Tạo mới";
            this.bt_taomoi.UseVisualStyleBackColor = true;
            this.bt_taomoi.Click += new System.EventHandler(this.bt_taomoi_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(405, 130);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(100, 34);
            this.bt_luu.TabIndex = 1;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // dtg_hanghoa
            // 
            this.dtg_hanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hanghoa.Location = new System.Drawing.Point(13, 203);
            this.dtg_hanghoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_hanghoa.Name = "dtg_hanghoa";
            this.dtg_hanghoa.RowHeadersWidth = 51;
            this.dtg_hanghoa.RowTemplate.Height = 24;
            this.dtg_hanghoa.Size = new System.Drawing.Size(493, 220);
            this.dtg_hanghoa.TabIndex = 2;
            this.dtg_hanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hanghoa_CellContentClick);
            // 
            // THEMSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 454);
            this.Controls.Add(this.dtg_hanghoa);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_taomoi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "THEMSP";
            this.Text = "THEMSP";
            this.Load += new System.EventHandler(this.THEMSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hanghoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_tenhh;
        private System.Windows.Forms.TextBox txt_mahh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_taomoi;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridView dtg_hanghoa;
    }
}