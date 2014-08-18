using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnModularity.Service.Accounting
{
    public interface ITaxService
    {
        int GetTaxBySalary(int salary);
    }
}
