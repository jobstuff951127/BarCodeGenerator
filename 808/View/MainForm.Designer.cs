namespace _808
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new Guna.UI.WinForms.GunaLabel();
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.btnMin = new Guna.UI.WinForms.GunaImageButton();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.btnTop = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnMax = new Guna.UI.WinForms.GunaImageButton();
            this.panelDownTitle = new Guna.UI.WinForms.GunaElipsePanel();
            this.panelLine = new Guna.UI.WinForms.GunaPanel();
            this.btnBlue = new Guna.UI.WinForms.GunaButton();
            this.btnWhite = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.tooltipBtnActions = new System.Windows.Forms.ToolTip(this.components);
            this.btnVistaPrevia = new Guna.UI.WinForms.GunaCircleButton();
            this.btnBuscar = new Guna.UI.WinForms.GunaCircleButton();
            this.comboFamily = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.comboLine = new Guna.UI.WinForms.GunaComboBox();
            this.labelLine = new Guna.UI.WinForms.GunaLabel();
            this.labelFamily = new Guna.UI.WinForms.GunaLabel();
            this.shadowPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtDescCode = new Guna.UI.WinForms.GunaTextBox();
            this.panelUpToDgv = new System.Windows.Forms.Panel();
            this.loader = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.dgvCodes = new Guna.UI.WinForms.GunaDataGridView();
            this.panelUpDgv2 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelDownTitle.SuspendLayout();
            this.panelLine.SuspendLayout();
            this.shadowPanel.SuspendLayout();
            this.panelUpToDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Carlito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(279, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Impresión de Códigos de Barras";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnTop);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 37);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
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
            this.btnMin.TabIndex = 10;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.BtnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.BtnMin_MouseLeave);
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
            this.btnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
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
            // panelDownTitle
            // 
            this.panelDownTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelDownTitle.BaseColor = System.Drawing.Color.Transparent;
            this.panelDownTitle.Controls.Add(this.panelLine);
            this.panelDownTitle.Controls.Add(this.gunaPanel1);
            this.panelDownTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDownTitle.Location = new System.Drawing.Point(0, 63);
            this.panelDownTitle.Name = "panelDownTitle";
            this.panelDownTitle.Size = new System.Drawing.Size(800, 36);
            this.panelDownTitle.TabIndex = 5;
            this.panelDownTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLine.Controls.Add(this.btnBlue);
            this.panelLine.Controls.Add(this.btnWhite);
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(0, 10);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(800, 5);
            this.panelLine.TabIndex = 35;
            // 
            // btnBlue
            // 
            this.btnBlue.AnimationHoverSpeed = 0.07F;
            this.btnBlue.AnimationSpeed = 0.03F;
            this.btnBlue.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBlue.BorderColor = System.Drawing.Color.Black;
            this.btnBlue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBlue.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBlue.FocusedColor = System.Drawing.Color.Empty;
            this.btnBlue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBlue.ForeColor = System.Drawing.Color.White;
            this.btnBlue.Image = null;
            this.btnBlue.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBlue.Location = new System.Drawing.Point(10, 0);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnBlue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBlue.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBlue.OnHoverImage = null;
            this.btnBlue.OnPressedColor = System.Drawing.Color.Black;
            this.btnBlue.Size = new System.Drawing.Size(53, 5);
            this.btnBlue.TabIndex = 34;
            // 
            // btnWhite
            // 
            this.btnWhite.AnimationHoverSpeed = 0.07F;
            this.btnWhite.AnimationSpeed = 0.03F;
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.BaseColor = System.Drawing.Color.Transparent;
            this.btnWhite.BorderColor = System.Drawing.Color.Black;
            this.btnWhite.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnWhite.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWhite.FocusedColor = System.Drawing.Color.Empty;
            this.btnWhite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWhite.ForeColor = System.Drawing.Color.White;
            this.btnWhite.Image = null;
            this.btnWhite.ImageSize = new System.Drawing.Size(20, 20);
            this.btnWhite.Location = new System.Drawing.Point(0, 0);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnWhite.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnWhite.OnHoverForeColor = System.Drawing.Color.White;
            this.btnWhite.OnHoverImage = null;
            this.btnWhite.OnPressedColor = System.Drawing.Color.Black;
            this.btnWhite.Size = new System.Drawing.Size(10, 5);
            this.btnWhite.TabIndex = 33;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 10);
            this.gunaPanel1.TabIndex = 33;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.AnimationHoverSpeed = 0.07F;
            this.btnVistaPrevia.AnimationSpeed = 0.03F;
            this.btnVistaPrevia.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVistaPrevia.BorderColor = System.Drawing.Color.Black;
            this.btnVistaPrevia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVistaPrevia.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVistaPrevia.FocusedColor = System.Drawing.Color.Empty;
            this.btnVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVistaPrevia.ForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.Image = global::_808.Properties.Resources.vistaPrevia;
            this.btnVistaPrevia.ImageSize = new System.Drawing.Size(28, 28);
            this.btnVistaPrevia.Location = new System.Drawing.Point(329, 27);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVistaPrevia.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVistaPrevia.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.OnHoverImage = null;
            this.btnVistaPrevia.OnPressedColor = System.Drawing.Color.Black;
            this.btnVistaPrevia.Size = new System.Drawing.Size(48, 47);
            this.btnVistaPrevia.TabIndex = 27;
            this.tooltipBtnActions.SetToolTip(this.btnVistaPrevia, "Vista previa");
            this.btnVistaPrevia.Click += new System.EventHandler(this.BtnVistaPrevia_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::_808.Properties.Resources.lupa;
            this.btnBuscar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnBuscar.Location = new System.Drawing.Point(245, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Size = new System.Drawing.Size(48, 47);
            this.btnBuscar.TabIndex = 24;
            this.tooltipBtnActions.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // comboFamily
            // 
            this.comboFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFamily.BackColor = System.Drawing.Color.Transparent;
            this.comboFamily.BaseColor = System.Drawing.Color.White;
            this.comboFamily.BorderColor = System.Drawing.Color.Silver;
            this.comboFamily.BorderSize = 1;
            this.comboFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboFamily.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFamily.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboFamily.FocusedColor = System.Drawing.Color.Empty;
            this.comboFamily.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFamily.ForeColor = System.Drawing.Color.Black;
            this.comboFamily.FormattingEnabled = true;
            this.comboFamily.ItemHeight = 15;
            this.comboFamily.Location = new System.Drawing.Point(499, 24);
            this.comboFamily.Name = "comboFamily";
            this.comboFamily.OnHoverItemBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.comboFamily.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboFamily.Radius = 10;
            this.comboFamily.Size = new System.Drawing.Size(252, 21);
            this.comboFamily.TabIndex = 25;
            this.comboFamily.SelectionChangeCommitted += new System.EventHandler(this.ComboFamily_SelectionChangeCommitted);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(85, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(75, 17);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "ARTÍCULO:";
            this.gunaLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // comboLine
            // 
            this.comboLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLine.BackColor = System.Drawing.Color.Transparent;
            this.comboLine.BaseColor = System.Drawing.Color.White;
            this.comboLine.BorderColor = System.Drawing.Color.Silver;
            this.comboLine.BorderSize = 1;
            this.comboLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboLine.FocusedColor = System.Drawing.Color.Empty;
            this.comboLine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboLine.ForeColor = System.Drawing.Color.Black;
            this.comboLine.FormattingEnabled = true;
            this.comboLine.ItemHeight = 15;
            this.comboLine.Location = new System.Drawing.Point(499, 51);
            this.comboLine.Name = "comboLine";
            this.comboLine.OnHoverItemBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.comboLine.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboLine.Radius = 10;
            this.comboLine.Size = new System.Drawing.Size(252, 21);
            this.comboLine.TabIndex = 26;
            this.comboLine.SelectionChangeCommitted += new System.EventHandler(this.ComboLine_SelectionChangeCommitted);
            // 
            // labelLine
            // 
            this.labelLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelLine.Location = new System.Drawing.Point(432, 55);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(49, 17);
            this.labelLine.TabIndex = 22;
            this.labelLine.Text = "LINEA:";
            this.labelLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // labelFamily
            // 
            this.labelFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFamily.AutoSize = true;
            this.labelFamily.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamily.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelFamily.Location = new System.Drawing.Point(418, 24);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(63, 17);
            this.labelFamily.TabIndex = 23;
            this.labelFamily.Text = "FAMILIA:";
            this.labelFamily.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel.BaseColor = System.Drawing.Color.White;
            this.shadowPanel.Controls.Add(this.txtDescCode);
            this.shadowPanel.Controls.Add(this.comboFamily);
            this.shadowPanel.Controls.Add(this.btnVistaPrevia);
            this.shadowPanel.Controls.Add(this.btnBuscar);
            this.shadowPanel.Controls.Add(this.gunaLabel1);
            this.shadowPanel.Controls.Add(this.labelFamily);
            this.shadowPanel.Controls.Add(this.comboLine);
            this.shadowPanel.Controls.Add(this.labelLine);
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadowPanel.Location = new System.Drawing.Point(0, 99);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanel.Size = new System.Drawing.Size(800, 96);
            this.shadowPanel.TabIndex = 31;
            this.shadowPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // txtDescCode
            // 
            this.txtDescCode.BackColor = System.Drawing.Color.Transparent;
            this.txtDescCode.BaseColor = System.Drawing.Color.White;
            this.txtDescCode.BorderColor = System.Drawing.Color.Silver;
            this.txtDescCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescCode.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtDescCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescCode.Location = new System.Drawing.Point(42, 45);
            this.txtDescCode.Name = "txtDescCode";
            this.txtDescCode.PasswordChar = '\0';
            this.txtDescCode.Radius = 10;
            this.txtDescCode.Size = new System.Drawing.Size(166, 26);
            this.txtDescCode.TabIndex = 30;
            this.txtDescCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescCode_KeyDown);
            // 
            // panelUpToDgv
            // 
            this.panelUpToDgv.Controls.Add(this.loader);
            this.panelUpToDgv.Controls.Add(this.dgvCodes);
            this.panelUpToDgv.Controls.Add(this.panelUpDgv2);
            this.panelUpToDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpToDgv.Location = new System.Drawing.Point(0, 195);
            this.panelUpToDgv.Name = "panelUpToDgv";
            this.panelUpToDgv.Size = new System.Drawing.Size(800, 255);
            this.panelUpToDgv.TabIndex = 33;
            this.panelUpToDgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // loader
            // 
            this.loader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loader.Location = new System.Drawing.Point(372, 104);
            this.loader.Name = "loader";
            this.loader.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.loader.Size = new System.Drawing.Size(64, 64);
            this.loader.TabIndex = 38;
            this.loader.Visible = false;
            // 
            // dgvCodes
            // 
            this.dgvCodes.AllowUserToAddRows = false;
            this.dgvCodes.AllowUserToDeleteRows = false;
            this.dgvCodes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvCodes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCodes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCodes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCodes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCodes.ColumnHeadersHeight = 25;
            this.dgvCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCodes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCodes.EnableHeadersVisualStyles = false;
            this.dgvCodes.GridColor = System.Drawing.Color.White;
            this.dgvCodes.Location = new System.Drawing.Point(0, 42);
            this.dgvCodes.Margin = new System.Windows.Forms.Padding(8);
            this.dgvCodes.Name = "dgvCodes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCodes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCodes.RowHeadersVisible = false;
            this.dgvCodes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCodes.RowTemplate.Height = 30;
            this.dgvCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCodes.Size = new System.Drawing.Size(800, 213);
            this.dgvCodes.TabIndex = 1;
            this.dgvCodes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightBlue;
            this.dgvCodes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvCodes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCodes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCodes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCodes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCodes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCodes.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvCodes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgvCodes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCodes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCodes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCodes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCodes.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvCodes.ThemeStyle.ReadOnly = false;
            this.dgvCodes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgvCodes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCodes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCodes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCodes.ThemeStyle.RowsStyle.Height = 30;
            this.dgvCodes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgvCodes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCodes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCodes_ColumnHeaderMouseClick);
            // 
            // panelUpDgv2
            // 
            this.panelUpDgv2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpDgv2.Location = new System.Drawing.Point(0, 0);
            this.panelUpDgv2.Name = "panelUpDgv2";
            this.panelUpDgv2.Size = new System.Drawing.Size(800, 42);
            this.panelUpDgv2.TabIndex = 0;
            this.panelUpDgv2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelUpToDgv);
            this.Controls.Add(this.shadowPanel);
            this.Controls.Add(this.panelDownTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelDownTitle.ResumeLayout(false);
            this.panelLine.ResumeLayout(false);
            this.shadowPanel.ResumeLayout(false);
            this.shadowPanel.PerformLayout();
            this.panelUpToDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel labelTitle;
        private Guna.UI.WinForms.GunaGradientTileButton btnTop;
        private Guna.UI.WinForms.GunaPanel panelTop;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private Guna.UI.WinForms.GunaElipsePanel panelDownTitle;
        private Guna.UI.WinForms.GunaImageButton btnMax;
        private System.Windows.Forms.ToolTip tooltipBtnActions;
        private Guna.UI.WinForms.GunaComboBox comboFamily;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox comboLine;
        private Guna.UI.WinForms.GunaLabel labelLine;
        private Guna.UI.WinForms.GunaCircleButton btnVistaPrevia;
        private Guna.UI.WinForms.GunaLabel labelFamily;
        private Guna.UI.WinForms.GunaCircleButton btnBuscar;
        private Guna.UI.WinForms.GunaShadowPanel shadowPanel;
        private System.Windows.Forms.Panel panelUpToDgv;
        private Guna.UI.WinForms.GunaPanel panelLine;
        private Guna.UI.WinForms.GunaButton btnBlue;
        private Guna.UI.WinForms.GunaButton btnWhite;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Panel panelUpDgv2;
        private Guna.UI.WinForms.GunaDataGridView dgvCodes;
        private Guna.UI.WinForms.GunaImageButton btnMin;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator loader;
        private Guna.UI.WinForms.GunaTextBox txtDescCode;
    }
}

