using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class TeacherPostGraduateCourseQualification
    {
        public TeacherPostGraduateCourseQualification()
        {
            TeacherPostGraduateCourseQualificationSubjects = new HashSet<TeacherPostGraduateCourseQualificationSubject>();
        }

        public int TeacherPostGraduateCourseQualificationId { get; set; }
        public int TeacherId { get; set; }
        public int PostGraduateId { get; set; }

        public virtual PostGraduateCourse PostGraduate { get; set; }
        public virtual TeacherBasicInformation Teacher { get; set; }
        public virtual ICollection<TeacherPostGraduateCourseQualificationSubject> TeacherPostGraduateCourseQualificationSubjects { get; set; }
    }
}
