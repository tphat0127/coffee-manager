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
using QLCF_TP.BUS;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using System.Drawing.Printing;

namespace QLCF_TP.GUI
{
    public partial class ucMain : DevExpress.XtraEditors.XtraUserControl
    {
        
        QLCF_NTPEntities db = new QLCF_NTPEntities();
        int idTable;
        int idBillInfo;
        int fpnW;

        string ten = "";
        string thanhtien = "";
        string soluong = "";
        string tongtien = "";
        string giamgia = "";
        int offset = 40;
        float FontHeigh;
        int a = 0;

        private static ucMain instance;
        public static ucMain Instance
        {
            
            get
            {
                if (instance == null)
                    instance = new ucMain();
                return instance;
            }
        }


        public ucMain()
        {
            InitializeComponent();
        }


        #region Event
        private void ucMain_Load(object sender, EventArgs e)
        {
            fpnW = fpnTable.Width;
            fpnTable.Width = this.Width;
            pnTableInfo.Visible = false;
            gridControl1.Visible = false;
            LoadTable();
            ShowBill(1);
            LoadCbDisCount();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            LoadCategory();
            if (!Convert.ToBoolean(db.Tables.Where(t => t.Id == idTable).Select(t => t.Status).First()))
            {
                AddBill();
            }

        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            CheckOut();
            
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fpnTable.Width = this.Width;
            pnTableInfo.Visible = false;
            fpnMenu.Controls.Clear();
            fpnCategories.Controls.Clear();
        }
        private void BtnTable_Click(object sender, EventArgs e) //Sự kiện từ hàm LoadTable()
        {
            fpnTable.Width = fpnW;
            gridControl1.Visible = false;
            int id = (sender as SimpleButton).TabIndex;
            idTable = id;
            fpnMenu.Controls.Clear();
            fpnCategories.Controls.Clear();
            pnTableInfo.Visible = true;
            ShowBill(id);
            ShowTableInfo(id);
            
        }
        private void BtnCategory_Click(object sender, EventArgs e) //Sự kiện từ hàm LoadCategory()
        {
            int id = (sender as SimpleButton).TabIndex;
            LoadMenuById(id);
        }
        private void BtnMenu_Click(object sender, EventArgs e) //Sự kiện từ hàm LoadMenuById()
        {
            int id = (sender as SimpleButton).TabIndex;
            var ListMenus = db.Menus.Select(mn => new { mn.Id, mn.Name, mn.Price, mn.CategoryId }).Where(mn => mn.Id == id).ToList();
            
            foreach (var item in ListMenus)
            {
                ucOrderDetail myControl = new ucOrderDetail();
                if (DevExpress.XtraEditors.XtraDialog.Show(myControl, item.Name, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    AddBillInfo(myControl, id);
                    ShowBill(idTable);
                    ShowTableInfo(idTable);
                    LoadTable();
                    gridControl1.Visible = true;
                    
                }
            }

        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateBillInfo();
        }
        private void barButtonItem_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteBillInfo();
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            if (gridView1.RowCount == 0)
            {
                CheckOut();
            }
        }
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            popupMenu1.ShowPopup(Control.MousePosition);
            idBillInfo = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());

        }
        private void cbDistCount_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            //popupMenu2.ShowPopup(Control.MousePosition);
        }
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e) //CHuyển bàn
        {
            ucSwtichTable myControl = new ucSwtichTable(idTable);
            if (DevExpress.XtraEditors.XtraDialog.Show(myControl, "Chức năng", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.USP_SwitchTabble(idTable, myControl.TableId2);
                ShowBill(myControl.TableId2);
                LoadTable();
                ShowTableInfo(myControl.TableId2);

            }
        }
        #endregion

        #region Method
        private void LoadCbDisCount()
        {
            for(int i = 0; i <= 10; i++)
            {
                cbDistCount.Properties.Items.Add(i * 10);
            }
            cbDistCount.Text = "0";
            cbDistCount.SelectedItem = "0";
        }
        private void LoadTaolPrice()
        {
            Double totalAmount = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                totalAmount += Convert.ToDouble(gridView1.GetRowCellValue(i, "Thành_tiền"));
            }
            lbTotalAmount.Text = totalAmount.ToString("c", new CultureInfo("vi-VN"));

        }
        private void LoadTable() //Tạo bàn từ CSDL
        {
            fpnTable.Controls.Clear();
            var ListTable = db.Tables.Select(t => new { t.Id, t.Name, t.Status }).ToList();
            foreach (var item in ListTable)
            {
                SimpleButton btnTable = new SimpleButton() { Width = Const.I.TableWidth, Height = Const.I.TableHeight, Text = item.Name, Tag = item.Id, TabIndex = item.Id };
                btnTable.BackColor = item.Status == true ? Color.DarkCyan : Color.DarkOliveGreen;
                switch (item.Status)
                {
                    case true:
                        btnTable.Appearance.BackColor = Color.Red;
                        break;
                    case false:
                        btnTable.Appearance.BackColor = Color.Aqua;
                        break;
                }
                btnTable.Margin = new Padding(10, 5, 5, 5);
                btnTable.Click += BtnTable_Click;
                fpnTable.Controls.Add(btnTable);
            }
        }
        private void ShowTableInfo(int id) //Hiển thị thông tin bàn được chọn
        {
            var TableInfo = db.Tables.Select(t => new { t.Id, t.Name, t.Status }).Where(t => t.Id == id).ToList();
            foreach (var item in TableInfo)
            {
                lbTableName.Text = item.Name;
                if (item.Status == true)
                {
                    lbTableStatus.Text = "Có người";
                    lbTableStatus.ForeColor = Color.Lime;
                    btnThanhToan.Enabled = true;
                    btnFunc.Enabled = true;
                    cbDistCount.Enabled = true;
                    gridControl1.Visible = true;
                }
                else
                {
                    lbTableStatus.Text = "Trống";
                    lbTableStatus.ForeColor = Color.LightYellow;
                    btnThanhToan.Enabled = false;
                    btnFunc.Enabled = false;
                    cbDistCount.Enabled = false;
                }
                
            }
            LoadCbDisCount();
            LoadTaolPrice();
        }
        private void LoadCategory() //Lấy Category từ cơ sở dữ liệu
        {
            var ListCaegory = db.Categories.Select(c => new { c.Id, c.Name, c.Image }).ToList();
            fpnCategories.Controls.Clear();
            foreach (var item in ListCaegory)
            {
                SimpleButton btnCategory = new SimpleButton()
                {
                    Width = Const.I.CategoryW,
                    Height = Const.I.CategoryH,
                    Text = item.Name,
                    Tag = item.Id,
                    Margin = new Padding(Const.I.PaddCategory),
                    TabIndex = item.Id
                };
                btnCategory.Appearance.BackColor = Const.I.CategoryBG1;
                btnCategory.Appearance.BackColor = Const.I.CategoryBG2;
                btnCategory.ImageOptions.Image = Image.FromFile(Application.StartupPath + "\\image\\category\\" + item.Image.ToString());
                btnCategory.Click += BtnCategory_Click;
                fpnCategories.Controls.Add(btnCategory);
            }
        }
        private void LoadMenuById(int id) //Load danh sách Menu theo Id Category
        {
            fpnMenu.Controls.Clear();
            var ListMenus = db.Menus.Select(mn => new { mn.Id, mn.Name, mn.Price, mn.CategoryId, mn.Image }).Where(mn => mn.CategoryId == id).ToList();
            foreach (var item in ListMenus)
            {
                SimpleButton btnMenu = new SimpleButton()
                {
                    Width = Const.I.CategoryW,
                    Height = Const.I.CategoryH,
                    Text = item.Name + Environment.NewLine + "Giá: " + item.Price + " VND",
                    TabIndex = item.Id,
                    Margin = new Padding(Const.I.PaddingMenu)

                };
                btnMenu.ImageOptions.Image = Image.FromFile(Application.StartupPath + "\\image\\menu\\" + item.Image.ToString());
                btnMenu.Appearance.FontStyleDelta = FontStyle.Bold;
                btnMenu.Click += BtnMenu_Click;
                fpnMenu.Controls.Add(btnMenu);
            }
        }
        private void AddBill() //Thêm hóa đơn
        {
            Bill bill = new Bill();
            bill.DateCheckIn = DateTime.Now;
            bill.DateCheckOut = null;
            bill.TableId = idTable;
            bill.UserName = "Admin";
            bill.Discount = 0;
            db.Bills.Add(bill);
            db.SaveChanges();
        }
        private void AddBillInfo(ucOrderDetail myControl, int idMenu)
        {
            int billId = Convert.ToInt32(db.Bills.Where(b => b.TableId == idTable).Select(b => b.Id).Max());
            BillInfo billInfo = new BillInfo();
            billInfo.BillId = billId;
            billInfo.MenuId = idMenu;
            billInfo.Count = myControl.SoLuong;
            db.BillInfoes.Add(billInfo);
            Table table = db.Tables.SingleOrDefault(x => x.Id == idTable);
            table.Status = true;
            db.SaveChanges();
        } //thêm cthd
        private void ShowBill(int id)
        {
            var query = (from b in db.Bills
                         join bi in db.BillInfoes on b.Id equals bi.BillId
                         join m in db.Menus on bi.MenuId equals m.Id
                         where (b.TableId == id) && (b.Status == 0)
                         select new
                         {
                             ID = bi.Id,
                             Tên = m.Name,
                             Số_Lượng = bi.Count,
                             Đơn_Giá = m.Price,
                             Thành_tiền = m.Price * bi.Count,
                         }).ToList();
            gridControl1.DataSource = null;
            gridControl1.DataSource = query;
            gridView1.Columns[0].Visible = false;
            
        }

        private void CheckOut()//Thanh toán
        {
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                ten += gridView1.GetRowCellValue(i, "Tên").ToString() + Environment.NewLine;

                thanhtien += gridView1.GetRowCellValue(i, "Thành_tiền").ToString() + Environment.NewLine;
                
                soluong += gridView1.GetRowCellValue(i, "Số_Lượng").ToString() + Environment.NewLine;
                a += 5;
            }


            double price = Convert.ToDouble(lbTotalAmount.Text.Split(',')[0]);
            int discount = int.Parse(cbDistCount.SelectedText);
            double finalprice = (price - (price / 100) * discount)*1000;

            giamgia = discount.ToString() + "%";
            tongtien = finalprice.ToString("C", new CultureInfo("vi-VN"));

            if (XtraMessageBox.Show(string.Format("Thanh toán hóa đơn bàn {0} \n Giảm giá: {1} %\n Tổng tiền: {2}", idTable,discount,finalprice.ToString("C",new CultureInfo("vi-VN"))), "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int billId = Convert.ToInt32(db.Bills.Where(b => b.TableId == idTable).Select(b => b.Id).Max());
                Bill bill = db.Bills.SingleOrDefault(x => x.Id == billId);
                bill.Status = 1;
                bill.Discount = int.Parse(cbDistCount.SelectedText);
                bill.DateCheckOut = DateTime.Now;
                bill.TotalPrice =Convert.ToDouble(finalprice);
                Table tb = db.Tables.SingleOrDefault(x => x.Id == idTable);
                tb.Status = false;
                db.SaveChanges();
                ShowBill(idTable);
                LoadTable();
                ShowTableInfo(idTable);
                gridControl1.Visible = false;
                PrintBill();
                a = 0;
            }

            
        }
        private void DeleteBillInfo()
        {
            BillInfo bi = db.BillInfoes.SingleOrDefault(x => x.Id == idBillInfo);
            db.BillInfoes.Remove(bi);
            db.SaveChanges();
            LoadTaolPrice();
        }
        private void UpdateBillInfo()
        {
            ucOrderDetail myControl = new ucOrderDetail();
            if (DevExpress.XtraEditors.XtraDialog.Show(myControl, "Chỉnh sửa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BillInfo bi = db.BillInfoes.SingleOrDefault(x => x.Id == idBillInfo);
                bi.Count = myControl.SoLuong;
                //bi.Note = "Ghi chú";
                db.SaveChanges();
                ShowBill(idTable);
                LoadTaolPrice();
            }
            
        }
        private void PrintBill()
        {
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();

                _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing
                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                }
            }
            catch (Exception)
            {

            }
        }
      
        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = gridControl1.DataSource;

            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            FontHeigh = font.GetHeight();
            int startX = 10;
            int startY = 10;
            offset = 40;
            

            graphic.DrawString("NTP CAFE :>", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Tên Sản Phẩm".PadRight(15) + "Số Lượng".PadRight(10) + "Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            graphic.DrawString(ten, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(soluong, font, new SolidBrush(Color.Black), startX + 180, startY + offset);
            graphic.DrawString(thanhtien, font, new SolidBrush(Color.Black), startX + 260, startY + offset);

            offset = offset + (int)FontHeight + 60; //make the spacing consistent    

            graphic.DrawString("Giảm Giá ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(giamgia, font, new SolidBrush(Color.Black), startX + 260, startY + offset);

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("TỔNG TIỀN TRẢ ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(tongtien, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 260, startY + offset);

            offset = offset + (int)FontHeight + 10; //make the spacing consistent              
                         
            graphic.DrawString(" CAO ĐẲNG NGHỀ TP.HCM", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("38 TRẦN KHÁNH DƯ - Q1", font, new SolidBrush(Color.Black), startX, startY + offset);
            
        }
        
        #endregion
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string s ="";
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                s += gridView1.GetRowCellValue(i, "Tên").ToString()+Environment.NewLine;
                a += 5;

            }
            MessageBox.Show(a.ToString());
        }
    }
}
