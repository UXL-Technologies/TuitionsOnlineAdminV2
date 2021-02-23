//Authors: SA, BM, SM,BA ,KK
//Date:23-Feb-2021
//Aim: defining the class for TeacherPostGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.EditTeacherPostGraduateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.EditTeacherPostGraduateCourseQualificationScreen
{
    //Aim : The EditPostGraduateCourseQualification method is responsible to remove the teacher Postgraduate course qualifications that are specified in the parameter.
    public class EditTeacherPostGraduateCourseQualificationUseCase : IEditTeacherPostGraduateCourseQualificationUseCase
    {

        // Aim: Property dependency injection of IUnitOfWork for creating the teacher Postgraduate course qualifications.
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim : To fulfill the contract specified in EditPostGraduateCourseQualificationUseCase.
        public EditTeacherPostGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
            {
                this.diIUnitOfWork = diIUnitOfWork;
            }
        public string EditTeacherPostGraduateCourseQualification(List<TeacherPostGraduateCourse_Qualification> teacherPostGraduateCourseQualifications)
        {
            var result = diIUnitOfWork.EditTeacherPostGraduateCourseQualification(teacherPostGraduateCourseQualifications);
            return result;
        }
    }
}
