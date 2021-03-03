//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:18-Jan-2021
//Aim: Implementing the interface IViewTeacherBasicInformationUseCase

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.ViewTeacherBasicInformationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.ViewTeacherBasicInformationScreen
{
  public  class ViewTeacherBasicInformationUseCase: IViewTeacherBasicInformationUseCase
    {

        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public ViewTeacherBasicInformationUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        public List<TeacherBasicInformation> ViewTeacherBasicInformationList(string searchKey)
        {
            Console.WriteLine(searchKey);
            var teacherBasicInformationList = instanceOfIUnitOfWork.ViewTeacherBasicInformation(searchKey);
            return teacherBasicInformationList;
        }
    }
}
