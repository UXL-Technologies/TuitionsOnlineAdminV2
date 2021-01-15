//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: Implementing the interface IviewSubjectUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Subjects.ViewSubjectScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.Subjects.ViewSubjectScreen
{
    public class ViewSubjectUseCase : IViewSubjectUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public ViewSubjectUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        public List<Subject> ViewSubject(string searchKey)
        {
            var subjectList = instanceOfIUnitOfWork.ViewSubjects(searchKey);
            return subjectList;
        }
    }
}
