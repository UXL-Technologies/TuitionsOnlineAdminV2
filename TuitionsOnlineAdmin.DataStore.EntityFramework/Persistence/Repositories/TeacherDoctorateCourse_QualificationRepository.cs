//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: implementing the inteface ITeacherDoctorateCourse_QualificationRepository 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
   public class TeacherDoctorateCourse_QualificationRepository : ITeacherDoctorateCourse_QualificationRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        //constructor dependency injection
        public TeacherDoctorateCourse_QualificationRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

        //Aim : To view Doctorate Course Qualifications from the database
        public List<TeacherDoctorateCourse_QualificationWithForeignKeys> ViewDoctorateCourseQualificationRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherDoctorateCourse_Qualification> teacherDoctorateCourseQualificationList = new List<TeacherDoctorateCourse_Qualification>();
            List<TeacherDoctorateCourse_QualificationWithForeignKeys> teacherDoctorateCourseQualificationWithForeignKeyList = new List<TeacherDoctorateCourse_QualificationWithForeignKeys>() { };
            TeacherDoctorateCourse_QualificationWithForeignKeys teacherDoctorateCourseQualificationWithForeignKey = new TeacherDoctorateCourse_QualificationWithForeignKeys();
            //  List<TeacherDoctorateCourse_QualificationWithForeignKeys> list = new List<TeacherDoctorateCourse_QualificationWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {
                    //Console.WriteLine(teacherId);
                    teacherDoctorateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherDoctorateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherDoctorateCourseQualificationList);
                    foreach (var teacherDoctorateCourseQualification in teacherDoctorateCourseQualificationList)
                    {
                        var list1 = new List<TeacherDoctorateCourse_QualificationWithForeignKeys>();
                        Console.WriteLine(teacherDoctorateCourseQualificationWithForeignKeyList);
                        var TeacherDetails = diTuitionsOnlineAdminDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherDoctorateCourseQualification.TeacherId);
                        var DoctorateCourseDetails = diTuitionsOnlineAdminDbContext.DoctorateCourse.FirstOrDefault(s => s.DoctorateCourseId == teacherDoctorateCourseQualification.DoctorateCourseId);
                        teacherDoctorateCourseQualificationWithForeignKeyList.Add(new TeacherDoctorateCourse_QualificationWithForeignKeys()
                        {
                            TeacherName = TeacherDetails.Teacher_Name,
                            DoctorateCourseName = DoctorateCourseDetails.DoctorateCourseName,
                            DoctorateCourseId
                        = DoctorateCourseDetails.DoctorateCourseId,
                            TeacherId = TeacherDetails.TeacherId,
                            TeacherDoctorateCourse_QualificationId = teacherDoctorateCourseQualification.TeacherDoctorateCourse_QualificationId
                        });
                    }
                }
                if (teacherDoctorateCourseQualificationWithForeignKeyList == null)
                {
                    teacherDoctorateCourseQualificationWithForeignKeyList = new List<TeacherDoctorateCourse_QualificationWithForeignKeys>();
                }
                return teacherDoctorateCourseQualificationWithForeignKeyList;
            }
            catch (Exception)
            {
                return teacherDoctorateCourseQualificationWithForeignKeyList = null;
            }
        }

        //Aim : To create Teacher Doctorate Course Qualification in the database
        public string CreateTeacherDoctorateCourseQualification(int teacherId, int selectedDoctorateCourses)
            {
                Console.WriteLine(teacherId);
                Console.WriteLine(selectedDoctorateCourses);
                try
                {
                    Console.WriteLine(teacherId);
                    var teacherDoctorateCourseQualification = new TeacherDoctorateCourse_Qualification { TeacherId = teacherId, DoctorateCourseId = selectedDoctorateCourses };
                    Console.WriteLine(teacherDoctorateCourseQualification);
                    diTuitionsOnlineAdminDbContext.TeacherDoctorateCourse_Qualification.Add(teacherDoctorateCourseQualification);

                    diTuitionsOnlineAdminDbContext.SaveChanges();
                    return "done";
                }
                catch (Exception)
                {


                    BusinessMessage businessMessage = new BusinessMessage();
                    Console.WriteLine(businessMessage);
                    return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_SUBJECT;
                }
            }

        //Aim : To remove Teacher Doctorate Course Qualifications from the database
        public string EditTeacherDoctorateCourseQualification(List<TeacherDoctorateCourse_Qualification> teacherDoctorateCourseQualifications)
        {
            try
            {
                foreach (var teacherDoctorateCourses in teacherDoctorateCourseQualifications)
                {
                    diTuitionsOnlineAdminDbContext.TeacherDoctorateCourse_Qualification.Remove(teacherDoctorateCourses);
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

