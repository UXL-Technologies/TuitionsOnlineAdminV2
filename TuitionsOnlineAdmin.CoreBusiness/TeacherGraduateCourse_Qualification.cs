﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:22-Feb-2021
//Aim: defining the entity for TeacherGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class TeacherGraduateCourse_Qualification
    {
        //property to store TeacherGraduateCourse_QualificationId
        public int TeacherGraduateCourse_QualificationId { get; set; }
        //property to store TeacherId
        public int TeacherId { get; set; }
        //property to store GraduateCourseId
        public int GraduateCourseId { get; set; }
    }
}
