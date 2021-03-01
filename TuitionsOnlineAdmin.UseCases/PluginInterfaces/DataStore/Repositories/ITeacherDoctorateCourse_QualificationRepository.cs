//Authors: SA, BM, SM , BA, KK
//Date:24-Feb-2021
//Aim: defining the pluginInterface  Repository  for TeacherDoctorateCourse_Qualification;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ITeacherDoctorateCourse_QualificationRepository
    {
        //Aim : The method is responsible to hold the contract for viewing the teacher Doctorate course qualification for the incoming teacher id. 
        public List<TeacherDoctorateCourse_QualificationWithForeignKeys> ViewDoctorateCourseQualificationRepository(int teacherId);

        //  Aim : The method is responsible to hold the contract for creating the teacher Doctorate course qualification.
        public string CreateTeacherDoctorateCourseQualification(int teacherId, int selectedDoctorateCourses);

        //Aim : The method is responsible to hold the contract for editing the teacher Doctorate course qualification.
        public string EditTeacherDoctorateCourseQualification(List<TeacherDoctorateCourse_QualificationWithForeignKeys> teacherDoctorateCourseQualifications);
    }
}
