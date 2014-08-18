using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnModularity.UI.Acounting;

namespace LearnModularity.UI.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "tutul";

            int salary = 0;
            int tax = 0;

            //Load data

            //cara project reference
            //ISalaryService salaryService = new SalaryService();
            //ITaxService taxService = new TaxService();

            //salary = salaryService.GetSalaryByName(name);
            //tax = taxService.GetTaxBySalary(salary);




            //cara web service
            SalaryWebService.SalaryService salaryWs = new SalaryWebService.SalaryService();
            salary = salaryWs.GetSalaryByName(name);

            TaxWebService.TaxService taxWs = new TaxWebService.TaxService();
            tax = taxWs.GetTaxBySalary(salary);

            //Show UI
            SalaryUI salaryUI = new SalaryUI();
            TaxUI taxUI = new TaxUI();

            salaryUI.ShowSalary(name, salary);
            taxUI.ShowTax(name, tax);

            Console.ReadKey();
        }
    }
}
