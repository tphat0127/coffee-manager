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
    public partial class ucMenuManage : DevExpress.XtraEditors.XtraUserControl
    {
        QLCF_NTPEntities db = new QLCF_NTPEntities();
        private static ucMenuManage instance;
        public static ucMenuManage Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucMenuManage();
                return instance;
            }
        }
        public ucMenuManage()
        {
            InitializeComponent();
        }

        private void ucMenuManage_Load(object sender, EventArgs e)
        {
            this.menuTableAdapter.Fill(this.qLCF_NTPDataSet.Menu);
            RepositoryItemLookUpEdit riCombo = new RepositoryItemLookUpEdit();
            var query = db.Categories.Select(c => new { c.Id, c.Name }).ToList();
            riCombo.DataSource = query;
            riCombo.DisplayMember = "Name";
            riCombo.ValueMember = "Id";
            gridControl1.RepositoryItems.Add(riCombo);
            gridView1.Columns["CategoryId"].ColumnEdit = riCombo;

            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\image\\logo.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btncolThem_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            menuTableAdapter.Update(qLCF_NTPDataSet.Menu);
        }

        private void btncolDel_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Xác nhận xóa mục đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    menuBindingSource.RemoveCurrent();
                    menuTableAdapter.Update(qLCF_NTPDataSet.Menu);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Không thể xóa mục này\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void repositoryItemComboBox1_BeforePopup(object sender, EventArgs e)
        {
            
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            menuTableAdapter.Update(qLCF_NTPDataSet.Menu);
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Image", "default.png");
        }
    }
}
