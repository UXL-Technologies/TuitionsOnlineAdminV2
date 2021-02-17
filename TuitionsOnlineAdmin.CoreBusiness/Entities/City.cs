using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class City
    {
        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public bool Active { get; set; }
        public int PinCode { get; set; }
    }
}
