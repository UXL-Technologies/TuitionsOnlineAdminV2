//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim: Interface for creating Teacher High School Board


using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.CreateTeacherHighSchoolBoardScreen.Interfaces
{
  public  interface ICreateTeacherHighSchoolBoardUseCase
    {
        //Aim : The method is responsible to hold the contact for Creating teacher HighSchoolBoard. 
        public string CreateTeacherHighSchoolBoard(int teacherId, int selectedHighSchoolBoards);

    }
}
