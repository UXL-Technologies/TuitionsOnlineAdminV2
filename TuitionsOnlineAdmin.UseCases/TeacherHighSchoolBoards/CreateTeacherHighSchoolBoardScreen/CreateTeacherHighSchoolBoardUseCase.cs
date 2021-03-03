//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim:  Interface for creating Teacher High School Board


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.CreateTeacherHighSchoolBoardScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.CreateTeacherHighSchoolBoardScreen
{
   public class CreateTeacherHighSchoolBoardUseCase: ICreateTeacherHighSchoolBoardUseCase
    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher 

        private readonly IUnitOfWork diIUnitOfWork;

        // Aim: Constructor dependency injection of IUnitOfWork for creating the teacher HighSchoolBoard
        public CreateTeacherHighSchoolBoardUseCase(IUnitOfWork diIUnitOfWork)

        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        //Aim : The CreateHighSchoolBoardUseCase method is responsible to create the teacher HighSchoolBoard.
        public string CreateTeacherHighSchoolBoard(int teacherId, int selectedHighSchoolBoards)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedHighSchoolBoards);
            var result = diIUnitOfWork.CreateTeacherHighSchoolBoard(teacherId, selectedHighSchoolBoards);
            return result;
        }
    }
}
