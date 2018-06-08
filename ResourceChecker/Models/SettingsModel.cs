using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceChecker.Models
{
    public class SettingsModel
    {
        public CheckAtModel SearchAt { get; set; } = new CheckAtModel();
        public CheckForModel SearchFor { get; set; } = new CheckForModel();
        public CheckAtModel CheckAt { get; set; } = new CheckAtModel();
        public SkipModel Skip { get; set; } = new SkipModel();
    }
}
