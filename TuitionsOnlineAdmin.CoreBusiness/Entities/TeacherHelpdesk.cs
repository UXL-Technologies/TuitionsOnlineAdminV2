using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class TeacherHelpdesk
    {
        public int TeacherHelpdeskId { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string EmailAddress { get; set; }
        public string RequestDetails { get; set; }
        public DateTime DateTime { get; set; }
        public bool SendGridConfirmation { get; set; }

        public virtual TeacherAuthenticationDetail Teacher { get; set; }
    }
}
