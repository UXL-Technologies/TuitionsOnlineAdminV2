//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:22-Feb-2021
//Aim: Interface to edit the Teacher Graduate Course Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.EditGraduateCourseQualification.Interfaces
{
    public interface IEditGraduateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for editing the teacher graduate course qualification.
        public string EditGraduateCourseQualification(List<TeacherGraduateCourse_QualificationWithForeignKeys> teacherGraduateCourseQualifications);
    }
}
