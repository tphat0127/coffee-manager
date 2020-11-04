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
using DevExpress.XtraEditors.Controls;

namespace QLCF_TP.GUI
{
    public partial class ucSwtichTable : DevExpress.XtraEditors.XtraUserControl
    {
        QLCF_NTPEntities db = new QLCF_NTPEntities();
        private int tableId1;
        public int TableId1 { get => tableId1; set => tableId1 = value; }

        private int tableId2;
        public int TableId2 { get => tableId2; set => tableId2 = value; }
        public ucSwtichTable(int table1)
        {
            InitializeComponent();
            TableId1 = table1;
        }

        

        private void ucSwtichTable_Load(object sender, EventArgs e)
        {
            
            var query = from t in db.Tables select new { t.Id, t.Name };
            foreach (var item in query)
            {
                comboBoxEdit1.Properties.Items.Add(item.Id);
               
            }
            label1.Text = string.Format("Xác nhận chuyển từ bàn {0} sang bàn", TableId1);
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableId2 = Convert.ToInt32(comboBoxEdit1.SelectedItem.ToString());
        }
    }
}
