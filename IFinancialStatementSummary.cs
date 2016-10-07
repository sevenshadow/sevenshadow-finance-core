using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Finance.Core
{
    public interface IFinancialStatementSummary
    {
        #region Statement Information

        int FiscalYear { get; set; }
        string Period { get; set; }
        string FiscalPeriod { get; set; }
        string FiscalPeriodType { get; set; }
        int FiscalQuarter { get; set; }
        DateTime DateAccepted { get; set; }
        int Decimals { get; set; }
        DateTime StartPeriod { get; set; }
        DateTime EndPeriod { get; set; }
        string FilingID { get; set; }
        string ComanyID { get; set; }
        
        #endregion


        #region Balance Sheet Items

        decimal CommonSharesOutstanding { get; set; }
        decimal TotalAssets { get; set; }
        decimal TotalCurrentAssets { get; set; }
        decimal TotalNonCurrentAssets { get; set; }
        decimal TotalCurrentLiabilities { get; set; }
        decimal TotalNonCurrentLiabilities { get; set; }
        decimal TotalLiabilities { get; set; }
        decimal CommitmentsAndContingencies { get; set; }
        decimal TotalEquity { get; set; }
        decimal TotalLiabilitiesAndEquity { get; set; }
        decimal TotalAssetsAsReported { get; set; }
        decimal TotalLiabilitesAsReported { get; set; }
        decimal BookValuePerShare { get; set; }

        #endregion

        #region Income Statement Items

        decimal NetIncome { get; set; }
        decimal NetIncomePerShare { get; set; }

        #endregion

        #region Metrics

        decimal BookToPrice { get; set; }
        decimal PreviousBookValuePerShare { get; set; }
        decimal EarningsPerPrice { get; set; }

        #endregion

        #region Model Inputs and Outputs

        decimal Dividend { get; set; }
        decimal DividendPerShare { get; set; }

        decimal RequiredReturn { get; set; }
        decimal SimpleImpliedGrowthRate { get; set; }
        decimal NoGrowthValue { get; set; }
        decimal SpeculationRatio { get; set; }

        decimal ReturnOnSharePrice { get; set; }
        decimal FutureReturnOnSharePrice { get; set; }

        #endregion

        

       
    }
}
