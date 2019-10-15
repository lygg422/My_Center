using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MS_Service.Business;
using MSModels;
using System.Web.Services;

namespace MS_Service
{
    /// <summary>
    /// WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private WritingBiz writingBiz = new WritingBiz();
        [WebMethod]
        public void AddDariy(EidtDariyVModel Vdariy)
        {
             //writingBiz.AddDariy(Vdariy);
        }
    }
}
