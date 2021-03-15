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
using System.Text.RegularExpressions;

namespace CodeLab
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if ((txtusername.Text == "") && (txtPassword.Text == "") && (txtComPassword.Text == "")&&(txtEmail.Text == ""))
            {
                MessageBox.Show("Username, Email and Password fields are empty", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtPassword.Text == txtComPassword.Text) && (isvalid_email(txtEmail.Text)))
            {
                con.Open();
                String register = "INSERT INTO tbl_users VALUES ('"+ txtusername.Text +"','"+ txtPassword.Text +"','"+txtEmail.Text+"')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                txtComPassword.Text = "";
                txtPassword.Text = "";
                txtusername.Text = "";
                txtEmail.Text = "";
                MessageBox.Show("Your Account has been Sccuessfully Created","Registration Sccuess",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (txtPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password does not match, Please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
            else
            {
                MessageBox.Show("Error, Please try again", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtEmail.Text = "";
                txtusername.Text = "";
                txtusername.Focus();
            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar= '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }
        public bool isvalid_email(String email)
        {
            Regex check = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            bool valid = false;
            valid = check.IsMatch(email);
            if (valid == true)
                return true;
            else
            {
                MessageBox.Show("E -mail Format is incorrect", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
