using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.ViewTeacherGraduateCourseQualificationScreen.Interfaces
{
  public  interface IViewTeacherGraduateCourseQualificationUseCase
    {
        public List<TeacherGraduateCourse_Qualification> ViewTeacherGraduateCourseQualification(int teacherId);
      
    }
}
