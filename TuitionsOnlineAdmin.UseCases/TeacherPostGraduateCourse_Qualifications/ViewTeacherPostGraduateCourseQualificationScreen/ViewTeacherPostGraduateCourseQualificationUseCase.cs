﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:23-Feb-2021
//Aim: class to implement view Teacher PostGraduate Course Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.ViewTeacherPostGraduateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.ViewTeacherPostGraduateCourseQualificationScreen
{
   public class ViewTeacherPostGraduateCourseQualificationUseCase : IViewTeacherPostGraduateCourseQualificationUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork diIUnitOfWork;
        //Aim: Constructor dependency injection of IUnitOfWork for viewing the teacher Postgraduate course qualifications.
        public ViewTeacherPostGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        // Aim : The ViewPostGraduateCourseUseCase method is responsible to get the teacher Postgraduate course qualification record if exists else provide an empty container of teacher Postgraduate course qualification.
 
      public  List<TeacherPostGraduateCourse_QualificationWithForeignKeys> ViewTeacherPostGraduateCourseQualification(int teacherId)
        {
            var teacherPostGraduateCourseQualificationList = diIUnitOfWork.ViewTeacherPostGraduateCourseQualification(teacherId);
            Console.WriteLine(teacherPostGraduateCourseQualificationList);
            return teacherPostGraduateCourseQualificationList;
        }
    }
}
