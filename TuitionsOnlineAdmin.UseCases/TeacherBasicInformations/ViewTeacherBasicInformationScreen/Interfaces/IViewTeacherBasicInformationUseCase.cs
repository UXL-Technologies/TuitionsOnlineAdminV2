//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: defining the Interface for view TeacherBasicInformationUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.ViewTeacherBasicInformationScreen.Interfaces
{
    public interface IViewTeacherBasicInformationUseCase
    {
        //Declaring a method to view the TeacherBasicInformation
        List<TeacherBasicInformation> ViewTeacherBasicInformation(string searchKey);
    }
}
