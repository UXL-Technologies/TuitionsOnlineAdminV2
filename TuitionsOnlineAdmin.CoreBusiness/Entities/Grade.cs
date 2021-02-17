using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class Grade
    {
        public Guid GradeId { get; set; }
        public string GradeName { get; set; }
        public bool Active { get; set; }
    }
}
