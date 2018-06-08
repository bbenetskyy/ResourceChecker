using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceChecker.Models
{
    public class SettingsModel
    {
        public CheckAtModel SearchAt { get; set; }
        public CheckForModel SearchFor { get; set; }
        public CheckAtModel CheckAt { get; set; }
    }
}
