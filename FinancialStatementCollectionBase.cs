using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenShadow.Finance.Core
{
    public class FinancialStatementCollectionBase : IFinancialStatementCollection
    {
        public IList<IFinancialStatement> Statements { get; set; }
    }
}