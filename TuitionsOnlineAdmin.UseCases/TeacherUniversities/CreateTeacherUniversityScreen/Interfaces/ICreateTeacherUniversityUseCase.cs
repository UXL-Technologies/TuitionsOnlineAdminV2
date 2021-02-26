//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: defining the Interface for TeacherUniversity

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
