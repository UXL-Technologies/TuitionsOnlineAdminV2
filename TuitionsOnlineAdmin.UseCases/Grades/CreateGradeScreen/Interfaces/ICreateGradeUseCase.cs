//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:12-Jan-2021
//Aim: defining the Interface for GradeUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Grades.CreateGradeScreen.Interfaces
{
   public interface ICreateGradeUseCase
    {
        //Declaring a method to create the Grade
        string CreateGrade(Grade grade);
    }
}
