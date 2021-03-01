//Authors: SA, BM, SM , BA, KK
//Date:22-Feb-2021
//Aim: defining the pluginInterface  Repository  for TeacherGraduateCourse_Qualification;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ITeacherGraduateCourse_QualificationRepository
    {
        //Aim : The method is responsible to hold the contract for viewing the teacher graduate course qualification for the incoming teacher id. 
        public List<TeacherGraduateCourse_QualificationWithForeignKeys> ViewGraduateCourseQualificationRepository(int teacherId);

      //  Aim : The method is responsible to hold the contract for creating the teacher graduate course qualification.
        public string CreateTeacherGraduateCourseQualification(int teacherId, int selectedGraduateCourses);

        //Aim : The method is responsible to hold the contract for editing the teacher graduate course qualification.
        public string EditGraduateCourseQualification(List<TeacherGraduateCourse_QualificationWithForeignKeys> teacherGraduateCourseQualifications);

    }
}
