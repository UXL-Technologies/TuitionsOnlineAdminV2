//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: defining the entity for TeacherHighSchoolBoardWithForeignKeys 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherHighSchoolBoardWithForeignKeys : TeacherHighSchoolBoard
    {
        //property to store TeacherName
        public string TeacherName { get; set; }
        //property to store HighSchoolBoardName
        public string HighSchoolBoardName { get; set; }
    }
}
