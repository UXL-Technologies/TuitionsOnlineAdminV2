//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:22-Feb-2021
//Aim: defining the entity for TeacherDoctorateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherDoctorateCourse_QualificationWithForeignKeys : TeacherDoctorateCourse_Qualification
    {
        //property to store TeacherName
        public string TeacherName { get; set; }
        //property to store DoctorateCourseName
        public string DoctorateCourseName { get; set; }
    }
}
