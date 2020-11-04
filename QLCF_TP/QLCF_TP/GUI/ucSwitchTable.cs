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

namespace QLCF_TP.GUI
{
    public partial class ucOrderDetail : DevExpress.XtraEditors.XtraUserControl
    {
        public ucOrderDetail()
        {
            InitializeComponent();
        }
        int soLuong =1;
        public int SoLuong { get => soLuong; set => soLuong = value; }

        private void ucOrderDetail_Load(object sender, EventArgs e)
        {
            soLuong = 1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            soLuong += 1;
            textEdit1.Text = soLuong + "";
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            if (soLuong > 1)
            {
                soLuong -= 1;

                textEdit1.Text = soLuong + "";
            }
            else
            {
                return;
            }
            
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            SoLuong = int.Parse(soLuong.ToString());
        }
    }
}
