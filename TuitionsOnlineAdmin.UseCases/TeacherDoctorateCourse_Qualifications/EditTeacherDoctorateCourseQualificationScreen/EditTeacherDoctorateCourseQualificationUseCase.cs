//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: defining the class for TeacherDoctorateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.EditTeacherDoctorateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.EditTeacherDoctorateCourseQualificationScreen
{
    //Aim : The EditDoctorateCourseQualification method is responsible to remove the teacher Doctorate course qualifications that are specified in the parameter.
    public class EditTeacherDoctorateCourseQualificationUseCase : IEditTeacherDoctorateCourseQualificationUseCase
    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher Doctorate course qualifications.
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim : To fulfill the contract specified in EditDoctorateCourseQualificationUseCase.
        public EditTeacherDoctorateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }
        public string EditTeacherDoctorateCourseQualification(List<TeacherDoctorateCourse_Qualification> teacherDoctorateCourseQualifications)
        {
            var result = diIUnitOfWork.EditTeacherDoctorateCourseQualification(teacherDoctorateCourseQualifications);
            return result;
        }
    }
}
