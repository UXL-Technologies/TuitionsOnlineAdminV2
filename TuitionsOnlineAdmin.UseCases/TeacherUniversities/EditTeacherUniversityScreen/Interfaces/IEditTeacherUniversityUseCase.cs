//Authors: Shravan A, Bhavya MU, Sneha M, Karan Kumar , Bhargavi S Adiga
//Date:26-Feb-2021
//Aim:  Interface for editing Teacher University
using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherUniversities.EditTeacherUniversityScreen.Interfaces
{
   public interface IEditTeacherUniversityUseCase
    {
        //Aim : The method is responsible to hold the contact for editing the Teacher University.
        public string EditTeacherUniversity(List<TeacherUniversityWithForeignKeys> teacherUniversities);
    }
}
