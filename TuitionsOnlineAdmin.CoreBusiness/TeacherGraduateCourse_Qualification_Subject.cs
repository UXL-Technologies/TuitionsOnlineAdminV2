using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherGraduateCourse_Qualification_Subject
    {
        public int TeacherId { get; set; }
        public int GraduateCourseId { get; set; }
        public int SubjectId { get; set; }


        public virtual Subject Subject { get; set; }
        public virtual TeacherGraduateCourse_Qualification TeacherGraduateCourseQualification { get; set; }
    }
}
