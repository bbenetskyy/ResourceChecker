namespace ResourceChecker.Controls
{
    partial class SettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.tokenEdit1 = new DevExpress.XtraEditors.TokenEdit();
            this.SelectFolder = new DevExpress.XtraEditors.SimpleButton();
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TokenEdit();
            this.textEdit6 = new DevExpress.XtraEditors.RadioGroup();
            this.settingsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CheckGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CheckInContolItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.CheckAtControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.IgnoreGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.SkipConditionControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.SkipTextControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.SearchGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.FindWhatControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.LookAtControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LookInControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInContolItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAtControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IgnoreGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipConditionControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipTextControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindWhatControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookAtControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookInControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.tokenEdit1);
            this.dataLayoutControl1.Controls.Add(this.SelectFolder);
            this.dataLayoutControl1.Controls.Add(this.Cancel);
            this.dataLayoutControl1.Controls.Add(this.Save);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.Controls.Add(this.textEdit3);
            this.dataLayoutControl1.Controls.Add(this.textEdit7);
            this.dataLayoutControl1.Controls.Add(this.textEdit4);
            this.dataLayoutControl1.Controls.Add(this.textEdit5);
            this.dataLayoutControl1.Controls.Add(this.textEdit6);
            this.dataLayoutControl1.DataSource = this.settingsModelBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(692, 411);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // tokenEdit1
            // 
            this.tokenEdit1.Location = new System.Drawing.Point(84, 66);
            this.tokenEdit1.Name = "tokenEdit1";
            this.tokenEdit1.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook;
            this.tokenEdit1.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.TokenList;
            this.tokenEdit1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.tokenEdit1.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cs", "*.cs"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.ts", "*.ts"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.*", "*.*"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.tmpl.html", "*.tmpl.html"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.html", "*.html"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.js", "*.js"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.c", "*.c"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cpp", "*.cpp"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.txt", "*.txt"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.xml", "*.xml"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cshtml", "*.cshtml"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.xaml", "*.xaml"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.resx", "*.resx"));
            this.tokenEdit1.Properties.UseReadOnlyAppearance = false;
            this.tokenEdit1.Size = new System.Drawing.Size(584, 20);
            this.tokenEdit1.StyleController = this.dataLayoutControl1;
            this.tokenEdit1.TabIndex = 8;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(640, 90);
            this.SelectFolder.MaximumSize = new System.Drawing.Size(28, 22);
            this.SelectFolder.MinimumSize = new System.Drawing.Size(28, 22);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(28, 22);
            this.SelectFolder.StyleController = this.dataLayoutControl1;
            this.SelectFolder.TabIndex = 7;
            this.SelectFolder.Text = "...";
            this.SelectFolder.ToolTip = "Choose Search Folders";
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // Cancel
            // 
            this.Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.ImageOptions.Image")));
            this.Cancel.Location = new System.Drawing.Point(389, 366);
            this.Cancel.MaximumSize = new System.Drawing.Size(120, 22);
            this.Cancel.MinimumSize = new System.Drawing.Size(120, 22);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(120, 22);
            this.Cancel.StyleController = this.dataLayoutControl1;
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Save.ImageOptions.Image")));
            this.Save.Location = new System.Drawing.Point(265, 366);
            this.Save.MaximumSize = new System.Drawing.Size(120, 22);
            this.Save.MinimumSize = new System.Drawing.Size(120, 22);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 22);
            this.Save.StyleController = this.dataLayoutControl1;
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(84, 42);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(584, 20);
            this.textEdit1.StyleController = this.dataLayoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(84, 90);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(552, 20);
            this.textEdit3.StyleController = this.dataLayoutControl1;
            this.textEdit3.TabIndex = 4;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(84, 182);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(584, 20);
            this.textEdit7.StyleController = this.dataLayoutControl1;
            this.textEdit7.TabIndex = 4;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(84, 248);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(584, 20);
            this.textEdit4.StyleController = this.dataLayoutControl1;
            this.textEdit4.TabIndex = 4;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(84, 158);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook;
            this.textEdit5.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.TokenList;
            this.textEdit5.Properties.Separators.AddRange(new string[] {
            ","});
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cs", "*.cs"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.ts", "*.ts"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.*", "*.*"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.tmpl.html", "*.tmpl.html"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.html", "*.html"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.js", "*.js"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.c", "*.c"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cpp", "*.cpp"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.txt", "*.txt"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.xml", "*.xml"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cshtml", "*.cshtml"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.xaml", "*.xaml"));
            this.textEdit5.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.resx", "*.resx"));
            this.textEdit5.Size = new System.Drawing.Size(584, 20);
            this.textEdit5.StyleController = this.dataLayoutControl1;
            this.textEdit5.TabIndex = 4;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(84, 272);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Columns = 1;
            this.textEdit6.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Contains", "Contains", true, "Contains"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("StartWith", "StartWith", true, "StartWith"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Equal", "Equal", true, "Equal")});
            this.textEdit6.Size = new System.Drawing.Size(584, 78);
            this.textEdit6.StyleController = this.dataLayoutControl1;
            this.textEdit6.TabIndex = 4;
            // 
            // settingsModelBindingSource
            // 
            this.settingsModelBindingSource.DataSource = typeof(ResourceChecker.Models.SettingsModel);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CheckGroup,
            this.IgnoreGroup,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.SearchGroup});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(692, 411);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // CheckGroup
            // 
            this.CheckGroup.CustomizationFormText = "Check in Files";
            this.CheckGroup.ExpandButtonVisible = true;
            this.CheckGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CheckInContolItem,
            this.CheckAtControlItem});
            this.CheckGroup.Location = new System.Drawing.Point(0, 116);
            this.CheckGroup.Name = "CheckGroup";
            this.CheckGroup.Size = new System.Drawing.Size(672, 90);
            this.CheckGroup.Text = "Check in Files";
            // 
            // CheckInContolItem
            // 
            this.CheckInContolItem.Control = this.textEdit5;
            this.CheckInContolItem.CustomizationFormText = "Check in";
            this.CheckInContolItem.Location = new System.Drawing.Point(0, 0);
            this.CheckInContolItem.Name = "CheckInContolItem";
            this.CheckInContolItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.CheckInContolItem.Size = new System.Drawing.Size(648, 24);
            this.CheckInContolItem.Text = "Check in:";
            this.CheckInContolItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // CheckAtControlItem
            // 
            this.CheckAtControlItem.Control = this.textEdit7;
            this.CheckAtControlItem.CustomizationFormText = "Check at";
            this.CheckAtControlItem.Location = new System.Drawing.Point(0, 24);
            this.CheckAtControlItem.Name = "CheckAtControlItem";
            this.CheckAtControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.CheckAtControlItem.Size = new System.Drawing.Size(648, 24);
            this.CheckAtControlItem.Text = "Check at:";
            this.CheckAtControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // IgnoreGroup
            // 
            this.IgnoreGroup.ExpandButtonVisible = true;
            this.IgnoreGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.SkipConditionControlItem,
            this.SkipTextControlItem});
            this.IgnoreGroup.Location = new System.Drawing.Point(0, 206);
            this.IgnoreGroup.Name = "IgnoreGroup";
            this.IgnoreGroup.Size = new System.Drawing.Size(672, 148);
            this.IgnoreGroup.Text = "Find options";
            // 
            // SkipConditionControlItem
            // 
            this.SkipConditionControlItem.Control = this.textEdit6;
            this.SkipConditionControlItem.CustomizationFormText = "Skip by";
            this.SkipConditionControlItem.Location = new System.Drawing.Point(0, 24);
            this.SkipConditionControlItem.Name = "SkipConditionControlItem";
            this.SkipConditionControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.SkipConditionControlItem.Size = new System.Drawing.Size(648, 82);
            this.SkipConditionControlItem.Text = "Skip by:";
            this.SkipConditionControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // SkipTextControlItem
            // 
            this.SkipTextControlItem.Control = this.textEdit4;
            this.SkipTextControlItem.CustomizationFormText = "Skip text";
            this.SkipTextControlItem.Location = new System.Drawing.Point(0, 0);
            this.SkipTextControlItem.Name = "SkipTextControlItem";
            this.SkipTextControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.SkipTextControlItem.Size = new System.Drawing.Size(648, 24);
            this.SkipTextControlItem.Text = "Skip text:";
            this.SkipTextControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // SearchGroup
            // 
            this.SearchGroup.CustomizationFormText = "Find in Files";
            this.SearchGroup.ExpandButtonVisible = true;
            this.SearchGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.FindWhatControlItem,
            this.LookAtControlItem,
            this.layoutControlItem3,
            this.LookInControlItem});
            this.SearchGroup.Location = new System.Drawing.Point(0, 0);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(672, 116);
            this.SearchGroup.Text = "Find in Files";
            // 
            // FindWhatControlItem
            // 
            this.FindWhatControlItem.Control = this.textEdit1;
            this.FindWhatControlItem.CustomizationFormText = "Find what";
            this.FindWhatControlItem.Location = new System.Drawing.Point(0, 0);
            this.FindWhatControlItem.Name = "FindWhatControlItem";
            this.FindWhatControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.FindWhatControlItem.Size = new System.Drawing.Size(648, 24);
            this.FindWhatControlItem.Text = "Find what:";
            this.FindWhatControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // LookAtControlItem
            // 
            this.LookAtControlItem.Control = this.textEdit3;
            this.LookAtControlItem.CustomizationFormText = "Look at";
            this.LookAtControlItem.Location = new System.Drawing.Point(0, 48);
            this.LookAtControlItem.Name = "LookAtControlItem";
            this.LookAtControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.LookAtControlItem.Size = new System.Drawing.Size(616, 26);
            this.LookAtControlItem.Text = "Look at:";
            this.LookAtControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.SelectFolder;
            this.layoutControlItem3.Location = new System.Drawing.Point(616, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(32, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // LookInControlItem
            // 
            this.LookInControlItem.Control = this.tokenEdit1;
            this.LookInControlItem.Location = new System.Drawing.Point(0, 24);
            this.LookInControlItem.Name = "LookInControlItem";
            this.LookInControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.LookInControlItem.Size = new System.Drawing.Size(648, 24);
            this.LookInControlItem.Text = "Look in";
            this.LookInControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Cancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(377, 354);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Save;
            this.layoutControlItem1.Location = new System.Drawing.Point(253, 354);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 354);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(253, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(501, 354);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(171, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 380);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(672, 11);
            this.emptySpaceItem4.Text = "emptySpaceItem2";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(692, 411);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInContolItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAtControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IgnoreGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipConditionControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipTextControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindWhatControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookAtControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookInControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.BindingSource settingsModelBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem FindWhatControlItem;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraLayout.LayoutControlItem LookAtControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup SearchGroup;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraLayout.LayoutControlGroup CheckGroup;
        private DevExpress.XtraLayout.LayoutControlGroup IgnoreGroup;
        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.SimpleButton Save;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton SelectFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TokenEdit tokenEdit1;
        private DevExpress.XtraLayout.LayoutControlItem CheckAtControlItem;
        private DevExpress.XtraLayout.LayoutControlItem SkipConditionControlItem;
        private DevExpress.XtraLayout.LayoutControlItem SkipTextControlItem;
        private DevExpress.XtraLayout.LayoutControlItem LookInControlItem;
        private DevExpress.XtraLayout.LayoutControlItem CheckInContolItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.TokenEdit textEdit5;
        private DevExpress.XtraEditors.RadioGroup textEdit6;
    }
}
