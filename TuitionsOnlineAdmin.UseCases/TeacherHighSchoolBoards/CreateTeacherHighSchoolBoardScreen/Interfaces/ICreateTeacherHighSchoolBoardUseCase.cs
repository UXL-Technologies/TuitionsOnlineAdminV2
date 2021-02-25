//Authors: SA, BM, SM,BA ,KK
//Date:25-Feb-2021
//Aim: defining the Interface for TeacherHighSchoolBoard 


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
