//Authors: SA, BM, SM,BA ,KK
//Date:22-Feb-2021
//Aim: defining the class for TeacherGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.EditGraduateCourseQualification.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.EditGraduateCourseQualification
{
    //Aim : The EditGraduateCourseQualification method is responsible to remove the teacher graduate course qualifications that are specified in the parameter.
   public class EditGraduateCourseQualificationUseCase : IEditGraduateCourseQualificationUseCase
    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher graduate course qualifications.
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim : To fulfill the contract specified in EditGraduateCourseQualificationUseCase.
        public EditGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)

        {
            this.diIUnitOfWork = diIUnitOfWork;
        }
        public string EditGraduateCourseQualification(List<TeacherGraduateCourse_Qualification> teacherGraduateCourseQualifications)
        {
            Console.WriteLine(teacherGraduateCourseQualifications);
            var result = diIUnitOfWork.EditGraduateCourseQualification(teacherGraduateCourseQualifications);
            return result;
        }
    }
}
