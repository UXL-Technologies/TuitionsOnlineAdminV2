//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim:  Interface for viewing  Teacher  High School Board 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.ViewTeacherHighSchoolBoardScreen.Interfaces
{
   public interface IViewTeacherHighSchoolBoardUseCase
    {
        //Aim : The method is responsible to hold the contact for viewing the TeacherHighSchoolBoard 
        public List<TeacherHighSchoolBoardWithForeignKeys> ViewTeacherHighSchoolBoard(int teacherId);
    }
}
