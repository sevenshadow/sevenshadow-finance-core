using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Finance.Core
{
    public class DateValueBase : IDateValue
    {
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}
