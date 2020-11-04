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

namespace QLCF_TP.GUI
{
    public partial class frmResetPass : DevExpress.XtraEditors.XtraForm
    {
        private string userName;
        public string UserName { get => userName; set => userName = value; }
      
        public frmResetPass(string user)
        {
            InitializeComponent();
            this.UserName = user;
        }
        QLCF_NTPEntities db = new QLCF_NTPEntities();
        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            int acc = (from a in db.Accounts
                       where a.UserName.ToLower() == UserName.ToLower() && a.PassWord == textEdit1.Text
                       select new { a.PassWord, a.UserName }).Count();
            if (acc > 0)
            {
                Account acco = db.Accounts.SingleOrDefault(X => X.UserName == UserName);
                acco.PassWord = textEdit2.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Không thể đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmResetPass_Load(object sender, EventArgs e)
        {
            textEdit1.Focus();
        }
    }
}