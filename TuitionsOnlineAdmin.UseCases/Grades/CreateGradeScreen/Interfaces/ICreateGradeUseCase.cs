//Authors: SA, BM, SM
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
        void CreateGrade(Grade grade);
    }
}
