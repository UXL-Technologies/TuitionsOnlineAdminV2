using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualification.ViewTeacherGraduateCourseQualificationScreen.Interfaces
{
  public  interface IViewTeacherGraduateCourseQualificationUseCase
    {
        public List<TeacherGraduateCourseQualification> ViewTeacherGraduateCourseQualification(int teacherId);
    }
}
