//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
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
           
            List<TeacherDoctorateCourse_Qualification> teacherDoctorateCourseQualificationList = new List<TeacherDoctorateCourse_Qualification>();
            List<TeacherDoctorateCourse_QualificationWithForeignKeys> teacherDoctorateCourseQualificationWithForeignKeyList = new List<TeacherDoctorateCourse_QualificationWithForeignKeys>() { };
            TeacherDoctorateCourse_QualificationWithForeignKeys teacherDoctorateCourseQualificationWithForeignKey = new TeacherDoctorateCourse_QualificationWithForeignKeys();
            //  List<TeacherDoctorateCourse_QualificationWithForeignKeys> list = new List<TeacherDoctorateCourse_QualificationWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {
                    
                    teacherDoctorateCourseQualificationList = diTuitionsOnlineAdminDbContext.TeacherDoctorateCourse_Qualification.Where(s => s.TeacherId == teacherId).ToList();
                    
                    foreach (var teacherDoctorateCourseQualification in teacherDoctorateCourseQualificationList)
                    {
                        var list1 = new List<TeacherDoctorateCourse_QualificationWithForeignKeys>();
                        
                        var TeacherDetails = diTuitionsOnlineAdminDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherDoctorateCourseQualification.TeacherId);
                        var DoctorateCourseDetails = diTuitionsOnlineAdminDbContext.DoctorateCourse.FirstOrDefault(s => s.DoctorateCourseId == teacherDoctorateCourseQualification.DoctorateCourseId);
                        teacherDoctorateCourseQualificationWithForeignKeyList.Add(new TeacherDoctorateCourse_QualificationWithForeignKeys()
                        {
                            TeacherName = TeacherDetails.Teacher_Name,
                            DoctorateCourseName = DoctorateCourseDetails.DoctorateCourseName,
                            DoctorateCourseId = DoctorateCourseDetails.DoctorateCourseId,
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
               
                try
                {
                    
                    var teacherDoctorateCourseQualification = new TeacherDoctorateCourse_Qualification { TeacherId = teacherId, DoctorateCourseId = selectedDoctorateCourses };
                
                    diTuitionsOnlineAdminDbContext.TeacherDoctorateCourse_Qualification.Add(teacherDoctorateCourseQualification);

                    diTuitionsOnlineAdminDbContext.SaveChanges();
                    return "done";
                }
                catch (Exception)
                {


                    BusinessMessage businessMessage = new BusinessMessage();
                   
                    return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_TEACHERDOCTORATECOURSE_QUALIFICATIONS;
                }
            }

        //Aim : To remove Teacher Doctorate Course Qualifications from the database
        public string EditTeacherDoctorateCourseQualification(List<TeacherDoctorateCourse_QualificationWithForeignKeys> teacherDoctorateCourseQualifications)
        {
            try
            {
                
                foreach (var teacherDoctorateCourseQualification in teacherDoctorateCourseQualifications)
                {
                    
                    //  TeacherGraduateCourse_Qualification teacherGraduateCourseQualificationId = new TeacherGraduateCourse_Qualification() {TeacherGraduateCourse_QualificationId= teacherGraduateCourses.TeacherGraduateCourse_QualificationId, GraduateCourseId = teacherGraduateCourses.GraduateCourseId, TeacherId = teacherGraduateCourses.TeacherId
                    // };
                    // diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Attach(teacherGraduateCourseQualificationId);
                    //diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.DeleteObject(teacherGraduateCourseQualificationId);
                    var id = teacherDoctorateCourseQualification.TeacherDoctorateCourse_QualificationId;
                 
                    var recordId = diTuitionsOnlineAdminDbContext.TeacherDoctorateCourse_Qualification.FirstOrDefault(s => s.TeacherDoctorateCourse_QualificationId == id);
             
                    diTuitionsOnlineAdminDbContext.TeacherDoctorateCourse_Qualification.Remove(recordId);
                }
                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_TEACHERDOCTORATECOURSE_QUALIFICATIONS;
            }
        }
    }
}

