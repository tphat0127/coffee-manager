using DevExpress.Utils.OAuth;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLCF_TP.GUI
{
    public partial class ucCategoryManage : DevExpress.XtraEditors.XtraUserControl
    {
        QLCF_NTPEntities db = new QLCF_NTPEntities();
        private static ucCategoryManage instance;
        public static ucCategoryManage Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucCategoryManage();
                return instance;
            }
        }
        public ucCategoryManage()
        {
            InitializeComponent();
        }

        private void ucCategoryManage_Load(object sender, EventArgs e)
        {
            this.categoryTableAdapter.Fill(this.qLCF_NTPDataSet1.Category);
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\image\\logo.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        
      
        private void btncolThem_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            categoryTableAdapter.Update(qLCF_NTPDataSet1.Category);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                categoryTableAdapter.Update(qLCF_NTPDataSet1.Category);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không thể chỉnh sửa mục này\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncolDel_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Xác nhận xóa mục đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    categoryBindingSource.RemoveCurrent();
                    categoryTableAdapter.Update(qLCF_NTPDataSet1.Category);

                    gridView1.DeleteSelectedRows();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Không thể xóa mục này\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Image", "default.png");
        }
    }
}
