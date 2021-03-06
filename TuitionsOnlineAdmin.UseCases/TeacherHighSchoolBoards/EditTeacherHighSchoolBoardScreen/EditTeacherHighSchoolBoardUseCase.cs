﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim:  class to implement edit  Teacher High School Board

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.EditTeacherHighSchoolBoardScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.EditTeacherHighSchoolBoardScreen
{
    //Aim : The EditHighSchoolBoard method is responsible to remove the teacher HighSchoolBoards that are specified in the parameter.
    public class EditTeacherHighSchoolBoardUseCase: IEditTeacherHighSchoolBoardUseCase
    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher HighSchoolBoards.
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim : To fulfill the contract specified in EditHighSchoolBoardUseCase.
        public EditTeacherHighSchoolBoardUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }
        public string EditTeacherHighSchoolBoard(List<TeacherHighSchoolBoardWithForeignKeys> teacherHighSchoolBoards)
        {
            var result = diIUnitOfWork.EditTeacherHighSchoolBoard(teacherHighSchoolBoards);
            return result;
        }

    }
}
