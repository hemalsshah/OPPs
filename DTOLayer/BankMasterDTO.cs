using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class BankMasterDTO
    {
        public int BankID { get; set; }
        public string BankName { get; set; }
        public Nullable<System.DateTime> Entered_On { get; set; }
        public Nullable<long> Entered_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public Nullable<long> Modified_By { get; set; }
    }
}
