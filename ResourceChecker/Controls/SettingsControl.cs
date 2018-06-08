using ResourceChecker.Models;
using System;
using System.Windows.Forms;
using ToolsPortable;

namespace ResourceChecker.Controls
{
    public partial class SettingsControl : DevExpress.XtraEditors.XtraUserControl
    {
        public SettingsModel SettingsModel { get; set; } 
        public SettingsControl()
        {
            InitializeComponent();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            if (SettingsModel == null)
                SettingsModel = new SettingsModel();
            settingsModelBindingSource.Add(SettingsModel);

            findWhat.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchFor.TextRegex", true));
            lookIn.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt.FilesRegex", true));
            lookAt.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt.Folder", true));
            checkIn.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "CheckAt.FilesRegex", true));
            checkAt.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "CheckAt.Folder", true));
            skipText.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "Skip.Text", true));
            skipBy.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "Skip.Condition", true));
        }

        private void SelectFolderToLook_Click(object sender, EventArgs e)
        {
            lookAt.EditValue = SelectPath();
        }

        private string SelectPath()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();

                if (result == DialogResult.OK && fbd.SelectedPath.IsNotBlank())
                {
                    return fbd.SelectedPath;
                }
            }
            return null;
        }

        private void SelectFolderToCheck_Click(object sender, EventArgs e)
        {
            checkAt.EditValue = SelectPath();
        }
    }
}
