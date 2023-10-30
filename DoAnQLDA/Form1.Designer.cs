namespace DoAnQLDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlThongTinSanPham = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tsNguoiDung = new System.Windows.Forms.ToolStrip();
            this.tsBtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsDangNhap = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNguoiDung = new System.Windows.Forms.ToolStripSplitButton();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNV = new System.Windows.Forms.ToolStripButton();
            this.btnQLDH = new System.Windows.Forms.ToolStripButton();
            this.btnQLX = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlThongTinSanPham.SuspendLayout();
            this.tsNguoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTinSanPham
            // 
            this.pnlThongTinSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongTinSanPham.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlThongTinSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlThongTinSanPham.BackgroundImage")));
            this.pnlThongTinSanPham.Controls.Add(this.label1);
            this.pnlThongTinSanPham.Controls.Add(this.button1);
            this.pnlThongTinSanPham.ForeColor = System.Drawing.SystemColors.Info;
            this.pnlThongTinSanPham.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlThongTinSanPham.Location = new System.Drawing.Point(0, 35);
            this.pnlThongTinSanPham.Name = "pnlThongTinSanPham";
            this.pnlThongTinSanPham.Size = new System.Drawing.Size(1154, 888);
            this.pnlThongTinSanPham.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 118);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vận chuyển ngay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tsNguoiDung
            // 
            this.tsNguoiDung.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsNguoiDung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnHome,
            this.tsDangNhap,
            this.tsBtnNguoiDung,
            this.btnQLNV,
            this.btnQLDH,
            this.btnQLX});
            this.tsNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.tsNguoiDung.Name = "tsNguoiDung";
            this.tsNguoiDung.Size = new System.Drawing.Size(1147, 47);
            this.tsNguoiDung.TabIndex = 16;
            this.tsNguoiDung.Text = "toolStrip1";
            // 
            // tsBtnHome
            // 
            this.tsBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnHome.Image")));
            this.tsBtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHome.Name = "tsBtnHome";
            this.tsBtnHome.Size = new System.Drawing.Size(117, 44);
            this.tsBtnHome.Text = "Trang chủ";
            this.tsBtnHome.Click += new System.EventHandler(this.tsBtnHome_Click);
            // 
            // tsDangNhap
            // 
            this.tsDangNhap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsDangNhap.Image")));
            this.tsDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDangNhap.Name = "tsDangNhap";
            this.tsDangNhap.Size = new System.Drawing.Size(126, 44);
            this.tsDangNhap.Text = "Đăng nhập";
            this.tsDangNhap.Click += new System.EventHandler(this.tsDangNhap_Click);
            // 
            // tsBtnNguoiDung
            // 
            this.tsBtnNguoiDung.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnNguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.tsBtnNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNguoiDung.Image")));
            this.tsBtnNguoiDung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNguoiDung.Name = "tsBtnNguoiDung";
            this.tsBtnNguoiDung.Size = new System.Drawing.Size(172, 44);
            this.tsBtnNguoiDung.Text = "Tên người dùng";
            this.tsBtnNguoiDung.Visible = false;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQLNV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.Image")));
            this.btnQLNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(130, 44);
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.Visible = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLDH
            // 
            this.btnQLDH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQLDH.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDH.Image")));
            this.btnQLDH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQLDH.Name = "btnQLDH";
            this.btnQLDH.Size = new System.Drawing.Size(130, 44);
            this.btnQLDH.Text = "Quản lý đơn hàng";
            this.btnQLDH.Visible = false;
            this.btnQLDH.Click += new System.EventHandler(this.btnQLDH_Click);
            // 
            // btnQLX
            // 
            this.btnQLX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQLX.Image = ((System.Drawing.Image)(resources.GetObject("btnQLX.Image")));
            this.btnQLX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQLX.Name = "btnQLX";
            this.btnQLX.Size = new System.Drawing.Size(82, 44);
            this.btnQLX.Text = "Quản lý xe";
            this.btnQLX.Visible = false;
            this.btnQLX.Click += new System.EventHandler(this.btnQLX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(206)))), ((int)(((byte)(190)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(797, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Công ty Vận chuyển Logictics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 921);
            this.Controls.Add(this.tsNguoiDung);
            this.Controls.Add(this.pnlThongTinSanPham);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
            this.pnlThongTinSanPham.ResumeLayout(false);
            this.pnlThongTinSanPham.PerformLayout();
            this.tsNguoiDung.ResumeLayout(false);
            this.tsNguoiDung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTinSanPham;
        private System.Windows.Forms.ToolStrip tsNguoiDung;
        private System.Windows.Forms.ToolStripButton tsBtnHome;
        private System.Windows.Forms.ToolStripButton tsDangNhap;
        private System.Windows.Forms.ToolStripSplitButton tsBtnNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton btnQLNV;
        private System.Windows.Forms.ToolStripButton btnQLDH;
        private System.Windows.Forms.ToolStripButton btnQLX;
        private System.Windows.Forms.Label label1;
    }
}

