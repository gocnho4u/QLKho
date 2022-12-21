namespace UI
{
    partial class frm_QLTKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLTKhoan));
            this.dt_qlnd = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_huy = new DevExpress.XtraEditors.SimpleButton();
            this.bt_luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_sua = new DevExpress.XtraEditors.SimpleButton();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.bt_kiemtra = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd_khong = new System.Windows.Forms.RadioButton();
            this.rd_co = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlnd)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_qlnd
            // 
            this.dt_qlnd.AllowUserToDeleteRows = false;
            this.dt_qlnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_qlnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_qlnd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_qlnd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_qlnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_qlnd.Location = new System.Drawing.Point(6, 209);
            this.dt_qlnd.Name = "dt_qlnd";
            this.dt_qlnd.ReadOnly = true;
            this.dt_qlnd.RowHeadersVisible = false;
            this.dt_qlnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_qlnd.Size = new System.Drawing.Size(788, 239);
            this.dt_qlnd.TabIndex = 13;
            this.dt_qlnd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_qlnd_RowEnter);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.bt_thoat);
            this.panel4.Controls.Add(this.bt_huy);
            this.panel4.Controls.Add(this.bt_luu);
            this.panel4.Controls.Add(this.bt_xoa);
            this.panel4.Controls.Add(this.bt_sua);
            this.panel4.Controls.Add(this.bt_them);
            this.panel4.Controls.Add(this.txt_timkiem);
            this.panel4.Location = new System.Drawing.Point(6, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 45);
            this.panel4.TabIndex = 12;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Appearance.Options.UseFont = true;
            this.bt_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.ImageOptions.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(695, 6);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(90, 34);
            this.bt_thoat.TabIndex = 14;
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
            this.bt_huy.Location = new System.Drawing.Point(6, 5);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(87, 34);
            this.bt_huy.TabIndex = 9;
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
            this.bt_luu.Location = new System.Drawing.Point(99, 5);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(83, 34);
            this.bt_luu.TabIndex = 8;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Appearance.Options.UseFont = true;
            this.bt_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.ImageOptions.Image")));
            this.bt_xoa.Location = new System.Drawing.Point(389, 5);
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
            this.bt_sua.Location = new System.Drawing.Point(291, 5);
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
            this.bt_them.Location = new System.Drawing.Point(187, 5);
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
            this.txt_timkiem.Location = new System.Drawing.Point(485, 10);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(201, 30);
            this.txt_timkiem.TabIndex = 13;
            this.txt_timkiem.Text = "Nhập mã nhân viên cần tìm";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Enter += new System.EventHandler(this.txt_timkiem_Enter);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // bt_kiemtra
            // 
            this.bt_kiemtra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_kiemtra.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_kiemtra.Appearance.Options.UseFont = true;
            this.bt_kiemtra.Enabled = false;
            this.bt_kiemtra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_kiemtra.ImageOptions.Image")));
            this.bt_kiemtra.Location = new System.Drawing.Point(661, 4);
            this.bt_kiemtra.Name = "bt_kiemtra";
            this.bt_kiemtra.Size = new System.Drawing.Size(119, 31);
            this.bt_kiemtra.TabIndex = 7;
            this.bt_kiemtra.Text = "Kiểm tra";
            this.bt_kiemtra.Click += new System.EventHandler(this.bt_kiemtra_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.bt_kiemtra);
            this.panelControl2.Controls.Add(this.txt_userid);
            this.panelControl2.Controls.Add(this.panel3);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Controls.Add(this.panel2);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Location = new System.Drawing.Point(6, 38);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(788, 118);
            this.panelControl2.TabIndex = 11;
            // 
            // txt_userid
            // 
            this.txt_userid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_userid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.Location = new System.Drawing.Point(129, 6);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.ReadOnly = true;
            this.txt_userid.Size = new System.Drawing.Size(75, 30);
            this.txt_userid.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rd_khong);
            this.panel3.Controls.Add(this.rd_co);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(211, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 32);
            this.panel3.TabIndex = 10;
            // 
            // rd_khong
            // 
            this.rd_khong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_khong.AutoSize = true;
            this.rd_khong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_khong.Location = new System.Drawing.Point(299, 3);
            this.rd_khong.Name = "rd_khong";
            this.rd_khong.Size = new System.Drawing.Size(82, 26);
            this.rd_khong.TabIndex = 3;
            this.rd_khong.TabStop = true;
            this.rd_khong.Text = "Không";
            this.rd_khong.UseVisualStyleBackColor = true;
            // 
            // rd_co
            // 
            this.rd_co.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_co.AutoSize = true;
            this.rd_co.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_co.Location = new System.Drawing.Point(154, 3);
            this.rd_co.Name = "rd_co";
            this.rd_co.Size = new System.Drawing.Size(54, 26);
            this.rd_co.TabIndex = 2;
            this.rd_co.TabStop = true;
            this.rd_co.Text = "Có";
            this.rd_co.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quyền admin:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt_matkhau);
            this.panel1.Controls.Add(this.txt_manv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(5, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 35);
            this.panel1.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 22);
            this.label16.TabIndex = 10;
            this.label16.Text = "Mã nhân viên";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(407, 4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(368, 30);
            this.txt_matkhau.TabIndex = 5;
            // 
            // txt_manv
            // 
            this.txt_manv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_manv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(124, 4);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(189, 30);
            this.txt_manv.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txt_tennv);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 34);
            this.panel2.TabIndex = 9;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tennv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennv.Location = new System.Drawing.Point(123, 0);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.ReadOnly = true;
            this.txt_tennv.Size = new System.Drawing.Size(651, 30);
            this.txt_tennv.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(273, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quản lý tài khoản người dùng";
            // 
            // frm_QLTKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_qlnd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelControl2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_QLTKhoan";
            this.Text = "Quản lý tài khoản phần mềm";
            this.Load += new System.EventHandler(this.QLTKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlnd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_qlnd;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton bt_huy;
        private DevExpress.XtraEditors.SimpleButton bt_luu;
        private DevExpress.XtraEditors.SimpleButton bt_xoa;
        private DevExpress.XtraEditors.SimpleButton bt_sua;
        private DevExpress.XtraEditors.SimpleButton bt_them;
        private System.Windows.Forms.TextBox txt_timkiem;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rd_khong;
        private System.Windows.Forms.RadioButton rd_co;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton bt_kiemtra;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private System.Windows.Forms.Label label2;
    }
}