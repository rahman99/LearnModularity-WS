using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnModularity.UI.Acounting
{
    public class TaxUI
    {
        public void ShowTax(string name, int tax)
        {
            Console.WriteLine("Tax of " + name + " is : Rp." + tax);
        }
    }
}
