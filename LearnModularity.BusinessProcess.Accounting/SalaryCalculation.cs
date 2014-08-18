using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnModularity.BusinessProcess.Accounting
{
    public class SalaryCalculation
    {
        public int Calculate(int age)
        {
            if (age < 30)
                return 7;
            else
                return 10;
        }
    }
}
