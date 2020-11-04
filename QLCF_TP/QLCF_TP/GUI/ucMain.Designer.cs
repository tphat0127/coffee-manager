namespace QLCF_TP.GUI
{
    partial class ucMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMain));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fpnMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTableInfo = new System.Windows.Forms.Panel();
            this.btnFunc = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbDistCount = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalAmount = new DevExpress.XtraEditors.LabelControl();
            this.lbTableName = new DevExpress.XtraEditors.LabelControl();
            this.lbTableStatus = new DevExpress.XtraEditors.LabelControl();
            this.lbDCI = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fpnTable = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnTableInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDistCount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Xoa)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem_Sua
            // 
            this.barButtonItem_Sua.Caption = "Sửa";
            this.barButtonItem_Sua.Id = 4;
            this.barButtonItem_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.ImageOptions.Image")));
            this.barButtonItem_Sua.Name = "barButtonItem_Sua";
            this.barButtonItem_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem_Xoa
            // 
            this.barButtonItem_Xoa.Caption = "Xóa";
            this.barButtonItem_Xoa.Id = 5;
            this.barButtonItem_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Xoa.ImageOptions.Image")));
            this.barButtonItem_Xoa.Name = "barButtonItem_Xoa";
            this.barButtonItem_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Xoa_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem3,
            this.barButtonItem_Sua,
            this.barButtonItem_Xoa});
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemHypertextLabel1,
            this.repositoryItemButtonEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1499, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 655);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1499, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1499, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 655);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnTableInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(386, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 655);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.fpnMenu);
            this.panel3.Controls.Add(this.fpnCategories);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(553, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 655);
            this.panel3.TabIndex = 10;
            // 
            // fpnMenu
            // 
            this.fpnMenu.AutoScroll = true;
            this.fpnMenu.BackColor = System.Drawing.Color.Salmon;
            this.fpnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fpnMenu.BackgroundImage")));
            this.fpnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnMenu.Location = new System.Drawing.Point(0, 348);
            this.fpnMenu.Name = "fpnMenu";
            this.fpnMenu.Size = new System.Drawing.Size(560, 307);
            this.fpnMenu.TabIndex = 10;
            // 
            // fpnCategories
            // 
            this.fpnCategories.AutoScroll = true;
            this.fpnCategories.BackColor = System.Drawing.Color.Transparent;
            this.fpnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpnCategories.Location = new System.Drawing.Point(0, 0);
            this.fpnCategories.Name = "fpnCategories";
            this.fpnCategories.Size = new System.Drawing.Size(560, 348);
            this.fpnCategories.TabIndex = 9;
            // 
            // pnTableInfo
            // 
            this.pnTableInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnTableInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTableInfo.BackgroundImage")));
            this.pnTableInfo.Controls.Add(this.btnFunc);
            this.pnTableInfo.Controls.Add(this.gridControl1);
            this.pnTableInfo.Controls.Add(this.label1);
            this.pnTableInfo.Controls.Add(this.simpleButton1);
            this.pnTableInfo.Controls.Add(this.cbDistCount);
            this.pnTableInfo.Controls.Add(this.btnThanhToan);
            this.pnTableInfo.Controls.Add(this.btnOrder);
            this.pnTableInfo.Controls.Add(this.labelControl5);
            this.pnTableInfo.Controls.Add(this.labelControl4);
            this.pnTableInfo.Controls.Add(this.labelControl12);
            this.pnTableInfo.Controls.Add(this.labelControl3);
            this.pnTableInfo.Controls.Add(this.labelControl2);
            this.pnTableInfo.Controls.Add(this.lbTotalAmount);
            this.pnTableInfo.Controls.Add(this.lbTableName);
            this.pnTableInfo.Controls.Add(this.lbTableStatus);
            this.pnTableInfo.Controls.Add(this.lbDCI);
            this.pnTableInfo.Controls.Add(this.labelControl1);
            this.pnTableInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTableInfo.Location = new System.Drawing.Point(0, 0);
            this.pnTableInfo.Name = "pnTableInfo";
            this.pnTableInfo.Size = new System.Drawing.Size(553, 655);
            this.pnTableInfo.TabIndex = 9;
            // 
            // btnFunc
            // 
            this.btnFunc.DropDownControl = this.popupMenu2;
            this.btnFunc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFunc.ImageOptions.SvgImage")));
            this.btnFunc.Location = new System.Drawing.Point(393, 386);
            this.btnFunc.MenuManager = this.barManager2;
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(135, 46);
            this.btnFunc.TabIndex = 6;
            this.btnFunc.Text = "Chức Năng";
            // 
            // popupMenu2
            // 
            this.popupMenu2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu2.Manager = this.barManager2;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Chuyển Bàn";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Gộp Bàn";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager2.MaxItemId = 2;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1499, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 655);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1499, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1499, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 655);
            // 
            // gridControl1
            // 
            this.gridControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridControl1.BackgroundImage")));
            this.gridControl1.Location = new System.Drawing.Point(27, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(475, 181);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(60, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "BÀN CHƯA ORDER";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(446, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(37, 25);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "X";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbDistCount
            // 
            this.cbDistCount.Location = new System.Drawing.Point(208, 305);
            this.cbDistCount.Name = "cbDistCount";
            this.cbDistCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cbDistCount.Properties.Appearance.Options.UseFont = true;
            this.cbDistCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDistCount.Size = new System.Drawing.Size(100, 24);
            this.cbDistCount.TabIndex = 2;
            this.cbDistCount.SelectedIndexChanged += new System.EventHandler(this.cbDistCount_SelectedIndexChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThanhToan.ImageOptions.SvgImage")));
            this.btnThanhToan.Location = new System.Drawing.Point(217, 386);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 46);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.Appearance.BackColor2 = System.Drawing.Color.DarkRed;
            this.btnOrder.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.btnOrder.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnOrder.Appearance.Options.UseBackColor = true;
            this.btnOrder.Appearance.Options.UseForeColor = true;
            this.btnOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.ImageOptions.Image")));
            this.btnOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOrder.ImageOptions.SvgImage")));
            this.btnOrder.Location = new System.Drawing.Point(44, 386);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 46);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Gọi Món";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(44, 348);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 23);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Thành Tiền";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(314, 302);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 23);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "%";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(44, 302);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(76, 23);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "Giảm Giá";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Giờ đến";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(289, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tình Trạng";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTotalAmount.Appearance.Options.UseFont = true;
            this.lbTotalAmount.Appearance.Options.UseForeColor = true;
            this.lbTotalAmount.Location = new System.Drawing.Point(217, 340);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(38, 33);
            this.lbTotalAmount.TabIndex = 0;
            this.lbTotalAmount.Text = "0 đ";
            // 
            // lbTableName
            // 
            this.lbTableName.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbTableName.Appearance.Options.UseFont = true;
            this.lbTableName.Appearance.Options.UseForeColor = true;
            this.lbTableName.Location = new System.Drawing.Point(117, 15);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(83, 33);
            this.lbTableName.TabIndex = 0;
            this.lbTableName.Text = "Bàn 01";
            // 
            // lbTableStatus
            // 
            this.lbTableStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableStatus.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lbTableStatus.Appearance.Options.UseFont = true;
            this.lbTableStatus.Appearance.Options.UseForeColor = true;
            this.lbTableStatus.Location = new System.Drawing.Point(408, 64);
            this.lbTableStatus.Name = "lbTableStatus";
            this.lbTableStatus.Size = new System.Drawing.Size(75, 23);
            this.lbTableStatus.TabIndex = 0;
            this.lbTableStatus.Text = "Có người";
            // 
            // lbDCI
            // 
            this.lbDCI.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDCI.Appearance.Options.UseFont = true;
            this.lbDCI.Location = new System.Drawing.Point(117, 64);
            this.lbDCI.Name = "lbDCI";
            this.lbDCI.Size = new System.Drawing.Size(137, 23);
            this.lbDCI.TabIndex = 0;
            this.lbDCI.Text = "7:30 30/02/2018";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bàn";
            // 
            // fpnTable
            // 
            this.fpnTable.AutoScroll = true;
            this.fpnTable.BackColor = System.Drawing.Color.Transparent;
            this.fpnTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.fpnTable.Location = new System.Drawing.Point(0, 0);
            this.fpnTable.Name = "fpnTable";
            this.fpnTable.Size = new System.Drawing.Size(386, 655);
            this.fpnTable.TabIndex = 5;
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpnTable);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(1499, 655);
            this.Load += new System.EventHandler(this.ucMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnTableInfo.ResumeLayout(false);
            this.pnTableInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDistCount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Sua;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private System.Windows.Forms.FlowLayoutPanel fpnMenu;
        private System.Windows.Forms.FlowLayoutPanel fpnCategories;
        private System.Windows.Forms.Panel pnTableInfo;
        private DevExpress.XtraEditors.DropDownButton btnFunc;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cbDistCount;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnOrder;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbTotalAmount;
        private DevExpress.XtraEditors.LabelControl lbTableName;
        private DevExpress.XtraEditors.LabelControl lbTableStatus;
        private DevExpress.XtraEditors.LabelControl lbDCI;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.FlowLayoutPanel fpnTable;
    }
}
