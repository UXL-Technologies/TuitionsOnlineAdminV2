﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:23-Feb-2021
//Aim: implementing the inteface ITeacherPostGraduateCourse_QualificationRepository 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherPostGraduateCourse_QualificationRepository : ITeacherPostGraduateCourse_QualificationRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        //constructor dependency injection
        public TeacherPostGraduateCourse_QualificationRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

        //Aim : To view PostGraduate Course Qualifications from the database
        public List<TeacherPostGraduateCourse_QualificationWithForeignKeys> ViewPostGraduateCourseQualificationRepository(int teacherId)
        {
          
            List<TeacherPostGraduateCourse_Qualification> teacherPostGraduateCourseQualificationList = new List<TeacherPostGraduateCourse_Qualification>();
            List<TeacherPostGraduateCourse_QualificationWithForeignKeys> teacherPostGraduateCourseQualificationWithForeignKeyList = new List<TeacherPostGraduateCourse_QualificationWithForeignKeys>() { };
            TeacherPostGraduateCourse_QualificationWithForeignKeys teacherPostGraduateCourseQualificationWithForeignKey = new TeacherPostGraduateCourse_QualificationWithForeignKeys();
          //  List<TeacherPostGraduateCourse_QualificationWithForeignKeys> list = new List<TeacherPostGraduateCourse_QualificationWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {
                    
                    teacherPostGraduateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherPostGraduateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                    
                    foreach (var teacherPostGraduateCourseQualification in teacherPostGraduateCourseQualificationList) {
                        var list1 = new List<TeacherPostGraduateCourse_QualificationWithForeignKeys>();
                         
                        var TeacherDetails = diTuitionsOnlineAdminDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherPostGraduateCourseQualification.TeacherId);
                        var PostGraduateCourseDetails = diTuitionsOnlineAdminDbContext.PostGraduateCourse.FirstOrDefault(s=>s.PostGraduateCourseId == teacherPostGraduateCourseQualification.PostGraduateId);
                        teacherPostGraduateCourseQualificationWithForeignKeyList.Add(new TeacherPostGraduateCourse_QualificationWithForeignKeys() { TeacherName = TeacherDetails.Teacher_Name, PostGraduateCourseName = PostGraduateCourseDetails.PostGraduateCourseName, PostGraduateId
                        = PostGraduateCourseDetails.PostGraduateCourseId, TeacherId = TeacherDetails.TeacherId, TeacherPostGraduateCourse_QualificationId = teacherPostGraduateCourseQualification.TeacherPostGraduateCourse_QualificationId
                        });
                    }
                }
                if (teacherPostGraduateCourseQualificationWithForeignKeyList == null)
                {
                    teacherPostGraduateCourseQualificationWithForeignKeyList = new List<TeacherPostGraduateCourse_QualificationWithForeignKeys>();
                }
                return teacherPostGraduateCourseQualificationWithForeignKeyList;
            }
            catch (Exception) {
                return teacherPostGraduateCourseQualificationWithForeignKeyList = null;
            }
        }

        //Aim : To create Teacher PostGraduate Course Qualification in the database
        public string CreateTeacherPostGraduateCourseQualification(int teacherId, int selectedPostGraduateCourses)
        {
       
            try
            {
                
                var teacherPostGraduateCourseQualification = new TeacherPostGraduateCourse_Qualification { TeacherId = teacherId, PostGraduateId = selectedPostGraduateCourses };
                
                diTuitionsOnlineAdminDbContext.TeacherPostGraduateCourse_Qualification.Add(teacherPostGraduateCourseQualification);

                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                

                BusinessMessage businessMessage = new BusinessMessage();
                
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_TEACHERPOSTGRADUATECOURSE_QUALIFICATIONS;
            }
        }


        //Aim : To remove Teacher PostGraduate Course Qualifications from the database
        public string EditTeacherPostGraduateCourseQualification(List<TeacherPostGraduateCourse_QualificationWithForeignKeys> teacherPostGraduateCourseQualifications)
        {

            try
            {
                
                foreach (var teacherPostGraduateCourseQualification in teacherPostGraduateCourseQualifications)
                {
                    
                    //  TeacherGraduateCourse_Qualification teacherGraduateCourseQualificationId = new TeacherGraduateCourse_Qualification() {TeacherGraduateCourse_QualificationId= teacherGraduateCourses.TeacherGraduateCourse_QualificationId, GraduateCourseId = teacherGraduateCourses.GraduateCourseId, TeacherId = teacherGraduateCourses.TeacherId
                    // };
                    // diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Attach(teacherGraduateCourseQualificationId);
                    //diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.DeleteObject(teacherGraduateCourseQualificationId);
                    var id = teacherPostGraduateCourseQualification.TeacherPostGraduateCourse_QualificationId;
                    
                    var recordId = diTuitionsOnlineAdminDbContext.TeacherPostGraduateCourse_Qualification.FirstOrDefault(s => s.TeacherPostGraduateCourse_QualificationId == id);
                    
                    diTuitionsOnlineAdminDbContext.TeacherPostGraduateCourse_Qualification.Remove(recordId);
                }
                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_TEACHERPOSTGRADUATECOURSE_QUALIFICATIONS;
            }
        }

       
    }
}
