//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: defining the entity for TeacherGraduateCourse_QualificationWithForeignKeys 


using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherGraduateCourse_QualificationWithForeignKeys : TeacherGraduateCourse_Qualification
    {
        //property to store TeacherName
        public string TeacherName { get; set; }
        //property to store GraduateCourseName
        public string GraduateCourseName { get; set; }
    }
}
