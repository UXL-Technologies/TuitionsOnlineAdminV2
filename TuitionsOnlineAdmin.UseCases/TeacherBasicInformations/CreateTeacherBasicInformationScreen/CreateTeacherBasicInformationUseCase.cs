//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Class for TeacherBasicInformation ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.CreateTeacherBasicInformationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.CreateTeacherBasicInformationScreen
{
    //Author: GJ, TP, VM, SN
    //Date: 16/02/2021
    //commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution
    /*
    public class CreateTeacherBasicInformationUseCase: ICreateTeacherBasicInformationUseCase
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateTeacherBasicInformationUseCase(IUnitOfWork unitOfWork)

        {
            this.unitOfWork = unitOfWork;
        }


    public void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
    {
        Console.WriteLine("I have reached create TeacherBasicInformation");
        unitOfWork.CreateTeacherBasicInformation(teacherBasicInformation);
    }
}*/
}
