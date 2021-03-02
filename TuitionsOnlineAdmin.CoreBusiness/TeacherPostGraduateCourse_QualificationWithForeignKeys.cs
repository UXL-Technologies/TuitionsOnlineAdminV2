//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:26-Feb-2021
//Aim: defining the entity for TeacherPostGraduateCourse_QualificationWithForeignKeys 


using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherPostGraduateCourse_QualificationWithForeignKeys : TeacherPostGraduateCourse_Qualification
    {
        //property to store TeacherName
        public string TeacherName { get; set; }
        //property to store PostGraduateCourseName
        public string PostGraduateCourseName { get; set; }
    }
}
