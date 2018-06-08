using System;
using System.Windows.Forms;

namespace ResourceChecker.Controls
{
    public partial class SettingsControl : DevExpress.XtraEditors.XtraUserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            findWhat.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt", true));
            lookIn.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt", true));
            lookAt.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt", true));
            checkIn.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt", true));
            checkAt.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt", true));
            skipText.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt", true));
            skipBy.DataBindings.Add(new Binding("EditValue", settingsModelBindingSource, "SearchAt", true));
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
