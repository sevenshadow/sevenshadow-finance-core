using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenShadow.Finance.Core
{
    public class CompanyBase : ICompany
    {
        public string Name { get; set; }
        public string Ticker { get; set; }
        public string Address { get; set; }
        public string BusinessSummary { get; set; }
        public Uri[] CompanyWebsites { get; set; }
        public string CorporateGovernance { get; set; }
        public string ExternalId { get; set; }
        public string CIK { get; set; }
        public string SIC { get; set; }
        public string SICDescription { get; set; }
        public string SICGroup { get; set; }
        public string Sector { get; set; }
        public string CompanyType { get; set; }
        public string Taxonomy { get; set; }
    }
}