namespace QLCF_TP.GUI
{
    partial class ucAccountManage
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccountManage));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SimpleContextButton simpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
            DevExpress.Utils.SimpleContextButton simpleContextButton2 = new DevExpress.Utils.SimpleContextButton();
            DevExpress.Utils.SimpleContextButton simpleContextButton3 = new DevExpress.Utils.SimpleContextButton();
            DevExpress.Utils.SimpleContextButton simpleContextButton4 = new DevExpress.Utils.SimpleContextButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCF_NTPDataSet = new QLCF_TP.QLCF_NTPDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncolThem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncolDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPassWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountTableAdapter = new QLCF_TP.QLCF_NTPDataSetTableAdapters.AccountTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCF_NTPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncolThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncolDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1034, 84);
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
            this.labelControl1.Size = new System.Drawing.Size(121, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "NHÂN VIÊN";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.accountBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btncolThem,
            this.btncolDel,
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(1034, 495);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.qLCF_NTPDataSet;
            // 
            // qLCF_NTPDataSet
            // 
            this.qLCF_NTPDataSet.DataSetName = "QLCF_NTPDataSet";
            this.qLCF_NTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdd,
            this.colDel,
            this.colType,
            this.colPassWord,
            this.colUserName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colAdd
            // 
            this.colAdd.Caption = "Thêm";
            this.colAdd.ColumnEdit = this.btncolThem;
            this.colAdd.Name = "colAdd";
            this.colAdd.Visible = true;
            this.colAdd.VisibleIndex = 0;
            this.colAdd.Width = 69;
            // 
            // btncolThem
            // 
            this.btncolThem.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btncolThem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btncolThem.Name = "btncolThem";
            this.btncolThem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btncolThem.Click += new System.EventHandler(this.btncolThem_Click);
            // 
            // colDel
            // 
            this.colDel.Caption = "Xóa";
            this.colDel.ColumnEdit = this.btncolDel;
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 1;
            this.colDel.Width = 90;
            // 
            // btncolDel
            // 
            this.btncolDel.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.btncolDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btncolDel.Name = "btncolDel";
            this.btncolDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btncolDel.Click += new System.EventHandler(this.btncolDel_Click);
            // 
            // colType
            // 
            this.colType.Caption = "Loại tài khoản";
            this.colType.ColumnEdit = this.repositoryItemComboBox1;
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 4;
            this.colType.Width = 230;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton1.Caption = "simpleContextButton1";
            simpleContextButton1.Id = new System.Guid("1e13a2eb-e1f9-4c62-8376-d063827280ea");
            simpleContextButton1.Name = "simpleContextButton1";
            simpleContextButton2.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton2.Caption = "simpleContextButton2";
            simpleContextButton2.Id = new System.Guid("305d22f6-58d5-41fa-ae35-3dda15be4c67");
            simpleContextButton2.Name = "simpleContextButton2";
            simpleContextButton3.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton3.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton3.Caption = "simpleContextButton3";
            simpleContextButton3.Id = new System.Guid("8bf50a49-6be7-44ac-9033-c315b05c9e00");
            simpleContextButton3.Name = "simpleContextButton3";
            simpleContextButton4.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton4.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton4.Caption = "simpleContextButton4";
            simpleContextButton4.Id = new System.Guid("7a4507d5-b943-460d-9f73-ebdac4fd6351");
            simpleContextButton4.Name = "simpleContextButton4";
            this.repositoryItemComboBox1.ContextButtons.Add(simpleContextButton1);
            this.repositoryItemComboBox1.ContextButtons.Add(simpleContextButton2);
            this.repositoryItemComboBox1.ContextButtons.Add(simpleContextButton3);
            this.repositoryItemComboBox1.ContextButtons.Add(simpleContextButton4);
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colPassWord
            // 
            this.colPassWord.Caption = "Mật khẩu";
            this.colPassWord.FieldName = "PassWord";
            this.colPassWord.Name = "colPassWord";
            this.colPassWord.Visible = true;
            this.colPassWord.VisibleIndex = 3;
            this.colPassWord.Width = 343;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Tài hoản";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            this.colUserName.Width = 284;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // ucAccountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ucAccountManage";
            this.Size = new System.Drawing.Size(1034, 579);
            this.Load += new System.EventHandler(this.ucAccountManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCF_NTPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncolThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncolDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btncolThem;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btncolDel;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private QLCF_NTPDataSet qLCF_NTPDataSet;
        private QLCF_NTPDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPassWord;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
    }
}
