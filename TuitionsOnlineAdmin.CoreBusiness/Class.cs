using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class Class
    {
        public Guid ClassId { get; set; }
        public string ClassName { get; set; }
        public bool Active { get; set; } = true;
    }
}
