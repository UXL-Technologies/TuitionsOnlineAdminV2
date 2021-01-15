using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Grades.UpdateGradeScreen.Interface
{
    public interface IUpdateGradeUseCase
    {
        //Declaring a method to update the Grade
        string UpdateGrade(Grade grade);
    }
}
