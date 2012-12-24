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
            newDataTable = Program.conn.ExecuteDataTable("SELECT * FROM mahasiswa");
            dataGridView1.DataSource = newDataTable;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int status;
            status = Program.session.login(txtUserName.Text.ToString(), txtPassword.Text.ToString());
            if (status == userSession.LOGIN_SUCCESS)
            {
                
                if (Program.role.jendelaPertama == userRole.JENDELA_PERTAMA_OPERATOR)
                    new frmMainOperator();
                else
                    new frmAdmin();

                Close();
            }
        }
    }
}
