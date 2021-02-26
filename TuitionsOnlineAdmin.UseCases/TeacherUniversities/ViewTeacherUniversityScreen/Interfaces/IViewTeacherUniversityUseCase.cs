//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: defining the Interface for TeacherUniversity

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherUniversities.ViewTeacherUniversityScreen.Interfaces
{
  public  interface IViewTeacherUniversityUseCase
    {
        //Aim : The method is responsible to hold the contact for viewing the TeacherUniversity
        public List<TeacherUniversityWithForeignKeys> ViewTeacherUniversity(int teacherId);
    
    }
}
