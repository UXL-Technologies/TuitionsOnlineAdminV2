//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:22-Feb-2021
//Aim: implementing the interface ITeacherGraduateCourse_QualificationRepository 

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
            
            List<TeacherGraduateCourse_Qualification> teacherGraduateCourseQualificationList = new List<TeacherGraduateCourse_Qualification>();
            List<TeacherGraduateCourse_QualificationWithForeignKeys> teacherGraduateCourseQualificationWithForeignKeyList = new List<TeacherGraduateCourse_QualificationWithForeignKeys>() { };
            TeacherGraduateCourse_QualificationWithForeignKeys teacherGraduateCourseQualificationWithForeignKey = new TeacherGraduateCourse_QualificationWithForeignKeys();
            //  List<TeacherGraduateCourse_QualificationWithForeignKeys> list = new List<TeacherGraduateCourse_QualificationWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {
                    
                    teacherGraduateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                  
                    foreach (var teacherGraduateCourseQualification in teacherGraduateCourseQualificationList)
                    {
                        var list1 = new List<TeacherGraduateCourse_QualificationWithForeignKeys>();
                       
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

        public string CreateTeacherGraduateCourseQualificationRepository(int teacherId, int selectedGraduateCourses)
        {
            try
            {
                    var teacherGraduateCourseQualification = new TeacherGraduateCourse_Qualification { TeacherId = teacherId, GraduateCourseId = selectedGraduateCourses };
                
                    diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Add(teacherGraduateCourseQualification);
                
                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_TEACHERGRADUATECOURSE_QUALIFICATIONS;
            }
        }

        //Aim : To remove Teacher Graduate Course Qualifications from the database
        public string EditGraduateCourseQualificationRepository(List<TeacherGraduateCourse_QualificationWithForeignKeys> teacherGraduateCourseQualifications)
        {
            try
            {
                
                foreach (var teacherGraduateCourseQualification in teacherGraduateCourseQualifications)
                {
                    
                    //  TeacherGraduateCourse_Qualification teacherGraduateCourseQualificationId = new TeacherGraduateCourse_Qualification() {TeacherGraduateCourse_QualificationId= teacherGraduateCourses.TeacherGraduateCourse_QualificationId, GraduateCourseId = teacherGraduateCourses.GraduateCourseId, TeacherId = teacherGraduateCourses.TeacherId
                    // };
                    // diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Attach(teacherGraduateCourseQualificationId);
                    //diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.DeleteObject(teacherGraduateCourseQualificationId);
                    var id = teacherGraduateCourseQualification.TeacherGraduateCourse_QualificationId;
                    
                    var recordId = diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.FirstOrDefault(s => s.TeacherGraduateCourse_QualificationId == id);
                    
                    diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Remove(recordId);
                }
                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_TEACHERGRADUATECOURSE_QUALIFICATIONS;
            }
        }
    }
}
