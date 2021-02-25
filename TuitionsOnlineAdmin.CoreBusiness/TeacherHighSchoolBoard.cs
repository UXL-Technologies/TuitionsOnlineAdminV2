//Authors: SA, BM, SM,BA ,KK
//Date:25-Feb-2021
//Aim: defining the entity for TeacherHighSchoolBoard 


using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherHighSchoolBoard
    {
        //property to store TeacherHighSchoolBoardId
        public int TeacherHighSchoolBoardId { get; set; }
        //property to store TeacherId
        public int TeacherId { get; set; }
        //property to store HighSchoolBoardId
        public int HighSchoolBoardId { get; set; }
    }
}
