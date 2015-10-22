using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoboTrial.Models
{
    public class RAIDUtility
    {
        [Key]
        public int RAIDUtilityID { get; set; }
        public string Name { get; set; }
        public virtual RAIDCommand VDCommand { get; set; }
        public virtual ICollection<RAIDCommand> CtrlCommand { get; set; }

        public class RAIDCommand
        {
            [Key]
            public int RAIDCommandID { get; set; }
            public string CommandName { get; set; }
            public string SyntaxString { get; set; }
        }
    }
}