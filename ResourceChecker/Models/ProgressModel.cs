using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceChecker.Models
{
   public class ProgressModel
    {
        public int Count { get; set; }
        public int Current { get; set; }
        public string InWork { get; set; }
    }
}
