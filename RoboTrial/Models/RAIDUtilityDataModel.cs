using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RoboTrial.Models
{
    public enum RAIDUtilityVirtualDriveOptions
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

    public enum RADIUtilityControllerOptions
    {
        AutoBootSelect,
        HBA,
        SecurityKey,
        StopOnError        
    }
    [Flags]
    enum RAIDLevels     //consider also creating a RAID rules class higher up.
    {
        RAID0 = 0,
        RAID1 = 1,
        RAID5 = 5,
        RAID6 = 6,
        RAID10 = 10,
        RAID50 = 50,
        RAID60 = 60
    }

    public class Chassis
    {
        // does this need to map to supported controllers?
        // drive count
        // flexbay position

    }

    public class RAIDController
    {

        [Key]
        public int RAIDControllerID { get; set; }
        public string Name { get; set; }
        
        public virtual RAIDUtility RAIDUtility { get; set; }

        public int MaxNumberVirtualDisks { get; set; }
        public RAIDLevels trial { get; set; }
        //public virtual ICollection<RAIDLevels> wtf  { get; set; }
        //RAID types supported
        //Cache Function

    }


    public class RAIDUtility
    {
        [Key]
        public int RAIDUtilityID { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }  // "/cx set  "
        [Key]
        public int ControllerCommandID { get; set; }
        public virtual VirtualDriveCommand VDCommand { get; set; }

        public virtual ICollection<ControllerCommand> CtrlCommands { get; set; }
    }

    public class ControllerCommand
    {
        [Key]
        public int ControllerCommandID { get; set; }
        public string SyntaxString { get; set; }  //Could be multiple strings assoc w/ object
    }

    public class VirtualDriveCommand
    {
        [Key]
        public int VirtualDriveCommandID { get; set; }
        public string SyntaxString { get; set; }
        

    }


}