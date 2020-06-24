using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mytest123
{
    public class TaxService
    {
        static public decimal CalculateTax(decimal taxable, string postalCode)
        {
            return taxable * (decimal).1;
        }
    }
}
