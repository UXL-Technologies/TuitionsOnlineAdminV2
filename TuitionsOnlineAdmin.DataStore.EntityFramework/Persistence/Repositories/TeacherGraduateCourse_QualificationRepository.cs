using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherGraduateCourse_QualificationRepository : ITeacherGraduateCourse_QualificationRepository
    {
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        public TeacherGraduateCourse_QualificationRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

        public List<TeacherGraduateCourseQualification> ViewGraduateCourseQualificationRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherGraduateCourseQualification> teacherGraduateCourseQualificationList = new List<TeacherGraduateCourseQualification>();

            try
            {
                if (teacherId != 0)
                {
                    Console.WriteLine(teacherId);
                    teacherGraduateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherGraduateCourseQualification.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherGraduateCourseQualificationList);
                    if (teacherGraduateCourseQualificationList == null) {
                        teacherGraduateCourseQualificationList = new List<TeacherGraduateCourseQualification>();
                    }
                }
                Console.WriteLine(teacherGraduateCourseQualificationList);
                return teacherGraduateCourseQualificationList;


            }
            catch (Exception) {
                return teacherGraduateCourseQualificationList = null;

            }
        }
    }
}
