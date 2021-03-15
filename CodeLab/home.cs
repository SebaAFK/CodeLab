using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
namespace CodeLab
{
    public partial class home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
              int nLeftRect,
              int nRightRect,
              int nTopRect,
              int nButtomRect,
              int nWidthEllipse,
              int nHeightEllipse
            );
        public home()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
            txtUsername.Text = frmLogin.username;
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;
            btnCourses.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            pnlNav.Left = btnContactUs.Left;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            frmSettings frmSettings = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContainer.Controls.Add(frmSettings);
            frmSettings.Show();
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCourses_Leave(object sender, EventArgs e)
        {
            btnCourses.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnAchievments_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAchievments.Height;
            pnlNav.Top = btnAchievments.Top;
            pnlNav.Left = btnHome.Left;
            btnAchievments.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAchievments_Leave(object sender, EventArgs e)
        {
            btnAchievments.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
