﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Finance.Core
{
    public interface IFinancialStatement
    {
        ICompany Company { get; set; }
        IBalanceSheet BalanceSheet { get; set; }
        IIncomeStatement IncomeStatement { get; set; }
   
    }
}
