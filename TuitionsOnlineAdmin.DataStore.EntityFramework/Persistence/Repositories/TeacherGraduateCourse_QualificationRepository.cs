﻿//Authors: SA, BM, SM,BA ,KK
//Date:22-Feb-2021
//Aim: implementing the inteface ITeacherGraduateCourse_QualificationRepository 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherGraduateCourse_QualificationRepository : ITeacherGraduateCourse_QualificationRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        //constructor dependency injection
        public TeacherGraduateCourse_QualificationRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

        //Aim : To view Graduate Course Qualifications from the database
        public List<TeacherGraduateCourse_Qualification> ViewGraduateCourseQualificationRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherGraduateCourse_Qualification> teacherGraduateCourseQualificationList = new List<TeacherGraduateCourse_Qualification>();

            try
            {
                if (teacherId != 0)
                {
                    Console.WriteLine(teacherId);
                    teacherGraduateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherGraduateCourseQualificationList);
                    if (teacherGraduateCourseQualificationList == null) {
                        teacherGraduateCourseQualificationList = new List<TeacherGraduateCourse_Qualification>();
                    }
                }
                Console.WriteLine(teacherGraduateCourseQualificationList);
                return teacherGraduateCourseQualificationList;


            }
            catch (Exception) {
                return teacherGraduateCourseQualificationList = null;

            }
        }

        //Aim : To create Teacher Graduate Course Qualification in the database
      
        public string CreateTeacherGraduateCourseQualification(int teacherId, int selectedGraduateCourses)
        {
            try
            {
                    var teacherGraduateCourseQualification = new TeacherGraduateCourse_Qualification { TeacherId = teacherId, GraduateCourseId = selectedGraduateCourses };
                Console.WriteLine(teacherGraduateCourseQualification);
                    diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Add(teacherGraduateCourseQualification);
                
                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_SUBJECT;
            }
        }

        //Aim : To remove Teacher Graduate Course Qualifications from the database
        public string EditGraduateCourseQualification(List<TeacherGraduateCourse_Qualification> teacherGraduateCourseQualifications)
        {
            try
            {
                foreach (var teacherGraduateCourses in teacherGraduateCourseQualifications) 
                { 
                diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Remove(teacherGraduateCourses);
                }
                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_SUBJECT;
            }
        }
    }
}
