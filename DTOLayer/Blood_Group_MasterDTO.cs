using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class Blood_Group_MasterDTO
    {
        public int Blood_Group_ID { get; set; }
        public string Blood_Group_Name { get; set; }
        public string Blood_Group_ShortName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public string CreatedByIP { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> ModifedBy { get; set; }
        public string ModifiedByIP { get; set; }
    }
}
