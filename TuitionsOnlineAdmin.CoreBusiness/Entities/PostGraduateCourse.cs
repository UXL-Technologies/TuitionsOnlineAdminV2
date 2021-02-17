using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class PostGraduateCourse
    {
        public PostGraduateCourse()
        {
            TeacherPostGraduateCourseQualifications = new HashSet<TeacherPostGraduateCourseQualification>();
        }

        public int PostGraduateCourseId { get; set; }
        public string PostGraduateCourseName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TeacherPostGraduateCourseQualification> TeacherPostGraduateCourseQualifications { get; set; }
    }
}
