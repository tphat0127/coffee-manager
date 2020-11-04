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
using System.Globalization;
using DevExpress.XtraCharts;

namespace QLCF_TP.GUI
{
    public partial class ucBillManage : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucBillManage instance;

        public static ucBillManage Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucBillManage();
                return instance;
            }
        }
        QLCF_NTPEntities db = new QLCF_NTPEntities();

        public ucBillManage()
        {
            InitializeComponent();
            
        }
        void LoadGrid(DateTime firsday, DateTime lastday)
        {
            firsday = dateNavigator1.SelectionStart;
            lastday = dateNavigator1.SelectionEnd;
            var query = (from t in db.Tables
                         join b in db.Bills
                         on t.Id equals b.TableId
                         where (b.DateCheckIn >= firsday) && (b.DateCheckOut < lastday)
                         select new
                         {
                             Tên_Bàn = t.Name,
                             Tổng_Tiền = b.TotalPrice,
                             Ngày_Đến = b.DateCheckIn,
                             Ngày_Thanh_Toán = b.DateCheckOut,
                             Giảm_Giá = b.Discount
                         }).ToList();
            gridControl1.DataSource = query;
        }
        private void dateNavigator1_Click(object sender, EventArgs e)
        {
            LoadGrid(dateNavigator1.SelectionStart, dateNavigator1.SelectionEnd);
        }

        private void LoadChart()
        {
            chartControl2.Series.Clear();
            chartControl2.Titles.Clear();
            DateTime toMonth = new DateTime(dateNavigator1.DateTime.Year, dateNavigator1.DateTime.Month, 1);
            DateTime lastMonth = toMonth.AddMonths(1).AddDays(-1);

            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "BIỂU ĐỒ DOANH THU THÁNG " + toMonth.Month.ToString();

            

            Series series = new Series("Tổng tiền trung bình", ViewType.Line);
            series.ArgumentScaleType = ScaleType.DateTime;
            series.ValueScaleType = ScaleType.Numerical;

            series.ArgumentDataMember = "DateCheckOut";
            series.ValueDataMembers[0] = "TotalPrice";


            chartControl2.Titles.Add(chartTitle1);
            chartControl2.Series.Add(series);
            chartControl2.DataSource = db.FN_ViewDoanThu(toMonth, lastMonth);
        }

        private void LoadChartProduct()
        {
            chartControl1.Series.Clear();
            chartControl1.Titles.Clear();
            DateTime toMonth = new DateTime(dateNavigator2.DateTime.Year, dateNavigator2.DateTime.Month, 1);
            DateTime lastMonth = toMonth.AddMonths(1).AddDays(-1);

            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "BIỂU ĐỒ SẢN PHẨM TIÊU THỤ THÁNG " + toMonth.Month.ToString() + "/" + toMonth.Year.ToString();



            Series series = new Series("", ViewType.Pie);

            var query = db.FN_ViewSanPham(toMonth, lastMonth).Select(s=> new { s.Tên, s.Số_Lượng});
            foreach (var dr in query)
                series.Points.Add(new SeriesPoint(dr.Tên,dr.Số_Lượng));


            series.Label.TextPattern = "{A}: {VP:p2}";
            PieSeriesView myView = (PieSeriesView)series.View;
            myView.Titles.Add(new SeriesTitle());
            myView.Titles[0].Text = series.Name;
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 30;
            myView.RuntimeExploding = true;
            myView.HeightToWidthRatio = 0.75;
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.Center;


            chartControl1.Titles.Add(chartTitle1);
            chartControl1.Series.Add(series);
            chartControl1.DataSource = db.FN_ViewSanPham(toMonth, lastMonth);
        }

        private void ucBillManage_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            LoadGrid(today, today);
            LoadChart();
            LoadChartProduct();
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\image\\logo.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

           
        }

      
        private void dateNavigator1_Click_2(object sender, EventArgs e)
        {
            LoadGrid(dateNavigator1.SelectionStart, dateNavigator1.SelectionEnd);
            LoadChart();
        }

        private void dateNavigator2_Click(object sender, EventArgs e)
        {
            LoadChartProduct();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
