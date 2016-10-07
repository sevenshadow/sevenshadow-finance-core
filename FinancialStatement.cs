using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenShadow.Finance.Core
{
    public class FinancialStatement : IFinancialStatement
    {
        public ICompany Company { get; set; }
        public IBalanceSheet BalanceSheet { get; set; }
        public IIncomeStatement IncomeStatement { get; set; }

    }
}