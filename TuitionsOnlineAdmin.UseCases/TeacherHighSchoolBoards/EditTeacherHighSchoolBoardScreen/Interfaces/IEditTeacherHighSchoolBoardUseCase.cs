//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim:  Interface for editing  Teacher High School Board


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.EditTeacherHighSchoolBoardScreen.Interfaces
{
   public interface IEditTeacherHighSchoolBoardUseCase
    {
        //Aim : The method is responsible to hold the contact for editing the teacher HighSchoolBoard.
        public string EditTeacherHighSchoolBoard(List<TeacherHighSchoolBoardWithForeignKeys> teacherHighSchoolBoards);

    }
}
