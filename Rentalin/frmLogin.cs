using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rentalin
{
    public partial class frmLogin : Form
    {
        DataTable newDataTable = new DataTable();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            Console.WriteLine("Saya");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            int status;
            status = Program.session.login(txtUserName.Text.ToString(), txtPassword.Text.ToString());
            if (status == userSession.LOGIN_SUCCESS)
            {
                if (Program.role.jendelaPertama == userRole.JENDELA_PERTAMA_OPERATOR)
                {
                    frmMainOperator formOperator = new frmMainOperator();
                    formOperator.Show();
                }
                else
                {
                    frmAdmin formAdmin = new frmAdmin();
                    formAdmin.Show();
                }
                Close();
            }
            else if (status == userSession.LOGIN_MULTI)
            {
                MessageBox.Show("Ada 1 sesi berbeda berjalan, atau proses keluar sebelumnya tidak sempurna. Silahkan lakukan prosedur pengembalian autentifikasi", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(status == userSession.LOGIN_USERNAME_PASSWORD_WRONG)
            {
                MessageBox.Show("Nama Pengguna atau Password salah.", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text=="Nama Pengguna...")
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Nama Pengguna...";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password...";
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }


        
    }
}
