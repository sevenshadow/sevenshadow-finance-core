using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenShadow.Finance.Core
{
    public interface IDateValue
    {
        DateTime Date { get; set; }
        decimal Value { get; set; }
    }
}