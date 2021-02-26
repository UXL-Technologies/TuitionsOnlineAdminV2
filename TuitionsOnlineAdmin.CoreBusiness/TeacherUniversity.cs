//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: defining the entity for TeacherUniversity 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherUniversity
    {
        //property to store TeacherUniversityId
        public int TeacherUniversityId { get; set; }
        //property to store TeacherId
        public int TeacherId { get; set; }
        //property to store UniversityId
        public int UniversityId { get; set; }
    }
}
