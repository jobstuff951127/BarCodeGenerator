namespace _808.View
{
    partial class ViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.btnTop = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnMin = new Guna.UI.WinForms.GunaImageButton();
            this.btnMax = new Guna.UI.WinForms.GunaImageButton();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.labelNumPages = new Guna.UI.WinForms.GunaLabel();
            this.loader = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnTop);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 37);
            this.panelTop.TabIndex = 3;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(10, 10);
            this.btnClose.Location = new System.Drawing.Point(773, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // btnTop
            // 
            this.btnTop.AnimationHoverSpeed = 0.07F;
            this.btnTop.AnimationSpeed = 0.03F;
            this.btnTop.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnTop.BaseColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnTop.BorderColor = System.Drawing.Color.Black;
            this.btnTop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTop.FocusedColor = System.Drawing.Color.Empty;
            this.btnTop.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnTop.ForeColor = System.Drawing.Color.White;
            this.btnTop.Image = null;
            this.btnTop.ImageSize = new System.Drawing.Size(52, 52);
            this.btnTop.Location = new System.Drawing.Point(0, 0);
            this.btnTop.Name = "btnTop";
            this.btnTop.OnHoverBaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnTop.OnHoverBaseColor2 = System.Drawing.Color.Azure;
            this.btnTop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTop.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTop.OnHoverImage = null;
            this.btnTop.OnPressedColor = System.Drawing.Color.Black;
            this.btnTop.Size = new System.Drawing.Size(800, 8);
            this.btnTop.TabIndex = 5;
            this.btnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMin.Image = global::_808.Properties.Resources.min;
            this.btnMin.ImageSize = new System.Drawing.Size(10, 10);
            this.btnMin.Location = new System.Drawing.Point(714, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.OnHoverImage = null;
            this.btnMin.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnMin.Size = new System.Drawing.Size(25, 23);
            this.btnMin.TabIndex = 8;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.BtnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.BtnMin_MouseLeave);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMax.Image = global::_808.Properties.Resources.max;
            this.btnMax.ImageSize = new System.Drawing.Size(10, 10);
            this.btnMax.Location = new System.Drawing.Point(745, 9);
            this.btnMax.Name = "btnMax";
            this.btnMax.OnHoverImage = null;
            this.btnMax.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnMax.Size = new System.Drawing.Size(25, 23);
            this.btnMax.TabIndex = 7;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            this.btnMax.MouseEnter += new System.EventHandler(this.BtnMax_MouseEnter);
            this.btnMax.MouseLeave += new System.EventHandler(this.BtnMax_MouseLeave);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 37);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(800, 413);
            this.pdfViewer.TabIndex = 4;
            // 
            // labelNumPages
            // 
            this.labelNumPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumPages.AutoSize = true;
            this.labelNumPages.BackColor = System.Drawing.Color.Transparent;
            this.labelNumPages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPages.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelNumPages.Location = new System.Drawing.Point(697, 45);
            this.labelNumPages.Name = "labelNumPages";
            this.labelNumPages.Size = new System.Drawing.Size(0, 17);
            this.labelNumPages.TabIndex = 6;
            this.labelNumPages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseDown);
            // 
            // loader
            // 
            this.loader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loader.Location = new System.Drawing.Point(376, 193);
            this.loader.Name = "loader";
            this.loader.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.loader.Size = new System.Drawing.Size(64, 64);
            this.loader.TabIndex = 7;
            this.loader.Visible = false;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.labelNumPages);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewerForm";
            this.Load += new System.EventHandler(this.ViewerForm_Load);
            this.Resize += new System.EventHandler(this.ViewerForm_Resize);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel panelTop;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private Guna.UI.WinForms.GunaGradientTileButton btnTop;
        private Guna.UI.WinForms.GunaImageButton btnMin;
        private Guna.UI.WinForms.GunaImageButton btnMax;
        private PdfiumViewer.PdfViewer pdfViewer;
        private Guna.UI.WinForms.GunaLabel labelNumPages;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator loader;
    }
}