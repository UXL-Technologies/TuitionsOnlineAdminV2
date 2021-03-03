//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim:  class to implement  View Teacher High School Board  

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.ViewTeacherHighSchoolBoardScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.ViewTeacherHighSchoolBoardScreen
{
   public class ViewTeacherHighSchoolBoardUseCase : IViewTeacherHighSchoolBoardUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork diIUnitOfWork;
        //Aim: Constructor dependency injection of IUnitOfWork for viewing the teacher HighSchoolBoard .
        public ViewTeacherHighSchoolBoardUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        // Aim : The ViewTeacherHighSchoolBoardUseCase method is responsible to get the teacher HighSchoolBoard record if exists else provide an empty container of teacher HighSchoolBoard 

        public List<TeacherHighSchoolBoardWithForeignKeys> ViewTeacherHighSchoolBoard(int teacherId)
        {
            var teacherHighSchoolBoardList = diIUnitOfWork.ViewTeacherHighSchoolBoard(teacherId);
            Console.WriteLine(teacherHighSchoolBoardList);
            return teacherHighSchoolBoardList;
        }
    }
}
 