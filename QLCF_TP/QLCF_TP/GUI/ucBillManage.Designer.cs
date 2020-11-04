namespace QLCF_TP.GUI
{
    partial class ucBillManage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBillManage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.billInfoTableAdapter = new QLCF_TP.QLCF_NTPDataSetTableAdapters.BillInfoTableAdapter();
            this.billInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCF_NTPDataSet = new QLCF_TP.QLCF_NTPDataSet();
            this.qLCF_NTPDataSet2 = new QLCF_TP.QLCF_NTPDataSet2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabDoanhThu = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabSanPham = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.dateNavigator2 = new DevExpress.XtraScheduler.DateNavigator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCF_NTPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCF_NTPDataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator2.CalendarTimeProperties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 84);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 74);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(194, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "THỐNG KÊ";
            // 
            // billInfoTableAdapter
            // 
            this.billInfoTableAdapter.ClearBeforeFill = true;
            // 
            // billInfoBindingSource
            // 
            this.billInfoBindingSource.DataMember = "BillInfo";
            this.billInfoBindingSource.DataSource = this.qLCF_NTPDataSet;
            // 
            // qLCF_NTPDataSet
            // 
            this.qLCF_NTPDataSet.DataSetName = "QLCF_NTPDataSet";
            this.qLCF_NTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLCF_NTPDataSet2
            // 
            this.qLCF_NTPDataSet2.DataSetName = "QLCF_NTPDataSet2";
            this.qLCF_NTPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabPane1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1392, 537);
            this.panel2.TabIndex = 6;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabDoanhThu);
            this.tabPane1.Controls.Add(this.tabSanPham);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabDoanhThu,
            this.tabSanPham});
            this.tabPane1.RegularSize = new System.Drawing.Size(1392, 537);
            this.tabPane1.SelectedPage = this.tabDoanhThu;
            this.tabPane1.Size = new System.Drawing.Size(1392, 537);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "dđ1";
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Caption = "Doanh Thu";
            this.tabDoanhThu.Controls.Add(this.chartControl2);
            this.tabDoanhThu.Controls.Add(this.gridControl1);
            this.tabDoanhThu.Controls.Add(this.dateNavigator1);
            this.tabDoanhThu.Controls.Add(this.panel3);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Size = new System.Drawing.Size(1392, 510);
            // 
            // tabSanPham
            // 
            this.tabSanPham.Caption = "Sản Phẩm";
            this.tabSanPham.Controls.Add(this.chartControl1);
            this.tabSanPham.Controls.Add(this.dateNavigator2);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Size = new System.Drawing.Size(1392, 510);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(387, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(1005, 510);
            this.chartControl1.TabIndex = 10;
            // 
            // dateNavigator2
            // 
            this.dateNavigator2.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator2.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigator2.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dateNavigator2.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator2.Name = "dateNavigator2";
            this.dateNavigator2.Size = new System.Drawing.Size(387, 510);
            this.dateNavigator2.TabIndex = 11;
            this.dateNavigator2.Click += new System.EventHandler(this.dateNavigator2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1392, 46);
            this.panel3.TabIndex = 9;
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(387, 227);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(1005, 237);
            this.chartControl2.TabIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(387, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1005, 227);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(387, 464);
            this.dateNavigator1.TabIndex = 12;
            this.dateNavigator1.Click += new System.EventHandler(this.dateNavigator1_Click_2);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.Location = new System.Drawing.Point(1231, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(161, 46);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Tạo Báo Cáo";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ucBillManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucBillManage";
            this.Size = new System.Drawing.Size(1392, 621);
            this.Load += new System.EventHandler(this.ucBillManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCF_NTPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCF_NTPDataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QLCF_NTPDataSetTableAdapters.BillInfoTableAdapter billInfoTableAdapter;
        private System.Windows.Forms.BindingSource billInfoBindingSource;
        private QLCF_NTPDataSet qLCF_NTPDataSet;
        private QLCF_NTPDataSet2 qLCF_NTPDataSet2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabDoanhThu;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabSanPham;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator2;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnReport;
    }
}
