//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: defining the Interface for TeacherBasicInformationUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.UpdateTeacherbasicInformationScreen.Interface
{
    public interface IUpdateTeacherBasicInformationUseCase
    {
        //Declaring a method to update the TeacherBasicInformation
        string UpdateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation);
    }
}
