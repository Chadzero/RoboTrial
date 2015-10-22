using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoboTrial.Models
{
    public class RAIDUtility
    {
        public int RAIDUtilityID { get; set; }
        public string Name { get; set; }
        public List<RAIDCommand> VDCommand { get; set; }
        public List<RAIDCommand> CtrlCommand { get; set; }
        public List<int> VDCommandID { get; set; }
        public List<int> CtrlCommandID { get; set; }

        public class RAIDCommand
        {
            public int numberthing { get; set; }

        }
    }
}