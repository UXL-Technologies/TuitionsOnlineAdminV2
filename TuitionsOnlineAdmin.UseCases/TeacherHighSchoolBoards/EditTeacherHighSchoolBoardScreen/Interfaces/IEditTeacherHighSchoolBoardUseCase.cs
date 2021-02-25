//Authors: SA, BM, SM,BA ,KK
//Date:25-Feb-2021
//Aim: defining the Interface for TeacherHighSchoolBoard


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.EditTeacherHighSchoolBoardScreen.Interfaces
{
   public interface IEditTeacherHighSchoolBoardUseCase
    {
        //Aim : The method is responsible to hold the contact for editing the teacher HighSchoolBoard.
        public string EditTeacherHighSchoolBoard(List<TeacherHighSchoolBoard> teacherHighSchoolBoards);

    }
}
