namespace ResourceChecker.Controls
{
    partial class ResultControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultControl));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.resultModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.statusImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(828, 442);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.resultModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.statusImageComboBox});
            this.gridControl1.Size = new System.Drawing.Size(804, 418);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // resultModelBindingSource
            // 
            this.resultModelBindingSource.DataSource = typeof(ResourceChecker.Models.ResultModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStatus,
            this.colText});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colStatus
            // 
            this.colStatus.ColumnEdit = this.statusImageComboBox;
            this.colStatus.FieldName = "Status";
            this.colStatus.MaxWidth = 40;
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.ReadOnly = true;
            this.colStatus.OptionsColumn.ShowCaption = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 0;
            this.colStatus.Width = 30;
            // 
            // statusImageComboBox
            // 
            this.statusImageComboBox.AutoHeight = false;
            this.statusImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusImageComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statusImageComboBox.HtmlImages = this.statusImageCollection;
            this.statusImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", ResourceChecker.Models.Enums.Status.Failed, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", ResourceChecker.Models.Enums.Status.Passed, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", ResourceChecker.Models.Enums.Status.Duplicated, 2)});
            this.statusImageComboBox.LargeImages = this.statusImageCollection;
            this.statusImageComboBox.Name = "statusImageComboBox";
            this.statusImageComboBox.ReadOnly = true;
            this.statusImageComboBox.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.statusImageComboBox.SmallImages = this.statusImageCollection;
            // 
            // statusImageCollection
            // 
            this.statusImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("statusImageCollection.ImageStream")));
            this.statusImageCollection.InsertGalleryImage("cancel_16x16.png", "office2013/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_16x16.png"), 0);
            this.statusImageCollection.Images.SetKeyName(0, "cancel_16x16.png");
            this.statusImageCollection.InsertGalleryImage("apply_16x16.png", "office2013/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_16x16.png"), 1);
            this.statusImageCollection.Images.SetKeyName(1, "apply_16x16.png");
            this.statusImageCollection.InsertGalleryImage("warning_32x32.png", "images/status/warning_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/status/warning_32x32.png"), 2);
            this.statusImageCollection.Images.SetKeyName(2, "warning_32x32.png");
            // 
            // colText
            // 
            this.colText.FieldName = "Text";
            this.colText.Name = "colText";
            this.colText.OptionsColumn.AllowEdit = false;
            this.colText.OptionsColumn.ReadOnly = true;
            this.colText.OptionsColumn.ShowCaption = false;
            this.colText.Visible = true;
            this.colText.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(828, 442);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(808, 422);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ResultControl";
            this.Size = new System.Drawing.Size(828, 442);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource resultModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.Utils.ImageCollection statusImageCollection;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox statusImageComboBox;
    }
}
