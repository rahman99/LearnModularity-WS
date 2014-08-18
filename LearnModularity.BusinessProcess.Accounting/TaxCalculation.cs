using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnModularity.BusinessProcess.Accounting
{
    public class TaxCalculation
    {
        public int Calculate(int salary)
        {
            if (salary <= 7)
                return 2;

            else
                return 3;
        }
    }
}
