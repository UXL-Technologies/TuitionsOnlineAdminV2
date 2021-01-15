//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: defining the Interface for view GradeUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Grades.ViewGradeScreen.Interfaces
{
   public interface IViewGradeUseCase
    {
        //Declaring a method to view the Grade
        List<Grade> ViewGrade(string searchKey);
    }
}
