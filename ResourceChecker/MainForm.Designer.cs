namespace ResourceChecker
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ResourceChecker.Models.SettingsModel settingsModel2 = new ResourceChecker.Models.SettingsModel();
            ResourceChecker.Models.CheckAtModel checkAtModel3 = new ResourceChecker.Models.CheckAtModel();
            ResourceChecker.Models.CheckAtModel checkAtModel4 = new ResourceChecker.Models.CheckAtModel();
            ResourceChecker.Models.CheckForModel checkForModel2 = new ResourceChecker.Models.CheckForModel();
            ResourceChecker.Models.SkipModel skipModel2 = new ResourceChecker.Models.SkipModel();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.Check = new DevExpress.XtraBars.BarButtonItem();
            this.Settings = new DevExpress.XtraBars.BarButtonItem();
            this.HomePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Main = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.CheckPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.resultControl = new ResourceChecker.Controls.ResultControl();
            this.SettingPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.settingsControl = new ResourceChecker.Controls.SettingsControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.StartCheking = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.CheckPage.SuspendLayout();
            this.SettingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.Check,
            this.Settings,
            this.StartCheking});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 50;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HomePage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(786, 147);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // Check
            // 
            this.Check.Caption = "Check Resources";
            this.Check.Id = 47;
            this.Check.Name = "Check";
            this.Check.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Check_ItemClick);
            // 
            // Settings
            // 
            this.Settings.Caption = "Settings";
            this.Settings.Id = 48;
            this.Settings.Name = "Settings";
            this.Settings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Settings_ItemClick);
            // 
            // HomePage
            // 
            this.HomePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Main});
            this.HomePage.Name = "HomePage";
            this.HomePage.Text = "Home";
            // 
            // Main
            // 
            this.Main.ItemLinks.Add(this.Check);
            this.Main.ItemLinks.Add(this.Settings);
            this.Main.ItemLinks.Add(this.StartCheking);
            this.Main.Name = "Main";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 576);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(786, 23);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.CheckPage);
            this.navigationFrame.Controls.Add(this.SettingPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 147);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.CheckPage,
            this.SettingPage});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = this.SettingPage;
            this.navigationFrame.Size = new System.Drawing.Size(786, 429);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // CheckPage
            // 
            this.CheckPage.Controls.Add(this.resultControl);
            this.CheckPage.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CheckPage.Name = "CheckPage";
            this.CheckPage.Size = new System.Drawing.Size(786, 429);
            // 
            // resultControl
            // 
            this.resultControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultControl.Location = new System.Drawing.Point(0, 0);
            this.resultControl.Name = "resultControl";
            this.resultControl.Size = new System.Drawing.Size(786, 429);
            this.resultControl.TabIndex = 0;
            // 
            // SettingPage
            // 
            this.SettingPage.Controls.Add(this.settingsControl);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Size = new System.Drawing.Size(786, 429);
            // 
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Name = "settingsControl";
            checkAtModel3.FilesRegex = null;
            checkAtModel3.Folder = null;
            settingsModel2.CheckAt = checkAtModel3;
            checkAtModel4.FilesRegex = null;
            checkAtModel4.Folder = null;
            settingsModel2.SearchAt = checkAtModel4;
            checkForModel2.TextRegex = null;
            settingsModel2.SearchFor = checkForModel2;
            skipModel2.Condition = ResourceChecker.Models.Enums.Condition.Contains;
            skipModel2.Text = null;
            settingsModel2.Skip = skipModel2;
            this.settingsControl.SettingsModel = settingsModel2;
            this.settingsControl.Size = new System.Drawing.Size(786, 429);
            this.settingsControl.TabIndex = 1;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // StartCheking
            // 
            this.StartCheking.Caption = "Start Cheking";
            this.StartCheking.Id = 49;
            this.StartCheking.Name = "StartCheking";
            this.StartCheking.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.StartCheking_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 599);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.CheckPage.ResumeLayout(false);
            this.SettingPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Navigation.NavigationPage CheckPage;
        private DevExpress.XtraBars.BarButtonItem Check;
        private DevExpress.XtraBars.BarButtonItem Settings;
        private DevExpress.XtraBars.Ribbon.RibbonPage HomePage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Main;
        private DevExpress.XtraBars.Navigation.NavigationPage SettingPage;
        private Controls.SettingsControl settingsControl;
        private Controls.ResultControl resultControl;
        private DevExpress.XtraBars.BarButtonItem StartCheking;
    }
}