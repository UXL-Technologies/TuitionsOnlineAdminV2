using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherPostGraduateCourse_Qualification
    {
        public int TeacherPostGraduateCourse_QualificationId { get; set; }
        public int TeacherId { get; set; }
        public int PostGraduateId { get; set; }
    }
}
