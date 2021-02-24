using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
  public  class TeacherDoctorateCourse_Qualification
    {
        public int TeacherDoctorateCourse_QualificationId { get; set; }
        public int TeacherId { get; set; }
        public int DoctorateCourseId { get; set; }
    }
}
