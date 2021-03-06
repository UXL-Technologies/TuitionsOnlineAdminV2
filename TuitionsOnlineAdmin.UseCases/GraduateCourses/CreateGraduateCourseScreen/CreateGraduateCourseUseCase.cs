﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the Class for GraduateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen
{
    public class CreateGraduateCourseUseCase : ICreateGraduateCourseUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public CreateGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork) {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create graduate Courses in IunitOfwork
        public string CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            string result = instanceOfIUnitOfWork.CreateGraduateCourse(graduateCourse);
            return result;
                 
           
        }
    }
}
