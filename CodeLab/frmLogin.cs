using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace CodeLab
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public static String username = "";
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {           
            con.Open();
            String login = "SELECT * FROM tbl_users WHERE username= '"+txtusername.Text+"'and password='"+txtPassword.Text+"'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read()==true)
            {               
                username = txtusername.Text;              
                 new dashboard().Show();
                 this.Hide();
             
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again","Login Failled",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtusername.Text = "";
               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
