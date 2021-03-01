//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: implementing the inteface ITeacherCertificateCourse_QualificationRepository 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
   public class TeacherCertificateCourse_QualificationRepository : ITeacherCertificateCourse_QualificationRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        //constructor dependency injection
        public TeacherCertificateCourse_QualificationRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

        //Aim : To view Certificate Course Qualifications from the database
        public List<TeacherCertificateCourse_QualificationWithForeignKeys> ViewCertificateCourseQualificationRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherCertificateCourse_Qualification> teacherCertificateCourseQualificationList = new List<TeacherCertificateCourse_Qualification>();
            List<TeacherCertificateCourse_QualificationWithForeignKeys> teacherCertificateCourseQualificationWithForeignKeyList = new List<TeacherCertificateCourse_QualificationWithForeignKeys>() { };
            TeacherCertificateCourse_QualificationWithForeignKeys teacherCertificateCourseQualificationWithForeignKey = new TeacherCertificateCourse_QualificationWithForeignKeys();
            //  List<TeacherCertificateCourse_QualificationWithForeignKeys> list = new List<TeacherCertificateCourse_QualificationWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {
                    //Console.WriteLine(teacherId);
                    teacherCertificateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherCertificateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherCertificateCourseQualificationList);
                    foreach (var teacherCertificateCourseQualification in teacherCertificateCourseQualificationList)
                    {
                        var list1 = new List<TeacherCertificateCourse_QualificationWithForeignKeys>();
                        Console.WriteLine(teacherCertificateCourseQualificationWithForeignKeyList);
                        var TeacherDetails = diTuitionsOnlineAdminDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherCertificateCourseQualification.TeacherId);
                        var CertificateCourseDetails = diTuitionsOnlineAdminDbContext.CertificateCourse.FirstOrDefault(s => s.CertificateCourseId == teacherCertificateCourseQualification.CertificateCourseId);
                        teacherCertificateCourseQualificationWithForeignKeyList.Add(new TeacherCertificateCourse_QualificationWithForeignKeys()
                        {
                            TeacherName = TeacherDetails.Teacher_Name,
                            CertificateCourseName = CertificateCourseDetails.CertificateCourseName,
                            CertificateCourseId
                        = CertificateCourseDetails.CertificateCourseId,
                            TeacherId = TeacherDetails.TeacherId,
                            TeacherCertificateCourse_QualificationId = teacherCertificateCourseQualification.TeacherCertificateCourse_QualificationId
                        });
                    }
                }
                if (teacherCertificateCourseQualificationWithForeignKeyList == null)
                {
                    teacherCertificateCourseQualificationWithForeignKeyList = new List<TeacherCertificateCourse_QualificationWithForeignKeys>();
                }
                return teacherCertificateCourseQualificationWithForeignKeyList;
            }
            catch (Exception)
            {
                return teacherCertificateCourseQualificationWithForeignKeyList = null;
            }
        }

        //Aim : To create Teacher Certificate Course Qualification in the database
        public string CreateTeacherCertificateCourseQualification(int teacherId, int selectedCertificateCourses)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedCertificateCourses);
            try
            {
                Console.WriteLine(teacherId);
                var teacherCertificateCourseQualification = new TeacherCertificateCourse_Qualification { TeacherId = teacherId, CertificateCourseId = selectedCertificateCourses };
                Console.WriteLine(teacherCertificateCourseQualification);
                diTuitionsOnlineAdminDbContext.TeacherCertificateCourse_Qualification.Add(teacherCertificateCourseQualification);

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

        //Aim : To remove Teacher Certificate Course Qualifications from the database
        public string EditTeacherCertificateCourseQualification(List<TeacherCertificateCourse_QualificationWithForeignKeys> teacherCertificateCourseQualifications)
        {
            try
            {
                Console.WriteLine(teacherCertificateCourseQualifications);
                foreach (var teacherCertificateCourseQualification in teacherCertificateCourseQualifications)
                {
                    Console.WriteLine(teacherCertificateCourseQualification);
                    //  TeacherGraduateCourse_Qualification teacherGraduateCourseQualificationId = new TeacherGraduateCourse_Qualification() {TeacherGraduateCourse_QualificationId= teacherGraduateCourses.TeacherGraduateCourse_QualificationId, GraduateCourseId = teacherGraduateCourses.GraduateCourseId, TeacherId = teacherGraduateCourses.TeacherId
                    // };
                    // diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Attach(teacherGraduateCourseQualificationId);
                    //diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.DeleteObject(teacherGraduateCourseQualificationId);
                    var id = teacherCertificateCourseQualification.TeacherCertificateCourse_QualificationId;
                    Console.WriteLine(id);
                    var recordId = diTuitionsOnlineAdminDbContext.TeacherCertificateCourse_Qualification.FirstOrDefault(s => s.TeacherCertificateCourse_QualificationId == id);
                    Console.WriteLine(recordId);
                    diTuitionsOnlineAdminDbContext.TeacherCertificateCourse_Qualification.Remove(recordId);
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
