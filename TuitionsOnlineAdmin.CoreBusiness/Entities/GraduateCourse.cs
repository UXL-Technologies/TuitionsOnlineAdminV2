using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class GraduateCourse
    {
        public GraduateCourse()
        {
            TeacherGraduateCourseQualifications = new HashSet<TeacherGraduateCourseQualification>();
        }

        public int GraduateCourseId { get; set; }
        public string GraduateCourseName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TeacherGraduateCourseQualification> TeacherGraduateCourseQualifications { get; set; }
    }
}
