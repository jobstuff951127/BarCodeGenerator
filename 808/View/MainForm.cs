#region LIBS
using _808.Model;
using _808.View;
using _808.ViewModel;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Dynamic;
using System.Threading;
#endregion

namespace _808
{
    public partial class MainForm : Form
    {
        //Contructor
        public MainForm()
        {
            InitializeComponent();
        }

        #region FORM STYLES 
        /*
            This section contains custom styles and basic functionality form sets    
        */
        private bool flagMinMax { get; set; }
        bool sortAscending = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void BtnClose_MouseEnter(object sender, EventArgs e) => btnClose.BackColor = Color.FromArgb(218, 51, 51);
        private void BtnClose_MouseLeave(object sender, EventArgs e) => btnClose.BackColor = Color.Transparent;
        private void BtnMax_MouseEnter(object sender, EventArgs e) => btnMax.BackColor = Color.FromArgb(222, 219, 219);
        private void BtnMax_MouseLeave(object sender, EventArgs e) => btnMax.BackColor = Color.Transparent;
        private void BtnMin_MouseEnter(object sender, EventArgs e) => btnMin.BackColor = Color.FromArgb(222, 219, 219);
        private void BtnMin_MouseLeave(object sender, EventArgs e) => btnMin.BackColor = Color.Transparent;
        private void BtnMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void BtnClose_Click(object sender, EventArgs e) => Dispose();
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    flagMinMax = false;
                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (!flagMinMax)
            {
                WindowState = FormWindowState.Maximized;
                loader.Location = new Point(650, 250);
                flagMinMax = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                loader.Location = new Point(372, 104);
                flagMinMax = false;
            }
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            loader.Location = new Point(372, 104);
        }

        #endregion

        //Este metodo pasa por parametros la info del datagridview en una lista la contructor del nuevo form
        private void BtnVistaPrevia_Click(object sender, EventArgs e)
        {
            List<Article> lstArt = dgvCodes.DataSource as List<Article>;
            if (lstArt != null && lstArt.Count > 0)
            {
                ViewerForm vform = new ViewerForm(lstArt);
                vform.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay información en el visor.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            comboFamily.DataSource = await Main.GetFamilies();
            comboFamily.SelectedIndex = -1;
        }
        private async void ComboFamily_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboLine.DataSource = await Main.GetLinesBasedOnFam(comboFamily.Text);
            comboLine.SelectedIndex = -1;
        }
        private async void ComboLine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtDescCode.Text = "";
            dgvCodes.Hide();
            dgvCodes.DataSource = await Main.GetByFamAndLine(comboLine.Text, comboFamily.Text, loader);
            Main.SetDataGridView(dgvCodes);
            dgvCodes.Show();
        }

        //Este metodo sirve para ordenar el datagridview al dar click en cualquier header que no sea el 1ero.
        //Usa linq Dynamico, actualizar codigo a la version mas reciente
        private void DgvCodes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Article> lstArt = dgvCodes.DataSource as List<Article>;
            if (e.ColumnIndex != 0)
            {
                if (sortAscending)
                    dgvCodes.DataSource = lstArt.OrderBy(dgvCodes.Columns[e.ColumnIndex].DataPropertyName).ToList();
                else
                    dgvCodes.DataSource = lstArt.OrderBy(dgvCodes.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
                sortAscending = !sortAscending;
            }
        }
        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDescCode.Text != "" && txtDescCode.Text.Length <= 25)
            {
                comboFamily.SelectedIndex = -1;
                comboLine.SelectedIndex = -1;
                dgvCodes.Hide();
                dgvCodes.DataSource = await Main.GetByCode(txtDescCode.Text, loader);
                Main.SetDataGridView(dgvCodes);
                dgvCodes.Show();
            }
            else
            {
                MessageBox.Show("El campo \"Código\" no puede estar vacío ni debe tener una longitud mayor a 25 caracteres.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtDescCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscar.PerformClick();
        }
    }

}
