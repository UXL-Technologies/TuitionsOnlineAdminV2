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
    public class CreateTeacherBasicInformationUseCase: ICreateTeacherBasicInformationUseCase
    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        public CreateTeacherBasicInformationUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

     

        public void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
        {
            Console.WriteLine("I have reached create TeacherBasicInformation");
            instanceOfIUnitOfWork.CreateTeacherBasicInformation(teacherBasicInformation);
        }
    }
}
