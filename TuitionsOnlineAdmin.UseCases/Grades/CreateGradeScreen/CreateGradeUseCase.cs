﻿//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Class for GradeUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.Grades.CreateGradeScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.Grades.CreateGradeScreen
{
    public class CreateGradeUseCase : ICreateGradeUseCase
    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        public CreateGradeUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        public void CreateGrade(Grade grade)
        {

            Console.WriteLine("I have reached create grade");
            instanceOfIUnitOfWork.CreateGrade(grade);
        }
    }
}
