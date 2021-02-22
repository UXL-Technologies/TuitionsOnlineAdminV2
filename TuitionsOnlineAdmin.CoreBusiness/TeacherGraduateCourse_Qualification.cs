using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class TeacherGraduateCourse_Qualification
    {
        public int TeacherGraduateCourse_QualificationId { get; set; }
        public int TeacherId { get; set; }
        public int GraduateCourseId { get; set; }
    }
}
