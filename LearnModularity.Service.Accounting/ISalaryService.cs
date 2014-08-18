using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnModularity.Service.Accounting
{
    public interface ISalaryService
    {
        int GetSalaryByName(string name);
    }
}
