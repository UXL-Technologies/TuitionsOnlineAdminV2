//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:22-Feb-2021
//Aim: class responsible to update the Teacher Graduate Course Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.EditGraduateCourseQualification.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.EditGraduateCourseQualification
{
   public class EditGraduateCourseQualificationUseCase : IEditGraduateCourseQualificationUseCase
    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher graduate course qualifications.
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim : To fulfill the contract specified in Edit Graduate Course QualificationUseCase.
        public EditGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)

        {
            this.diIUnitOfWork = diIUnitOfWork;
        }
        //The Edit Graduate Course Qualification method is responsible to remove the teacher graduate course qualifications that are specified in the parameter.
        public string EditGraduateCourseQualification(List<TeacherGraduateCourse_QualificationWithForeignKeys> teacherGraduateCourseQualifications)
        {
            var result = diIUnitOfWork.EditGraduateCourseQualification(teacherGraduateCourseQualifications);
            return result;
        }
    }
}
