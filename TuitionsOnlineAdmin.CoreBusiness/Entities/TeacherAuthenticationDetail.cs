using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class TeacherAuthenticationDetail
    {
        public TeacherAuthenticationDetail()
        {
            TeacherHelpdesks = new HashSet<TeacherHelpdesk>();
            TeacherPhotographs = new HashSet<TeacherPhotograph>();
        }

        public int TeacherId { get; set; }
        public string TeacherObjectId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmailAddress { get; set; }

        public virtual TeacherBasicInformation TeacherBasicInformation { get; set; }
        public virtual ICollection<TeacherHelpdesk> TeacherHelpdesks { get; set; }
        public virtual ICollection<TeacherPhotograph> TeacherPhotographs { get; set; }
    }
}
