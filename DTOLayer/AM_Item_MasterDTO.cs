using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class AM_Item_MasterDTO
    {
        public long Item_ID { get; set; }
        public string Item_Name { get; set; }
        public string Item_Description { get; set; }
        public string UOM { get; set; }
        public int Asset_SubType_ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsConsumable { get; set; }
        public bool IsProvisional { get; set; }
        public bool IsServiciable { get; set; }
        public int ItemCategory_Master_ID { get; set; }
        public long CreatedByID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedByIP { get; set; }
        public Nullable<long> ModifiedByID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedByIP { get; set; }
        public Nullable<int> GoverningBody_ID { get; set; }
        public Nullable<long> Institute_ID { get; set; }
        public bool IsSerialNoRequired { get; set; }
        public Nullable<int> ItemExpiresInDays { get; set; }
        public string SerialNumber_Prefix { get; set; }
        public Nullable<decimal> ResidualValue { get; set; }
        public Nullable<decimal> Depreciation { get; set; }
        public Nullable<int> ParQuantity { get; set; }
    }
}
