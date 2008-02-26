using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using PromoBusiness;

namespace PGAP
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PGService : System.Web.Services.WebService
    {
        private BusinessLogic myLogic = new BusinessLogic("C:\\Users\\Matt\\Documents\\Codebase\\C#\\PromoGuruSystem\\PromoGuru\\PromoGuru.mdb");
        public PGService()
        {
            myLogic.LoadBusinessData();
        }

        [WebMethod]
        public string GetProducts()
        {
            return myLogic.SerializeProducts();
        }
    }
}
