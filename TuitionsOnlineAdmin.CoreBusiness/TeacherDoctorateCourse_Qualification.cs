//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim: defining the entity for TeacherDoctorateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
  public  class TeacherDoctorateCourse_Qualification
    {
        //property to store TeacherDoctorateCourse_QualificationId
        public int TeacherDoctorateCourse_QualificationId { get; set; }
        //property to store TeacherId
        public int TeacherId { get; set; }
        //property to store DoctorateCourseId
        public int DoctorateCourseId { get; set; }
    }
}
