using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using LearnModularity.BusinessProcess.Accounting;

namespace LearnModularity.WebService.Accounting
{
    /// <summary>
    /// Summary description for SalaryService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SalaryService : System.Web.Services.WebService
    {
        private SalaryCalculation salaryCalculation = new SalaryCalculation();

        [WebMethod]
        public int GetSalaryByName(string name)
        {
            int age = 0;

            if (name == "tutul")
                age = 27;
            else
                age = 32;

            return salaryCalculation.Calculate(age);
        }
    }
}
