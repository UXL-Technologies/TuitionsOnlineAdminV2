//Authors: SA, BM, SM , BA, KK
//Date:23-Feb-2021
//Aim: defining the pluginInterface  Repository  for TeacherPostGraduateCourse_Qualification;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    public interface ITeacherPostGraduateCourse_QualificationRepository
    {
        //Aim : The method is responsible to hold the contract for viewing the teacher Postgraduate course qualification for the incoming teacher id. 
        public List<TeacherPostGraduateCourse_QualificationWithForeignKeys> ViewPostGraduateCourseQualificationRepository(int teacherId);

        //  Aim : The method is responsible to hold the contract for creating the teacher Postgraduate course qualification.
        public string CreateTeacherPostGraduateCourseQualification(int teacherId, int selectedPostGraduateCourses);

        //Aim : The method is responsible to hold the contract for editing the teacher Postgraduate course qualification.
        public string EditTeacherPostGraduateCourseQualification(List<TeacherPostGraduateCourse_QualificationWithForeignKeys> teacherPostGraduateCourseQualifications);

    }
}
