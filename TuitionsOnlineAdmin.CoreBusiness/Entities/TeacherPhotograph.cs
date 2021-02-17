using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class TeacherPhotograph
    {
        public int TeacherPhotographId { get; set; }
        public int TeacherId { get; set; }
        public string PhotographUrl { get; set; }

        public virtual TeacherAuthenticationDetail Teacher { get; set; }
    }
}
