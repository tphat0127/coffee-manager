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
    public partial class ucTableManage : DevExpress.XtraEditors.XtraUserControl
    {
        QLCF_NTPEntities db = new QLCF_NTPEntities();
        
        private static ucTableManage instance;

        public static ucTableManage Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucTableManage();
                return instance;
            }
        }
        public ucTableManage()
        {
            InitializeComponent();
        }

        private void ucTableManage_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.qLCF_NTPDataSet.Table);

            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\image\\logo.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btncolThem_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.tableTableAdapter.Update(this.qLCF_NTPDataSet.Table);
        }

        private void btncolDel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Xác nhận xóa bàn đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    tableBindingSource.RemoveCurrent();
                    tableTableAdapter.Update(qLCF_NTPDataSet.Table);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Không thể xóa mục này\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                this.tableTableAdapter.Update(this.qLCF_NTPDataSet.Table);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không thể chỉnh sửa mục này\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Status", "false");
        }
    }
}
