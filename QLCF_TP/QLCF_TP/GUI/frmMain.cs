using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QLCF_TP.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCF_TP
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        QLCF_NTPEntities db = new QLCF_NTPEntities();
        private string userName;
        
        public string UserName
        {
            get { return userName; }
            set { userName = value; CheckType(Convert.ToInt32(db.Accounts.Where(a=> a.UserName == userName).Select(a=> a.Type).First())); }
        }
        public FluentDesignForm1(string user)
        {
            InitializeComponent();
            this.UserName = user;
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucCategoryManage.Instance))
            {
                container.Controls.Add(ucCategoryManage.Instance);
                ucCategoryManage.Instance.Dock = DockStyle.Fill;
                ucCategoryManage.Instance.BringToFront();
            }
            ucCategoryManage.Instance.BringToFront();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucMain.Instance))
            {
                container.Controls.Add(ucMain.Instance);
                ucMain.Instance.Dock = DockStyle.Fill;
                ucMain.Instance.BringToFront();
            }
            ucMain.Instance.BringToFront();
        }
        

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucBillManage.Instance))
            {
                container.Controls.Add(ucBillManage.Instance);
                ucBillManage.Instance.Dock = DockStyle.Fill;
                ucBillManage.Instance.BringToFront();
            }
            ucBillManage.Instance.BringToFront();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucMenuManage.Instance))
            {
                container.Controls.Add(ucMenuManage.Instance);
                ucMenuManage.Instance.Dock = DockStyle.Fill;
                ucMenuManage.Instance.BringToFront();
            }
            ucMenuManage.Instance.BringToFront();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucTableManage.Instance))
            {
                container.Controls.Add(ucTableManage.Instance);
                ucTableManage.Instance.Dock = DockStyle.Fill;
                ucMenuManage.Instance.BringToFront();
            }
            ucTableManage.Instance.BringToFront();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucAccountManage.Instance))
            {
                container.Controls.Add(ucAccountManage.Instance);
                ucAccountManage.Instance.Dock = DockStyle.Fill;
                ucAccountManage.Instance.BringToFront();
            }
            ucAccountManage.Instance.BringToFront();
        }

        private void FluentDesignForm1_Load(object sender, EventArgs e)
        {
            accordionControlElement1.Text = "Ca làm việc: "+UserName;

            if (!container.Controls.Contains(ucMain.Instance))
            {
                container.Controls.Add(ucMain.Instance);
                ucMain.Instance.Dock = DockStyle.Fill;
                ucMain.Instance.BringToFront();
            }
            ucMain.Instance.BringToFront();
        }
        void CheckType(int type)
        {
            accordionControlElement2.Enabled = type ==1;
            accordionControlElement3.Visible = type == 1;
            accordionControlElement4.Visible = type == 1;
            accordionControlElement5.Visible = type == 1;
            accordionControlElement6.Visible = type == 1;
            accordionControlElement7.Visible = type == 1;
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Xác nhận thoát tài khoản","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            {
                this.Close();
                frmLogin f = new frmLogin();
                f.Show();
            }
           
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            frmResetPass f = new frmResetPass(UserName);
            f.ShowDialog();
        }
    }
}
