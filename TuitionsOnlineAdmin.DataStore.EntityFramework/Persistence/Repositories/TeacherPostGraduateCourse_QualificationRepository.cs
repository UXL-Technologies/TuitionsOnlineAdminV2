//Authors: SA, BM, SM,BA ,KK
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
        public List<TeacherPostGraduateCourse_Qualification> ViewPostGraduateCourseQualificationRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherPostGraduateCourse_Qualification> teacherPostGraduateCourseQualificationList = new List<TeacherPostGraduateCourse_Qualification>();

            try
            {
                if (teacherId != 0)
                {
                    Console.WriteLine(teacherId);
                    teacherPostGraduateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherPostGraduateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherPostGraduateCourseQualificationList);
                    if (teacherPostGraduateCourseQualificationList == null)
                    {
                        teacherPostGraduateCourseQualificationList = new List<TeacherPostGraduateCourse_Qualification>();
                    }
                }
                Console.WriteLine(teacherPostGraduateCourseQualificationList);
                return teacherPostGraduateCourseQualificationList;


            }
            catch (Exception)
            {
                return teacherPostGraduateCourseQualificationList = null;

            }
        }

        //Aim : To create Teacher PostGraduate Course Qualification in the database
        public string CreateTeacherPostGraduateCourseQualification(int teacherId, int selectedPostGraduateCourses)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedPostGraduateCourses);
            try
            {
                Console.WriteLine(teacherId);
                var teacherPostGraduateCourseQualification = new TeacherPostGraduateCourse_Qualification { TeacherId = teacherId, PostGraduateId = selectedPostGraduateCourses };
                Console.WriteLine(teacherPostGraduateCourseQualification);
                diTuitionsOnlineAdminDbContext.TeacherPostGraduateCourse_Qualification.Add(teacherPostGraduateCourseQualification);

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


        //Aim : To remove Teacher PostGraduate Course Qualifications from the database
        public string EditTeacherPostGraduateCourseQualification(List<TeacherPostGraduateCourse_Qualification> teacherPostGraduateCourseQualifications)
        {
            try
            {
                foreach (var teacherPostGraduateCourses in teacherPostGraduateCourseQualifications)
                {
                    diTuitionsOnlineAdminDbContext.TeacherPostGraduateCourse_Qualification.Remove(teacherPostGraduateCourses);
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
