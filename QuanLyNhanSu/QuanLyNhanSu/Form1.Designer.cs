namespace QuanLyNhanSu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tTCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tTCaNhanToolStripMenuItem,
            this.dangKyToolStripMenuItem,
            this.timKiemToolStripMenuItem,
            this.nhanSuToolStripMenuItem,
            this.phongBanToolStripMenuItem,
            this.boPhanToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(765, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tTCaNhanToolStripMenuItem
            // 
            this.tTCaNhanToolStripMenuItem.Name = "tTCaNhanToolStripMenuItem";
            this.tTCaNhanToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.tTCaNhanToolStripMenuItem.Text = "TTCaNhan";
            this.tTCaNhanToolStripMenuItem.Click += new System.EventHandler(this.tTCaNhanToolStripMenuItem_Click);
            // 
            // dangKyToolStripMenuItem
            // 
            this.dangKyToolStripMenuItem.Name = "dangKyToolStripMenuItem";
            this.dangKyToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.dangKyToolStripMenuItem.Text = "DangKy";
            this.dangKyToolStripMenuItem.Click += new System.EventHandler(this.dangKyToolStripMenuItem_Click);
            // 
            // timKiemToolStripMenuItem
            // 
            this.timKiemToolStripMenuItem.Name = "timKiemToolStripMenuItem";
            this.timKiemToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.timKiemToolStripMenuItem.Text = "TimKiem";
            this.timKiemToolStripMenuItem.Click += new System.EventHandler(this.timKiemToolStripMenuItem_Click);
            // 
            // nhanSuToolStripMenuItem
            // 
            this.nhanSuToolStripMenuItem.Name = "nhanSuToolStripMenuItem";
            this.nhanSuToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.nhanSuToolStripMenuItem.Text = "NhanSu";
            this.nhanSuToolStripMenuItem.Click += new System.EventHandler(this.nhanSuToolStripMenuItem_Click);
            // 
            // phongBanToolStripMenuItem
            // 
            this.phongBanToolStripMenuItem.Name = "phongBanToolStripMenuItem";
            this.phongBanToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.phongBanToolStripMenuItem.Text = "PhongBan";
            this.phongBanToolStripMenuItem.Click += new System.EventHandler(this.phongBanToolStripMenuItem_Click);
            // 
            // boPhanToolStripMenuItem
            // 
            this.boPhanToolStripMenuItem.Name = "boPhanToolStripMenuItem";
            this.boPhanToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.boPhanToolStripMenuItem.Text = "BoPhan";
            this.boPhanToolStripMenuItem.Click += new System.EventHandler(this.boPhanToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 502);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tTCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangKyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timKiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boPhanToolStripMenuItem;
    }
}

