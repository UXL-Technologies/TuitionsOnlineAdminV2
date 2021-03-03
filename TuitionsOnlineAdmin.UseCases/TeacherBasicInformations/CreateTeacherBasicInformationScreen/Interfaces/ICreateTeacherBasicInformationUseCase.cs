//Authors: Shravan A, Bhavya MU, Sneha M, Karan Kumar , Bhargavi S Adiga
//Date:15-Jan-2021
//Aim: defining the Interface for TeacherBasicInformationUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.CreateTeacherBasicInformationScreen.Interfaces
{
    //Author: GJ, TP, VM, SN
    //Date: 16/02/2021
    //commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution
    public interface ICreateTeacherBasicInformationUseCase
    {
        string CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation);
    }

}
