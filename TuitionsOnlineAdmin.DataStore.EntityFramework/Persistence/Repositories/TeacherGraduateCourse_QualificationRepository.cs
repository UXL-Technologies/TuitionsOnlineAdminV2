//Authors: SA, BM, SM,BA ,KK
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
        public List<TeacherGraduateCourse_QualificationWithForeignKeys> ViewGraduateCourseQualificationRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherGraduateCourse_Qualification> teacherGraduateCourseQualificationList = new List<TeacherGraduateCourse_Qualification>();
            List<TeacherGraduateCourse_QualificationWithForeignKeys> teacherGraduateCourseQualificationWithForeignKeyList = new List<TeacherGraduateCourse_QualificationWithForeignKeys>() { };
            TeacherGraduateCourse_QualificationWithForeignKeys teacherGraduateCourseQualificationWithForeignKey = new TeacherGraduateCourse_QualificationWithForeignKeys();
            //  List<TeacherGraduateCourse_QualificationWithForeignKeys> list = new List<TeacherGraduateCourse_QualificationWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {
                    //Console.WriteLine(teacherId);
                    teacherGraduateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherGraduateCourseQualificationList);
                    foreach (var teacherGraduateCourseQualification in teacherGraduateCourseQualificationList)
                    {
                        var list1 = new List<TeacherGraduateCourse_QualificationWithForeignKeys>();
                        Console.WriteLine(teacherGraduateCourseQualificationWithForeignKeyList);
                        var TeacherDetails = diTuitionsOnlineAdminDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherGraduateCourseQualification.TeacherId);
                        var GraduateCourseDetails = diTuitionsOnlineAdminDbContext.GraduateCourse.FirstOrDefault(s => s.GraduateCourseId == teacherGraduateCourseQualification.GraduateCourseId);
                        teacherGraduateCourseQualificationWithForeignKeyList.Add(new TeacherGraduateCourse_QualificationWithForeignKeys()
                        {
                            TeacherName = TeacherDetails.Teacher_Name,
                            GraduateCourseName = GraduateCourseDetails.GraduateCourseName,
                            GraduateCourseId = GraduateCourseDetails.GraduateCourseId,
                            TeacherId = TeacherDetails.TeacherId,
                            TeacherGraduateCourse_QualificationId = teacherGraduateCourseQualification.TeacherGraduateCourse_QualificationId
                        });
                    }
                }
                if (teacherGraduateCourseQualificationWithForeignKeyList == null)
                {
                    teacherGraduateCourseQualificationWithForeignKeyList = new List<TeacherGraduateCourse_QualificationWithForeignKeys>();
                }
                return teacherGraduateCourseQualificationWithForeignKeyList;
            }
            catch (Exception)
            {
                return teacherGraduateCourseQualificationWithForeignKeyList = null;
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
        public string EditGraduateCourseQualification(List<TeacherGraduateCourse_QualificationWithForeignKeys> teacherGraduateCourseQualifications)
        {
            try
            {
                Console.WriteLine(teacherGraduateCourseQualifications);
                foreach (var teacherGraduateCourseQualification in teacherGraduateCourseQualifications)
                {
                    Console.WriteLine(teacherGraduateCourseQualification);
                    //  TeacherGraduateCourse_Qualification teacherGraduateCourseQualificationId = new TeacherGraduateCourse_Qualification() {TeacherGraduateCourse_QualificationId= teacherGraduateCourses.TeacherGraduateCourse_QualificationId, GraduateCourseId = teacherGraduateCourses.GraduateCourseId, TeacherId = teacherGraduateCourses.TeacherId
                    // };
                    // diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Attach(teacherGraduateCourseQualificationId);
                    //diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.DeleteObject(teacherGraduateCourseQualificationId);
                    var id = teacherGraduateCourseQualification.TeacherGraduateCourse_QualificationId;
                    Console.WriteLine(id);
                    var recordId = diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.FirstOrDefault(s => s.TeacherGraduateCourse_QualificationId == id);
                    Console.WriteLine(recordId);
                    diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Remove(recordId);
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
