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
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        public TeacherGraduateCourse_QualificationRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

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
    }
}
