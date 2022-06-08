namespace QLBANHANG
{
    partial class DanhMucNhacc
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_showNcc = new System.Windows.Forms.DataGridView();
            this.bt_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showNcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // dtg_showNcc
            // 
            this.dtg_showNcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showNcc.Location = new System.Drawing.Point(2, 54);
            this.dtg_showNcc.Name = "dtg_showNcc";
            this.dtg_showNcc.RowHeadersWidth = 51;
            this.dtg_showNcc.RowTemplate.Height = 24;
            this.dtg_showNcc.Size = new System.Drawing.Size(632, 252);
            this.dtg_showNcc.TabIndex = 1;
            this.dtg_showNcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showNcc_CellContentClick);
            // 
            // bt_close
            // 
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Location = new System.Drawing.Point(2, 328);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(632, 66);
            this.bt_close.TabIndex = 2;
            this.bt_close.Text = "THOÁT";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // DanhMucNhacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 393);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.dtg_showNcc);
            this.Controls.Add(this.label1);
            this.Name = "DanhMucNhacc";
            this.Text = "DanhMucNhacc";
            this.Load += new System.EventHandler(this.DanhMucNhacc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showNcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_showNcc;
        private System.Windows.Forms.Button bt_close;
    }
}