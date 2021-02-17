using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class Currency
    {
        public Guid CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public bool Active { get; set; }
        public bool Default { get; set; }
    }
}
