using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteOldFiles
{
    public class Settings
    {
        public string Path { get; set; }
        public List<DeleteMoveRule> Rules { get; set; }
        public int AutoClose { get; set; }
    }

    public class DeleteMoveRule
    {
        public int RunAfterDays { get; set; }
        public bool Delete { get; set; }
        public string SubDirectoryName { get; set; }
    }
}
