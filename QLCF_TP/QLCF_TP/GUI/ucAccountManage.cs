using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace QLCF_TP.GUI
{
    public partial class ucAccountManage : DevExpress.XtraEditors.XtraUserControl
    {
        QLCF_NTPEntities db = new QLCF_NTPEntities();
      
        private static ucAccountManage instance;

        public static ucAccountManage Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucAccountManage();
                return instance;
            }
        }
        public ucAccountManage()
        {
            InitializeComponent();
        }

        private void ucAccountManage_Load(object sender, EventArgs e)
        {
            this.accountTableAdapter.Fill(this.qLCF_NTPDataSet.Account);
            RepositoryItemCheckEdit riCombo = new RepositoryItemCheckEdit();
           
            gridView1.Columns["Type"].ColumnEdit = riCombo;
            var query = db.Accounts.Select(c => new { c.Type }).ToList();
            foreach (var item in query)
            {
                if (item.ToString() == "1")
                    riCombo.ValueChecked = true;
            }
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\image\\logo.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btncolThem_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            accountTableAdapter.Update(qLCF_NTPDataSet.Account);
        }

        private void btncolDel_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Xác nhận xóa tài khoản đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    accountBindingSource.RemoveCurrent();
                    accountTableAdapter.Update(qLCF_NTPDataSet.Account);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Không thể xóa mục này\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
            accountTableAdapter.Update(qLCF_NTPDataSet.Account);
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Password", "1");
            
        }
    }
}
