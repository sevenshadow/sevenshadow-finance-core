using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenShadow.Finance.Core
{
    public class FinancialStatementSummary : IFinancialStatementSummary     
    {
        #region Statement Information

        public int FiscalYear { get; set; }
        public string Period { get; set; }
        public string FiscalPeriod { get; set; }
        public string FiscalPeriodType { get; set; }
        public int FiscalQuarter { get; set; }
        public DateTime DateAccepted { get; set; }
        public int Decimals { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public string FilingID { get; set; }
        public string ComanyID { get; set; }

        #endregion


        #region Balance Sheet Items

        public decimal CommonSharesOutstanding { get; set; }
        public decimal TotalAssets { get; set; }
        public decimal TotalCurrentAssets { get; set; }
        public decimal TotalNonCurrentAssets { get; set; }
        public decimal TotalCurrentLiabilities { get; set; }
        public decimal TotalNonCurrentLiabilities { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal CommitmentsAndContingencies { get; set; }
        public decimal TotalEquity { get; set; }
        public decimal TotalLiabilitiesAndEquity { get; set; }
        public decimal TotalAssetsAsReported { get; set; }
        public decimal TotalLiabilitesAsReported { get; set; }
        public decimal BookValuePerShare { get; set; }

        #endregion

        #region Income Statement Items

        public decimal NetIncome { get; set; }
        public decimal NetIncomePerShare { get; set; }

        #endregion

        #region Metrics
        public decimal Dividend { get; set; }
        public decimal DividendPerShare { get; set; }
        public decimal BookToPrice { get; set; }
        public decimal PreviousBookValuePerShare { get; set; }
        public decimal EarningsPerPrice { get; set; }

        #endregion

        #region Model Inputs and Outputs


        public decimal RequiredReturn { get; set; }
        public decimal SimpleImpliedGrowthRate { get; set; }
        public decimal NoGrowthValue { get; set; }
        public decimal SpeculationRatio { get; set; }

        public decimal ReturnOnSharePrice { get; set; }
        public decimal FutureReturnOnSharePrice { get; set; }

        #endregion
    }
}