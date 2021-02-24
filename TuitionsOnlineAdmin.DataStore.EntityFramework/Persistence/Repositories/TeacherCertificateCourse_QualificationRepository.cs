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
        public List<TeacherCertificateCourse_Qualification> ViewCertificateCourseQualificationRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherCertificateCourse_Qualification> teacherCertificateCourseQualificationList = new List<TeacherCertificateCourse_Qualification>();

            try
            {
                if (teacherId != 0)
                {
                    Console.WriteLine(teacherId);
                    teacherCertificateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherCertificateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherCertificateCourseQualificationList);
                    if (teacherCertificateCourseQualificationList == null)
                    {
                        teacherCertificateCourseQualificationList = new List<TeacherCertificateCourse_Qualification>();
                    }
                }
                Console.WriteLine(teacherCertificateCourseQualificationList);
                return teacherCertificateCourseQualificationList;


            }
            catch (Exception)
            {
                return teacherCertificateCourseQualificationList = null;

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
        public string EditTeacherCertificateCourseQualification(List<TeacherCertificateCourse_Qualification> teacherCertificateCourseQualifications)
        {
            try
            {
                foreach (var teacherCertificateCourses in teacherCertificateCourseQualifications)
                {
                    diTuitionsOnlineAdminDbContext.TeacherCertificateCourse_Qualification.Remove(teacherCertificateCourses);
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
