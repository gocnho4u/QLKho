namespace UI
{
    partial class frm_QLNCCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLNCCap));
            this.dt_qlncc = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_huy = new DevExpress.XtraEditors.SimpleButton();
            this.bt_luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_sua = new DevExpress.XtraEditors.SimpleButton();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlncc)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_qlncc
            // 
            this.dt_qlncc.AllowUserToAddRows = false;
            this.dt_qlncc.AllowUserToDeleteRows = false;
            this.dt_qlncc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_qlncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_qlncc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_qlncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_qlncc.Location = new System.Drawing.Point(6, 219);
            this.dt_qlncc.Name = "dt_qlncc";
            this.dt_qlncc.ReadOnly = true;
            this.dt_qlncc.RowHeadersVisible = false;
            this.dt_qlncc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_qlncc.Size = new System.Drawing.Size(788, 224);
            this.dt_qlncc.TabIndex = 17;
            this.dt_qlncc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_qlncc_RowEnter);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.bt_thoat);
            this.panel8.Controls.Add(this.bt_huy);
            this.panel8.Controls.Add(this.bt_luu);
            this.panel8.Controls.Add(this.bt_xoa);
            this.panel8.Controls.Add(this.bt_sua);
            this.panel8.Controls.Add(this.bt_them);
            this.panel8.Controls.Add(this.txt_timkiem);
            this.panel8.Location = new System.Drawing.Point(6, 167);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(788, 46);
            this.panel8.TabIndex = 16;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Appearance.Options.UseFont = true;
            this.bt_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.ImageOptions.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(692, 6);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(90, 34);
            this.bt_thoat.TabIndex = 23;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_huy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Appearance.Options.UseFont = true;
            this.bt_huy.Enabled = false;
            this.bt_huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_huy.ImageOptions.Image")));
            this.bt_huy.Location = new System.Drawing.Point(7, 4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(87, 34);
            this.bt_huy.TabIndex = 15;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_luu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Appearance.Options.UseFont = true;
            this.bt_luu.Enabled = false;
            this.bt_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_luu.ImageOptions.Image")));
            this.bt_luu.Location = new System.Drawing.Point(100, 6);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(83, 34);
            this.bt_luu.TabIndex = 14;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Appearance.Options.UseFont = true;
            this.bt_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.ImageOptions.Image")));
            this.bt_xoa.Location = new System.Drawing.Point(391, 6);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(90, 34);
            this.bt_xoa.TabIndex = 12;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_sua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Appearance.Options.UseFont = true;
            this.bt_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.ImageOptions.Image")));
            this.bt_sua.Location = new System.Drawing.Point(293, 6);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(92, 34);
            this.bt_sua.TabIndex = 11;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_them.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Appearance.Options.UseFont = true;
            this.bt_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.ImageOptions.Image")));
            this.bt_them.Location = new System.Drawing.Point(189, 6);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(98, 34);
            this.bt_them.TabIndex = 10;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_timkiem.Location = new System.Drawing.Point(487, 11);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(199, 26);
            this.txt_timkiem.TabIndex = 9;
            this.txt_timkiem.Text = "Nhập tên hàng hóa cần tìm";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Enter += new System.EventHandler(this.txt_timkiem_Enter);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.panel13);
            this.panelControl3.Controls.Add(this.panel7);
            this.panelControl3.Controls.Add(this.panel6);
            this.panelControl3.Location = new System.Drawing.Point(6, 43);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(788, 118);
            this.panelControl3.TabIndex = 15;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.txt_mancc);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Controls.Add(this.txt_sdt);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.txt_fax);
            this.panel13.Location = new System.Drawing.Point(5, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(777, 37);
            this.panel13.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã nhà cung cấp";
            // 
            // txt_mancc
            // 
            this.txt_mancc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_mancc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mancc.Location = new System.Drawing.Point(131, 5);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(72, 26);
            this.txt_mancc.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số điện thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(303, 5);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(165, 26);
            this.txt_sdt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(474, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fax";
            // 
            // txt_fax
            // 
            this.txt_fax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fax.Location = new System.Drawing.Point(511, 5);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(155, 26);
            this.txt_fax.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.txt_diachi);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(6, 81);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(777, 32);
            this.panel7.TabIndex = 9;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(131, 3);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(640, 26);
            this.txt_diachi.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Địa chỉ";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.txt_tenncc);
            this.panel6.Location = new System.Drawing.Point(5, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(777, 29);
            this.panel6.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 19);
            this.label19.TabIndex = 12;
            this.label19.Text = "Tên nhà cung cấp";
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tenncc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenncc.Location = new System.Drawing.Point(131, 1);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(443, 26);
            this.txt_tenncc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(300, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quản lý nhà cung cấp";
            // 
            // frm_QLNCCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_qlncc);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panelControl3);
            this.Name = "frm_QLNCCap";
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.QLNCCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlncc)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_qlncc;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.SimpleButton bt_huy;
        private DevExpress.XtraEditors.SimpleButton bt_luu;
        private DevExpress.XtraEditors.SimpleButton bt_xoa;
        private DevExpress.XtraEditors.SimpleButton bt_sua;
        private DevExpress.XtraEditors.SimpleButton bt_them;
        private System.Windows.Forms.TextBox txt_timkiem;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private System.Windows.Forms.Label label2;
    }
}