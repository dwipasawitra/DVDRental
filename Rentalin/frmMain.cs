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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            jalankanWindow();
        }

        
        private void jalankanWindow()
        {
            while (true)
            {
                if (!Program.session.isLogin())
                {
                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                    login.Focus();
                }
                else
                {
                    if (Program.role.jendelaPertama == userRole.JENDELA_PERTAMA_OPERATOR)
                    {
                        frmMainOperator formOperator = new frmMainOperator();
                        formOperator.Focus();
                        formOperator.ShowDialog();
                        
                    }
                    else
                    {
                        frmAdmin formAdmin = new frmAdmin();
                        formAdmin.Focus();
                        formAdmin.ShowDialog();
                        
                    }
                }
            }
        }
    }
}
