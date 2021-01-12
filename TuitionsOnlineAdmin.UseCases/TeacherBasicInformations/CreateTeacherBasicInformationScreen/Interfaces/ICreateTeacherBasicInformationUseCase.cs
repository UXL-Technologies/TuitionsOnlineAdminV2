//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Interface for TeacherBasicInformation ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.CreateTeacherBasicInformationScreen.Interfaces
{
   public interface ICreateTeacherBasicInformationUseCase
    {
        void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformationity);
    }
}
