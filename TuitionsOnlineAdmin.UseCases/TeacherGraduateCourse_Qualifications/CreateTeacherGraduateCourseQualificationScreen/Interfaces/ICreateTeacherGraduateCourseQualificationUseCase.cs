﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:22-Feb-2021
//Aim:  Interface for creating Teacher Graduate Course Qualification 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.CreateTeacherGraduateCourseQualificationScreen.Interfaces
{
   public interface ICreateTeacherGraduateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for Creating teacher Graduate Course Qualification. 
        public string CreateTeacherGraduateCourseQualification(int teacherId, int selectedGraduateCourses);
    }
}

