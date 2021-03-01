//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: defining the class for TeacherCertificateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.EditTeacherCertificateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.EditTeacherCertificateCourseQualificationScreen

{ //Aim : The EditCertificateCourseQualification method is responsible to remove the teacher Certificate course qualifications that are specified in the parameter.
    public class EditTeacherCertificateCourseQualificationUseCase : IEditTeacherCertificateCourseQualificationUseCase
    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher Certificate course qualifications.
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim : To fulfill the contract specified in EditCertificateCourseQualificationUseCase.
        public EditTeacherCertificateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
            {
                this.diIUnitOfWork = diIUnitOfWork;
            }

        public string EditTeacherCertificateCourseQualification(List<TeacherCertificateCourse_QualificationWithForeignKeys> teacherCertificateCourseQualifications)
        {
            var result = diIUnitOfWork.EditTeacherCertificateCourseQualification(teacherCertificateCourseQualifications);
            return result;
        }
  
    }
}

