//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: defining the class for ViewTeacherUniversity

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.ViewTeacherUniversityScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherUniversities.ViewTeacherUniversityScreen
{
   public class ViewTeacherUniversityUseCase : IViewTeacherUniversityUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork diIUnitOfWork;
        //Aim: Constructor dependency injection of IUnitOfWork for viewing the teacher University .
        public ViewTeacherUniversityUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        // Aim : The ViewTeacherUniversityUseCase method is responsible to get the teacher University record if exists else provide an empty container of teacher University 

        public List<TeacherUniversityWithForeignKeys> ViewTeacherUniversity(int teacherId)
        {
            var teacherUniversityList = diIUnitOfWork.ViewTeacherUniversity(teacherId);
            Console.WriteLine(teacherUniversityList);
            return teacherUniversityList;
        }
    }
}
