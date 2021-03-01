//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: defining the class for TeacherUniversity

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.EditTeacherUniversityScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherUniversities.EditTeacherUniversityScreen
{
    //Aim : The EditUniversity method is responsible to remove the teacher Universities that are specified in the parameter.
    public class EditTeacherUniversityUseCase : IEditTeacherUniversityUseCase
    {
            // Aim: Property dependency injection of IUnitOfWork for creating the teacher University.
            private readonly IUnitOfWork diIUnitOfWork;

            // Aim : To fulfill the contract specified in EditUniversityUseCase.
            public EditTeacherUniversityUseCase(IUnitOfWork diIUnitOfWork)
            {
                    this.diIUnitOfWork = diIUnitOfWork;
            }
            public string EditTeacherUniversity(List<TeacherUniversityWithForeignKeys> teacherUniversities)
            {
                var result = diIUnitOfWork.EditTeacherUniversity(teacherUniversities);
                return result;
            }
    }
}