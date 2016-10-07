using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Finance.Core
{
    public interface ICompany
    {
        string Name { get; set; }
        string Ticker { get; set; }
        string Address { get; set; }
        string BusinessSummary { get; set; }
        Uri[] CompanyWebsites { get; set; }
        string CorporateGovernance { get; set; }
        string ExternalId { get; set; }
        string CIK { get; set; }
        string SIC { get; set; }
        string SICDescription { get; set; }
        string SICGroup { get; set; }
        string Sector { get; set; }
        string CompanyType { get; set; }
        string Taxonomy { get; set; }

    }
}
