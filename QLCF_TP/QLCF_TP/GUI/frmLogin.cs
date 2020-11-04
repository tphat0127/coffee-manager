using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

namespace QLCF_TP.GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        QLCF_NTPEntities db = new QLCF_NTPEntities();
        
        public frmLogin()
        {
            InitializeComponent();
            txtAcc.Text = "Admin";
            txtPass.Text = "1";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int acc = (from a in db.Accounts
                     where a.UserName.ToLower() == txtAcc.Text.ToLower() && a.PassWord == txtPass.Text
                       select new { a.PassWord, a.UserName }).Count();

            if (acc > 0)
            {
                string Username = txtAcc.Text;
                this.Hide();
                FluentDesignForm1 f = new FluentDesignForm1(Username);
                f.ShowDialog();

            }
            else
            {
                XtraMessageBox.Show("Sai Tài khoản hoặc Mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}