//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: Implementing the interface IViewTeacherBasicInformationUseCase



//Author: GJ, TP, VM, SN
//Date: 16/02/2021
//commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.ViewTeacherBasicInformationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.ViewTeacherBasicInformationScreen
{
    public class ViewTeacherBasicInformationUseCase : IViewTeacherBasicInformationUseCase
    {

        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public ViewTeacherBasicInformationUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        public List<TeacherBasicInformation> ViewTeacherBasicInformation(string searchKey)
        {
            var teacherBasicInformationList = instanceOfIUnitOfWork.ViewTeacherBasicInformations(searchKey);
            return teacherBasicInformationList;
        }
    }
}
