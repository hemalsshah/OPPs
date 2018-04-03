using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class Activity_MasterDTO
    {
        public int ACTIVITY_CODE { get; set; }
        public string ACTIVITY_NAME { get; set; }
        public string ACTIVITY_URL { get; set; }
        public int SERVICE_CODE { get; set; }
        public Nullable<bool> IS_MENU { get; set; }
        public bool ISACTIVE { get; set; }
        public System.DateTime CREATEDDATE { get; set; }
        public long CREATEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<long> MODIFIEDBY { get; set; }
        public string IP { get; set; }
        public int DisplayOrder { get; set; }
        public string ACTIVITY_DISPLAY_NAME { get; set; }
        public bool IsMaster { get; set; }
        public bool ShowDependency { get; set; }
    }
}
