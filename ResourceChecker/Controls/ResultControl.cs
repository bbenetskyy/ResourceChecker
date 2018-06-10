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
using ResourceChecker.Models;

namespace ResourceChecker.Controls
{
    public partial class ResultControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ResultControl()
        {
            InitializeComponent();
        }

        public void LoadResults(List<ResultModel> resultModels, bool clear = true)
        {
            if (clear) resultModelBindingSource.Clear();
            resultModels.ForEach(model =>
                resultModelBindingSource.Add(model));
        }
    }
}
