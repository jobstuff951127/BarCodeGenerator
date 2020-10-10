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
            this.labelTitle = new Guna.UI.WinForms.GunaLabel();
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.btnTop = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnMin = new Guna.UI.WinForms.GunaImageButton();
            this.btnMax = new Guna.UI.WinForms.GunaImageButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panelDownTitle = new Guna.UI.WinForms.GunaElipsePanel();
            this.tooltipBtnActions = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboFamily = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.comboLine = new Guna.UI.WinForms.GunaComboBox();
            this.labelLine = new Guna.UI.WinForms.GunaLabel();
            this.btnVistaPrevia = new Guna.UI.WinForms.GunaCircleButton();
            this.txtDescCode = new Guna.UI.WinForms.GunaTextBox();
            this.labelFamily = new Guna.UI.WinForms.GunaLabel();
            this.btnBuscar = new Guna.UI.WinForms.GunaCircleButton();
            this.shadowPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelDownTitle.SuspendLayout();
            this.shadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
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
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
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
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(55, 4);
            this.gunaButton1.TabIndex = 1;
            // 
            // panelDownTitle
            // 
            this.panelDownTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelDownTitle.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.panelDownTitle.Controls.Add(this.gunaButton1);
            this.panelDownTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDownTitle.Location = new System.Drawing.Point(0, 63);
            this.panelDownTitle.Name = "panelDownTitle";
            this.panelDownTitle.Size = new System.Drawing.Size(800, 4);
            this.panelDownTitle.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboFamily
            // 
            this.comboFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.comboFamily.Location = new System.Drawing.Point(469, 21);
            this.comboFamily.Name = "comboFamily";
            this.comboFamily.OnHoverItemBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.comboFamily.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboFamily.Radius = 10;
            this.comboFamily.Size = new System.Drawing.Size(299, 21);
            this.comboFamily.TabIndex = 25;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(39, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(160, 17);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "DESCRIPCIÓN - CÓDIGO:";
            // 
            // comboLine
            // 
            this.comboLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.comboLine.Location = new System.Drawing.Point(469, 48);
            this.comboLine.Name = "comboLine";
            this.comboLine.OnHoverItemBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.comboLine.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboLine.Radius = 10;
            this.comboLine.Size = new System.Drawing.Size(299, 21);
            this.comboLine.TabIndex = 26;
            // 
            // labelLine
            // 
            this.labelLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelLine.Location = new System.Drawing.Point(402, 52);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(49, 17);
            this.labelLine.TabIndex = 22;
            this.labelLine.Text = "LINEA:";
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnVistaPrevia.Location = new System.Drawing.Point(241, 21);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnVistaPrevia.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVistaPrevia.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.OnHoverImage = null;
            this.btnVistaPrevia.OnPressedColor = System.Drawing.Color.Black;
            this.btnVistaPrevia.Size = new System.Drawing.Size(48, 47);
            this.btnVistaPrevia.TabIndex = 27;
            this.tooltipBtnActions.SetToolTip(this.btnVistaPrevia, "Buscar");
            // 
            // txtDescCode
            // 
            this.txtDescCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescCode.BackColor = System.Drawing.Color.Transparent;
            this.txtDescCode.BaseColor = System.Drawing.Color.White;
            this.txtDescCode.BorderColor = System.Drawing.Color.Silver;
            this.txtDescCode.BorderSize = 1;
            this.txtDescCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescCode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescCode.Location = new System.Drawing.Point(34, 41);
            this.txtDescCode.MultiLine = true;
            this.txtDescCode.Name = "txtDescCode";
            this.txtDescCode.PasswordChar = '\0';
            this.txtDescCode.Radius = 10;
            this.txtDescCode.Size = new System.Drawing.Size(177, 28);
            this.txtDescCode.TabIndex = 28;
            this.txtDescCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFamily
            // 
            this.labelFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFamily.AutoSize = true;
            this.labelFamily.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamily.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelFamily.Location = new System.Drawing.Point(388, 21);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(63, 17);
            this.labelFamily.TabIndex = 23;
            this.labelFamily.Text = "FAMILIA:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnBuscar.Location = new System.Drawing.Point(315, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Size = new System.Drawing.Size(48, 47);
            this.btnBuscar.TabIndex = 24;
            this.tooltipBtnActions.SetToolTip(this.btnBuscar, "Buscar");
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel.BaseColor = System.Drawing.Color.White;
            this.shadowPanel.Controls.Add(this.comboFamily);
            this.shadowPanel.Controls.Add(this.btnBuscar);
            this.shadowPanel.Controls.Add(this.gunaLabel1);
            this.shadowPanel.Controls.Add(this.labelFamily);
            this.shadowPanel.Controls.Add(this.comboLine);
            this.shadowPanel.Controls.Add(this.txtDescCode);
            this.shadowPanel.Controls.Add(this.labelLine);
            this.shadowPanel.Controls.Add(this.btnVistaPrevia);
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadowPanel.Location = new System.Drawing.Point(0, 67);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanel.Size = new System.Drawing.Size(800, 96);
            this.shadowPanel.TabIndex = 31;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(0, 163);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(800, 269);
            this.gunaDataGridView1.TabIndex = 32;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.shadowPanel);
            this.Controls.Add(this.panelDownTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelDownTitle.ResumeLayout(false);
            this.shadowPanel.ResumeLayout(false);
            this.shadowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel labelTitle;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGradientTileButton btnTop;
        private Guna.UI.WinForms.GunaPanel panelTop;
        private Guna.UI.WinForms.GunaImageButton btnMin;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private Guna.UI.WinForms.GunaElipsePanel panelDownTitle;
        private Guna.UI.WinForms.GunaImageButton btnMax;
        private System.Windows.Forms.ToolTip tooltipBtnActions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI.WinForms.GunaComboBox comboFamily;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox comboLine;
        private Guna.UI.WinForms.GunaLabel labelLine;
        private Guna.UI.WinForms.GunaCircleButton btnVistaPrevia;
        private Guna.UI.WinForms.GunaTextBox txtDescCode;
        private Guna.UI.WinForms.GunaLabel labelFamily;
        private Guna.UI.WinForms.GunaCircleButton btnBuscar;
        private Guna.UI.WinForms.GunaShadowPanel shadowPanel;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

