#region LIBS
using _808.Model;
using _808.ViewModel;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

#endregion

namespace _808.View
{
    public partial class ViewerForm : Form
    {

        //Contructor
        public ViewerForm(List<Article> lstArt)
        {
            InitializeComponent();
            this.lstArt = lstArt;
        }

        #region NONE BUSINESS LOGIC CONTENT 
        private bool flagMinMax { get; set; }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private readonly List<Article> lstArt;

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
        private void ViewerForm_MouseDown(object sender, MouseEventArgs e)
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
                loader.Location = new Point(654, 339);
                flagMinMax = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                loader.Location = new Point(376, 193);
                flagMinMax = false;
            }
        }
        private void ViewerForm_Resize(object sender, EventArgs e)
        {
            loader.Location = new Point(376, 193);
        }
        #endregion
        private async void ViewerForm_Load(object sender, EventArgs e)
        {
            await Viewer.CreatePdf(lstArt, pdfViewer, labelNumPages, loader);
        }

    }
}
