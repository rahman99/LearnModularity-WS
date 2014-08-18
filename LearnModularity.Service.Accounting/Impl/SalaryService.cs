using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnModularity.BusinessProcess.Accounting;

namespace LearnModularity.Service.Accounting.Impl
{
    public class SalaryService : ISalaryService
    {
        private SalaryCalculation salaryCalculation = new SalaryCalculation();

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
