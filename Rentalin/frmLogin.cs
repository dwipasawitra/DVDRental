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
                MessageBox.Show("Login");
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
                Hide();
            }
        }
    }
}
