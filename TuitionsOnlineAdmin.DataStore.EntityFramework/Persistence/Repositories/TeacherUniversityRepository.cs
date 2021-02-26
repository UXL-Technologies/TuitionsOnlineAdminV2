//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: implementing the inteface ITeacherUniversityRepository 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
   public class TeacherUniversityRepository : ITeacherUniversityRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        //constructor dependency injection
        public TeacherUniversityRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

        //Aim : To view University from the database

        public List<TeacherUniversity> ViewTeacherUniversityRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherUniversity> teacherUniversityList = new List<TeacherUniversity>();

            try
            {
                if (teacherId != 0)
                {
                    Console.WriteLine(teacherId);
                    teacherUniversityList = diTuitionsOnlineAdminDbContext.TeacherUniversity.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherUniversityList);
                    if (teacherUniversityList == null)
                    {
                        teacherUniversityList = new List<TeacherUniversity>();
                    }
                }
                Console.WriteLine(teacherUniversityList);
                return teacherUniversityList;


            }
            catch (Exception)
            {
                return teacherUniversityList = null;

            }

        }
        //Aim : To create Teacher University in the database
        public string CreateTeacherUniversity(int teacherId, int selectedUniversities)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedUniversities);
            try
            {
                Console.WriteLine(teacherId);
                Console.WriteLine(selectedUniversities);

                var teacherUniversity = new TeacherUniversity { TeacherId = teacherId, UniversityId = selectedUniversities };
                Console.WriteLine(teacherUniversity);
                diTuitionsOnlineAdminDbContext.TeacherUniversity.Add(teacherUniversity);

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
        //Aim : To remove Teacher Universities from the database
        public string EditTeacherUniversity(List<TeacherUniversity> teacherUniversities)
        {
            try
            {
                foreach (var teacherUniversity in teacherUniversities)
                {
                    diTuitionsOnlineAdminDbContext.TeacherUniversity.Remove(teacherUniversity);
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
