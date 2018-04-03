using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using DTOLayer;
namespace TestWebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DalBase<BankMasterDTO> objDAL = new DalBase<BankMasterDTO>();
            BankMasterDTO bnk = new BankMasterDTO();
            objDAL.Add(bnk);
        }
        protected void Page_Init(object sender, EventArgs e)
        {
        }
    }
}