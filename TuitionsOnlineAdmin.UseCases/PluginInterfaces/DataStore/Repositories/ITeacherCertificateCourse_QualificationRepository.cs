//Authors: SA, BM, SM , BA, KK
//Date:24-Feb-2021
//Aim: defining the pluginInterface  Repository  for TeacherCertificateCourse_Qualification;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    public interface ITeacherCertificateCourse_QualificationRepository
    {
        //Aim : The method is responsible to hold the contract for viewing the teacher Certificate course qualification for the incoming teacher id. 
        public List<TeacherCertificateCourse_QualificationWithForeignKeys> ViewCertificateCourseQualificationRepository(int teacherId);

        //  Aim : The method is responsible to hold the contract for creating the teacher Certificate course qualification.
        public string CreateTeacherCertificateCourseQualification(int teacherId, int selectedCertificateCourses);


        //Aim : The method is responsible to hold the contract for editing the teacher Certificate course qualification.
        public string EditTeacherCertificateCourseQualification(List<TeacherCertificateCourse_QualificationWithForeignKeys> teacherCertificateCourseQualifications);
    }
}
