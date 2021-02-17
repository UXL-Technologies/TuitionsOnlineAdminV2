//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: Implementing the interface IUpdateTeacherBasicInformationUseCase

//Author: GJ, TP, VM, SN
//Date: 16/02/2021
//commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution
//using System;
//using System.Collections.Generic;
//using System.Text;
//using TuitionsOnlineAdmin.CoreBusiness;
//using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
//using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.UpdateTeacherbasicInformationScreen.Interface;

//namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.UpdateTeacherbasicInformationScreen
//{
//   public class UpdateTeacherBasicInformationUseCase : IUpdateTeacherBasicInformationUseCase
//    {
//        //property dependency injection
//        private readonly IUnitOfWork instanceOfIUnitOfWork;

//        //constructor dependency injection
//        public UpdateTeacherBasicInformationUseCase(IUnitOfWork instanceOfIUnitOfWork)
//        {
//            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

//        }
//        //Calling the method update TeacherBasicInformation in IunitOfwork

//        public string UpdateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
//        {
//            instanceOfIUnitOfWork.UpdateTeacherBasicInformation(teacherBasicInformation);
//            return "done";
//        }
//    }
//}
