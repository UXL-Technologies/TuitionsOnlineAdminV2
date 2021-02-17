using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class HighSchoolBoard
    {
        public Guid HighSchoolBoardId { get; set; }
        public string HighSchoolBoardName { get; set; }
        public bool Active { get; set; }
    }
}
