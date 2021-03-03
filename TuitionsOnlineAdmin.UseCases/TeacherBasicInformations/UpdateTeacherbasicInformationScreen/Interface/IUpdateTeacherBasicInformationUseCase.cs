//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
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
