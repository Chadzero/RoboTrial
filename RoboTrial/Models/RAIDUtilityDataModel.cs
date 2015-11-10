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
        Disks,      //
        HotSpare,
        Name,
        ReadBack,
        Size,
        StripeSize,
        Type,
        VDSNumber,
        WriteThrough
    }

    public enum RADIUtilityCtrlOptions
    {
        AutoBootSelect,
        HBA,
        SecurityKey,
        StopOnError        
    }

    public class RAIDController
    {
        [Key]
        public int RAIDControllerID { get; set; }
        public string Name { get; set; }

        public int RAIDUtilityID { get; set; }
        public virtual RAIDUtility RAIDUtility { get; set; }

        public int MaxNumberVirtualDisks { get; set; }
        
        //RAID types supported
        //Cache Function

    }


    public class RAIDUtility
    {
        [Key]
        public int RAIDUtilityID { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }  // "/cx set  "

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
    
    public class Chassis
    {
        // does this need to map to supported controllers?
        // drive count
        // flexbay position

    }
}