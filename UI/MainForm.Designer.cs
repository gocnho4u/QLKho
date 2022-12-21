namespace UI
{
    partial class frm_MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_Quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLPNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Quanly,
            this.lậpPhiếuToolStripMenuItem,
            this.frm_baocao});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_Quanly
            // 
            this.menu_Quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgườiDùngToolStripMenuItem,
            this.quảnLýHàngHóaToolStripMenuItem,
            this.quảnLýNhàCungCấpToolStripMenuItem,
            this.QLPNhap,
            this.quảnLýĐơnHàngToolStripMenuItem,
            this.quảnLýPhiếuXuấtToolStripMenuItem});
            this.menu_Quanly.Name = "menu_Quanly";
            this.menu_Quanly.Size = new System.Drawing.Size(71, 24);
            this.menu_Quanly.Text = "Quản lý";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.U)));
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            this.quảnLýNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườiDùngToolStripMenuItem_Click);
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Quản lý hàng hóa";
            this.quảnLýHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHàngHóaToolStripMenuItem_Click);
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            this.quảnLýNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàCungCấpToolStripMenuItem_Click);
            // 
            // QLPNhap
            // 
            this.QLPNhap.Name = "QLPNhap";
            this.QLPNhap.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.QLPNhap.Size = new System.Drawing.Size(305, 26);
            this.QLPNhap.Text = "Quản lý phiếu nhập";
            this.QLPNhap.Click += new System.EventHandler(this.QLPNhap_Click);
            // 
            // quảnLýĐơnHàngToolStripMenuItem
            // 
            this.quảnLýĐơnHàngToolStripMenuItem.Name = "quảnLýĐơnHàngToolStripMenuItem";
            this.quảnLýĐơnHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.quảnLýĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.quảnLýĐơnHàngToolStripMenuItem.Text = "Quản lý đơn hàng";
            // 
            // quảnLýPhiếuXuấtToolStripMenuItem
            // 
            this.quảnLýPhiếuXuấtToolStripMenuItem.Name = "quảnLýPhiếuXuấtToolStripMenuItem";
            this.quảnLýPhiếuXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.quảnLýPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.quảnLýPhiếuXuấtToolStripMenuItem.Text = "Quản lý phiếu xuất";
            // 
            // lậpPhiếuToolStripMenuItem
            // 
            this.lậpPhiếuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuNhậpToolStripMenuItem,
            this.phiếuXuấtToolStripMenuItem});
            this.lậpPhiếuToolStripMenuItem.Name = "lậpPhiếuToolStripMenuItem";
            this.lậpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.lậpPhiếuToolStripMenuItem.Text = "Lập phiếu";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            this.phiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.PhieuNhap_Click);
            // 
            // phiếuXuấtToolStripMenuItem
            // 
            this.phiếuXuấtToolStripMenuItem.Name = "phiếuXuấtToolStripMenuItem";
            this.phiếuXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.phiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.phiếuXuấtToolStripMenuItem.Text = "Phiếu xuất";
            this.phiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.phiếuXuấtToolStripMenuItem_Click);
            // 
            // frm_baocao
            // 
            this.frm_baocao.Name = "frm_baocao";
            this.frm_baocao.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.frm_baocao.Size = new System.Drawing.Size(75, 24);
            this.frm_baocao.Text = "Báo cáo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 529);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(601, 530);
            this.lb_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(70, 27);
            this.lb_time.TabIndex = 5;
            this.lb_time.Text = "label2";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 536);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menu_Quanly;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLPNhap;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frm_baocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}



