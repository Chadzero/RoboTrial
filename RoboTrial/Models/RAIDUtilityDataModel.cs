using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RoboTrial.Models
{
    public enum RAIDUtilityVDOptions
    {
        Trial1,
        Trial2
    }
      


    public class RAIDUtility
    {
        [Key]
        public int RAIDUtilityID { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }  // "/cx set  "

        [ForeignKey("VDCommand")]
        public int RAIDCommandID { get; set; }
        public virtual RAIDCommand VDCommand { get; set; }

        public virtual ICollection<RAIDCommand> CtrlCommands { get; set; }

        public class RAIDCommand
        {
            [Key]
            public int RAIDCommandID { get; set; }
            public string CommandName { get; set; }
            public string SyntaxString { get; set; }
        }
    }
}