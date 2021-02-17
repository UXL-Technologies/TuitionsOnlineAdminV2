using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class Subject
    {
        public Subject()
        {
            TeacherCertificateCourseQualificationSubjects = new HashSet<TeacherCertificateCourseQualificationSubject>();
            TeacherDoctorateCourseQualificationSubjects = new HashSet<TeacherDoctorateCourseQualificationSubject>();
            TeacherGraduateCourseQualificationSubjects = new HashSet<TeacherGraduateCourseQualificationSubject>();
            TeacherPostGraduateCourseQualificationSubjects = new HashSet<TeacherPostGraduateCourseQualificationSubject>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TeacherCertificateCourseQualificationSubject> TeacherCertificateCourseQualificationSubjects { get; set; }
        public virtual ICollection<TeacherDoctorateCourseQualificationSubject> TeacherDoctorateCourseQualificationSubjects { get; set; }
        public virtual ICollection<TeacherGraduateCourseQualificationSubject> TeacherGraduateCourseQualificationSubjects { get; set; }
        public virtual ICollection<TeacherPostGraduateCourseQualificationSubject> TeacherPostGraduateCourseQualificationSubjects { get; set; }
    }
}
