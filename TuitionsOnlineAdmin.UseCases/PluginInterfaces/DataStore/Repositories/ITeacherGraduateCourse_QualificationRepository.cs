using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ITeacherGraduateCourse_QualificationRepository
    {
        //Aim : The method is responsible to hold the contract for viewing the teacher graduate course qualification for the incoming teacher id. 
        public List<TeacherGraduateCourse_Qualification> ViewGraduateCourseQualificationRepository(int teacherId);

      //  Aim : The method is responsible to hold the contract for creating the teacher graduate course qualification.
        public string CreateTeacherGraduateCourseQualification(int teacherId, int selectedGraduateCourses);
    }
}
