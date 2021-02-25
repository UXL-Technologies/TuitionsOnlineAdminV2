//Authors: SA, BM, SM,BA ,KK
//Date:25-Feb-2021
//Aim: defining the entity for TeacherPostGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherPostGraduateCourse_Qualification
    {
        //property to store TeacherPostGraduateCourse_QualificationId
        public int TeacherPostGraduateCourse_QualificationId { get; set; }
        //property to store TeacherId
        public int TeacherId { get; set; }
        //property to store PostGraduateId
        public int PostGraduateId { get; set; }
    }
}
