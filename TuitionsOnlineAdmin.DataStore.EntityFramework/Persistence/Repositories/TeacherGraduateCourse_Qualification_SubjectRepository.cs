using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherGraduateCourse_Qualification_SubjectRepository : ITeacherGraduateCourse_Qualification_SubjectRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        //constructor dependency injection
        public TeacherGraduateCourse_Qualification_SubjectRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

       

        public List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys> ViewTeacherGraduateCourseQualificationSubjectRepository(int teacherId, int graduateCourseId)
        {
            return null;

            List<TeacherGraduateCourse_Qualification_Subject> teacherGraduateCourseQualificationSubjectList = new List<TeacherGraduateCourse_Qualification_Subject>();
            List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys> teacherGraduateCourseQualificationSubjectWithForeignKeyList = new List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys>() { };
            TeacherGraduateCourse_Qualification_SubjectWithForeignKeys teacherGraduateCourseQualificationSubjectWithForeignKey = new TeacherGraduateCourse_Qualification_SubjectWithForeignKeys();
            //List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys> list = new List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {

                    teacherGraduateCourseQualificationSubjectList = diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification_Subject.Where(s => s.TeacherId == teacherId).ToList();

                    foreach (var teacherGraduateCourseQualificationSubject in teacherGraduateCourseQualificationSubjectList)
                    {
                        var list1 = new List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys>();

                        var TeacherDetails = diTuitionsOnlineAdminDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherGraduateCourseQualificationSubject.TeacherId);
                        var GraduateCourseDetails = diTuitionsOnlineAdminDbContext.GraduateCourse.FirstOrDefault(s => s.GraduateCourseId == teacherGraduateCourseQualificationSubject.GraduateCourseId);
                        var SubjectDetails = diTuitionsOnlineAdminDbContext.Subject.FirstOrDefault(s => s.SubjectId == teacherGraduateCourseQualificationSubject.SubjectId);
                        teacherGraduateCourseQualificationSubjectWithForeignKeyList.Add(new TeacherGraduateCourse_Qualification_SubjectWithForeignKeys()
                        {
                            TeacherName = TeacherDetails.Teacher_Name,
                            GraduateCourseName = GraduateCourseDetails.GraduateCourseName,
                            GraduateCourseId = GraduateCourseDetails.GraduateCourseId,
                            TeacherId = TeacherDetails.TeacherId,
                            SubjectId = SubjectDetails.SubjectId,
                            SubjectName = SubjectDetails.SubjectName
                            //TeacherGraduateCourse_QualificationId = teacherGraduateCourseQualification.TeacherGraduateCourse_QualificationId
                        });
                    }
                }
                if (teacherGraduateCourseQualificationSubjectWithForeignKeyList == null)
                {
                    teacherGraduateCourseQualificationSubjectWithForeignKeyList = new List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys>();
                }
                return teacherGraduateCourseQualificationSubjectWithForeignKeyList;
            }
            catch (Exception)
            {
                return teacherGraduateCourseQualificationSubjectWithForeignKeyList = null;
            }
        }
    }
}
