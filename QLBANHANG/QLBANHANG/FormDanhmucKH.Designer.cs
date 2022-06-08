namespace QLBANHANG
{
    partial class FormDanhmucKH
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
            this.bt_close = new System.Windows.Forms.Button();
            this.dtg_showkh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showkh)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Location = new System.Drawing.Point(1, 323);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(632, 66);
            this.bt_close.TabIndex = 5;
            this.bt_close.Text = "THOÁT";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // dtg_showkh
            // 
            this.dtg_showkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showkh.Location = new System.Drawing.Point(1, 44);
            this.dtg_showkh.Name = "dtg_showkh";
            this.dtg_showkh.RowHeadersWidth = 51;
            this.dtg_showkh.RowTemplate.Height = 24;
            this.dtg_showkh.Size = new System.Drawing.Size(632, 252);
            this.dtg_showkh.TabIndex = 4;
            this.dtg_showkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showkh_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // FormDanhmucKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 371);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.dtg_showkh);
            this.Controls.Add(this.label1);
            this.Name = "FormDanhmucKH";
            this.Text = "FormDanhmucKH";
            this.Load += new System.EventHandler(this.FormDanhmucKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showkh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DataGridView dtg_showkh;
        private System.Windows.Forms.Label label1;
    }
}