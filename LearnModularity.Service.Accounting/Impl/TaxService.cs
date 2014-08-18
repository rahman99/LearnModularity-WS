using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnModularity.BusinessProcess.Accounting;

namespace LearnModularity.Service.Accounting.Impl
{
    public class TaxService : ITaxService
    {
        private TaxCalculation taxCalculation = new TaxCalculation();

        public int GetTaxBySalary(int salary)
        {
            return taxCalculation.Calculate(salary);
        }
    }
}
