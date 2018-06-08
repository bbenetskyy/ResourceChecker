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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.lookIn = new DevExpress.XtraEditors.TokenEdit();
            this.selectFolderToLook = new DevExpress.XtraEditors.SimpleButton();
            this.findWhat = new DevExpress.XtraEditors.TextEdit();
            this.lookAt = new DevExpress.XtraEditors.TextEdit();
            this.checkAt = new DevExpress.XtraEditors.TextEdit();
            this.skipText = new DevExpress.XtraEditors.TextEdit();
            this.checkIn = new DevExpress.XtraEditors.TokenEdit();
            this.skipBy = new DevExpress.XtraEditors.RadioGroup();
            this.settingsModelBindingSource = new System.Windows.Forms.BindingSource();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CheckGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CheckInContolItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.CheckAtControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.IgnoreGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.SkipConditionControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.SkipTextControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.S = new DevExpress.XtraLayout.EmptySpaceItem();
            this.SearchGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.FindWhatControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.LookAtControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.SelectFolderToLookControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.LookInControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.selectFolderToCheck = new DevExpress.XtraEditors.SimpleButton();
            this.SelectFolderToCheckControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findWhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInContolItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAtControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IgnoreGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipConditionControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipTextControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindWhatControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookAtControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFolderToLookControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookInControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFolderToCheckControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.selectFolderToCheck);
            this.dataLayoutControl1.Controls.Add(this.lookIn);
            this.dataLayoutControl1.Controls.Add(this.selectFolderToLook);
            this.dataLayoutControl1.Controls.Add(this.findWhat);
            this.dataLayoutControl1.Controls.Add(this.lookAt);
            this.dataLayoutControl1.Controls.Add(this.checkAt);
            this.dataLayoutControl1.Controls.Add(this.skipText);
            this.dataLayoutControl1.Controls.Add(this.checkIn);
            this.dataLayoutControl1.Controls.Add(this.skipBy);
            this.dataLayoutControl1.DataSource = this.settingsModelBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(692, 411);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // lookIn
            // 
            this.lookIn.Location = new System.Drawing.Point(84, 67);
            this.lookIn.Name = "lookIn";
            this.lookIn.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook;
            this.lookIn.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.TokenList;
            this.lookIn.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.lookIn.Properties.Separators.AddRange(new string[] {
            ","});
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cs", "*.cs"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.ts", "*.ts"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.*", "*.*"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.tmpl.html", "*.tmpl.html"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.html", "*.html"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.js", "*.js"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.c", "*.c"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cpp", "*.cpp"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.txt", "*.txt"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.xml", "*.xml"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cshtml", "*.cshtml"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.xaml", "*.xaml"));
            this.lookIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.resx", "*.resx"));
            this.lookIn.Properties.UseReadOnlyAppearance = false;
            this.lookIn.Size = new System.Drawing.Size(584, 20);
            this.lookIn.StyleController = this.dataLayoutControl1;
            this.lookIn.TabIndex = 8;
            // 
            // SelectFolder
            // 
            this.selectFolderToLook.Location = new System.Drawing.Point(640, 91);
            this.selectFolderToLook.MaximumSize = new System.Drawing.Size(28, 22);
            this.selectFolderToLook.MinimumSize = new System.Drawing.Size(28, 22);
            this.selectFolderToLook.Name = "SelectFolder";
            this.selectFolderToLook.Size = new System.Drawing.Size(28, 22);
            this.selectFolderToLook.StyleController = this.dataLayoutControl1;
            this.selectFolderToLook.TabIndex = 7;
            this.selectFolderToLook.Text = "...";
            this.selectFolderToLook.ToolTip = "Choose Search Folders";
            this.selectFolderToLook.Click += new System.EventHandler(this.SelectFolderToLook_Click);
            // 
            // findWhat
            // 
            this.findWhat.Location = new System.Drawing.Point(84, 43);
            this.findWhat.Name = "findWhat";
            this.findWhat.Size = new System.Drawing.Size(584, 20);
            this.findWhat.StyleController = this.dataLayoutControl1;
            this.findWhat.TabIndex = 4;
            // 
            // lookAt
            // 
            this.lookAt.Location = new System.Drawing.Point(84, 91);
            this.lookAt.Name = "lookAt";
            this.lookAt.Size = new System.Drawing.Size(552, 20);
            this.lookAt.StyleController = this.dataLayoutControl1;
            this.lookAt.TabIndex = 4;
            // 
            // checkAt
            // 
            this.checkAt.Location = new System.Drawing.Point(84, 184);
            this.checkAt.Name = "checkAt";
            this.checkAt.Size = new System.Drawing.Size(552, 20);
            this.checkAt.StyleController = this.dataLayoutControl1;
            this.checkAt.TabIndex = 4;
            // 
            // skipText
            // 
            this.skipText.Location = new System.Drawing.Point(84, 253);
            this.skipText.Name = "skipText";
            this.skipText.Size = new System.Drawing.Size(584, 20);
            this.skipText.StyleController = this.dataLayoutControl1;
            this.skipText.TabIndex = 4;
            // 
            // checkIn
            // 
            this.checkIn.Location = new System.Drawing.Point(84, 160);
            this.checkIn.Name = "checkIn";
            this.checkIn.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Outlook;
            this.checkIn.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.TokenList;
            this.checkIn.Properties.Separators.AddRange(new string[] {
            ","});
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cs", "*.cs"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.ts", "*.ts"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.*", "*.*"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.tmpl.html", "*.tmpl.html"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.html", "*.html"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.js", "*.js"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.c", "*.c"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cpp", "*.cpp"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.txt", "*.txt"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.xml", "*.xml"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.cshtml", "*.cshtml"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.xaml", "*.xaml"));
            this.checkIn.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("*.resx", "*.resx"));
            this.checkIn.Size = new System.Drawing.Size(584, 20);
            this.checkIn.StyleController = this.dataLayoutControl1;
            this.checkIn.TabIndex = 4;
            // 
            // skipBy
            // 
            this.skipBy.Location = new System.Drawing.Point(84, 277);
            this.skipBy.Name = "skipBy";
            this.skipBy.Properties.Columns = 1;
            this.skipBy.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Contains", "Contains", true, "Contains"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("StartWith", "StartWith", true, "StartWith"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Equal", "Equal", true, "Equal")});
            this.skipBy.Size = new System.Drawing.Size(584, 56);
            this.skipBy.StyleController = this.dataLayoutControl1;
            this.skipBy.TabIndex = 4;
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
            this.S,
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
            this.CheckAtControlItem,
            this.SelectFolderToCheckControlItem});
            this.CheckGroup.Location = new System.Drawing.Point(0, 117);
            this.CheckGroup.Name = "CheckGroup";
            this.CheckGroup.Size = new System.Drawing.Size(672, 93);
            this.CheckGroup.Text = "Check in Files";
            // 
            // CheckInContolItem
            // 
            this.CheckInContolItem.Control = this.checkIn;
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
            this.CheckAtControlItem.Control = this.checkAt;
            this.CheckAtControlItem.CustomizationFormText = "Check at";
            this.CheckAtControlItem.Location = new System.Drawing.Point(0, 24);
            this.CheckAtControlItem.Name = "CheckAtControlItem";
            this.CheckAtControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.CheckAtControlItem.Size = new System.Drawing.Size(616, 26);
            this.CheckAtControlItem.Text = "Check at:";
            this.CheckAtControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // IgnoreGroup
            // 
            this.IgnoreGroup.ExpandButtonVisible = true;
            this.IgnoreGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.SkipConditionControlItem,
            this.SkipTextControlItem});
            this.IgnoreGroup.Location = new System.Drawing.Point(0, 210);
            this.IgnoreGroup.Name = "IgnoreGroup";
            this.IgnoreGroup.Size = new System.Drawing.Size(672, 127);
            this.IgnoreGroup.Text = "Find options";
            // 
            // SkipConditionControlItem
            // 
            this.SkipConditionControlItem.Control = this.skipBy;
            this.SkipConditionControlItem.CustomizationFormText = "Skip by";
            this.SkipConditionControlItem.Location = new System.Drawing.Point(0, 24);
            this.SkipConditionControlItem.Name = "SkipConditionControlItem";
            this.SkipConditionControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.SkipConditionControlItem.Size = new System.Drawing.Size(648, 60);
            this.SkipConditionControlItem.Text = "Skip by:";
            this.SkipConditionControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // SkipTextControlItem
            // 
            this.SkipTextControlItem.Control = this.skipText;
            this.SkipTextControlItem.CustomizationFormText = "Skip text";
            this.SkipTextControlItem.Location = new System.Drawing.Point(0, 0);
            this.SkipTextControlItem.Name = "SkipTextControlItem";
            this.SkipTextControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.SkipTextControlItem.Size = new System.Drawing.Size(648, 24);
            this.SkipTextControlItem.Text = "Skip text:";
            this.SkipTextControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // S
            // 
            this.S.AllowHotTrack = false;
            this.S.CustomizationFormText = "emptySpaceItem2";
            this.S.Location = new System.Drawing.Point(0, 337);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(672, 54);
            this.S.Text = "emptySpaceItem2";
            this.S.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SearchGroup
            // 
            this.SearchGroup.CustomizationFormText = "Find in Files";
            this.SearchGroup.ExpandButtonVisible = true;
            this.SearchGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.FindWhatControlItem,
            this.LookAtControlItem,
            this.SelectFolderToLookControlItem,
            this.LookInControlItem});
            this.SearchGroup.Location = new System.Drawing.Point(0, 0);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(672, 117);
            this.SearchGroup.Text = "Find in Files";
            // 
            // FindWhatControlItem
            // 
            this.FindWhatControlItem.Control = this.findWhat;
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
            this.LookAtControlItem.Control = this.lookAt;
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
            this.SelectFolderToLookControlItem.Control = this.selectFolderToLook;
            this.SelectFolderToLookControlItem.Location = new System.Drawing.Point(616, 48);
            this.SelectFolderToLookControlItem.Name = "layoutControlItem3";
            this.SelectFolderToLookControlItem.Size = new System.Drawing.Size(32, 26);
            this.SelectFolderToLookControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.SelectFolderToLookControlItem.TextVisible = false;
            // 
            // LookInControlItem
            // 
            this.LookInControlItem.Control = this.lookIn;
            this.LookInControlItem.Location = new System.Drawing.Point(0, 24);
            this.LookInControlItem.Name = "LookInControlItem";
            this.LookInControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 2, 2, 2);
            this.LookInControlItem.Size = new System.Drawing.Size(648, 24);
            this.LookInControlItem.Text = "Look in";
            this.LookInControlItem.TextSize = new System.Drawing.Size(51, 13);
            // 
            // selectFolderToCheck
            // 
            this.selectFolderToCheck.Location = new System.Drawing.Point(640, 184);
            this.selectFolderToCheck.MaximumSize = new System.Drawing.Size(28, 22);
            this.selectFolderToCheck.MinimumSize = new System.Drawing.Size(28, 22);
            this.selectFolderToCheck.Name = "selectFolderToCheck";
            this.selectFolderToCheck.Size = new System.Drawing.Size(28, 22);
            this.selectFolderToCheck.StyleController = this.dataLayoutControl1;
            this.selectFolderToCheck.TabIndex = 9;
            this.selectFolderToCheck.Text = "...";
            this.selectFolderToCheck.ToolTip = "Choose Search Folders";
            this.selectFolderToCheck.Click += new System.EventHandler(this.SelectFolderToCheck_Click);
            // 
            // SelectFolderToCheckControlItem
            // 
            this.SelectFolderToCheckControlItem.Control = this.selectFolderToCheck;
            this.SelectFolderToCheckControlItem.Location = new System.Drawing.Point(616, 24);
            this.SelectFolderToCheckControlItem.Name = "SelectFolderToCheckControlItem";
            this.SelectFolderToCheckControlItem.Size = new System.Drawing.Size(32, 26);
            this.SelectFolderToCheckControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.SelectFolderToCheckControlItem.TextVisible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.lookIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findWhat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInContolItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAtControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IgnoreGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipConditionControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipTextControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindWhatControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookAtControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFolderToLookControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookInControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFolderToCheckControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit findWhat;
        private System.Windows.Forms.BindingSource settingsModelBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem FindWhatControlItem;
        private DevExpress.XtraEditors.TextEdit lookAt;
        private DevExpress.XtraLayout.LayoutControlItem LookAtControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup SearchGroup;
        private DevExpress.XtraEditors.TextEdit checkAt;
        private DevExpress.XtraLayout.LayoutControlGroup CheckGroup;
        private DevExpress.XtraLayout.LayoutControlGroup IgnoreGroup;
        private DevExpress.XtraEditors.TextEdit skipText;
        private DevExpress.XtraEditors.SimpleButton selectFolderToLook;
        private DevExpress.XtraLayout.LayoutControlItem SelectFolderToLookControlItem;
        private DevExpress.XtraEditors.TokenEdit lookIn;
        private DevExpress.XtraLayout.LayoutControlItem CheckAtControlItem;
        private DevExpress.XtraLayout.LayoutControlItem SkipConditionControlItem;
        private DevExpress.XtraLayout.LayoutControlItem SkipTextControlItem;
        private DevExpress.XtraLayout.LayoutControlItem LookInControlItem;
        private DevExpress.XtraLayout.LayoutControlItem CheckInContolItem;
        private DevExpress.XtraLayout.EmptySpaceItem S;
        private DevExpress.XtraEditors.TokenEdit checkIn;
        private DevExpress.XtraEditors.RadioGroup skipBy;
        private DevExpress.XtraEditors.SimpleButton selectFolderToCheck;
        private DevExpress.XtraLayout.LayoutControlItem SelectFolderToCheckControlItem;
    }
}
