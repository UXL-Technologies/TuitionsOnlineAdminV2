//Authors: Shravan A, Bhavya MU, Sneha M, Karan Kumar , Bhargavi S Adiga
//Date:26-Feb-2021
//Aim:  Interface for creating Teacher University
using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.UseCases.TeacherUniversities.CreateTeacherUniversityScreen.Interfaces
{
   public interface ICreateTeacherUniversityUseCase
    {
        //Aim : The method is responsible to hold the contact for Creating teacher University. 
        public string CreateTeacherUniversity(int teacherId, int selectedUniversities);
    }
}
