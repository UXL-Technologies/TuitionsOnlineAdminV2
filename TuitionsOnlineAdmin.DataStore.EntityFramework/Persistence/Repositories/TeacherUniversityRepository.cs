//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
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

        public List<TeacherUniversityWithForeignKeys> ViewTeacherUniversityRepository(int teacherId)
        {
            
            List<TeacherUniversity> teacherUniversityList = new List<TeacherUniversity>();
            List<TeacherUniversityWithForeignKeys> teacherUniversityWithForeignKeyList = new List<TeacherUniversityWithForeignKeys>() { };
            TeacherUniversityWithForeignKeys teacherUniversityWithForeignKey = new TeacherUniversityWithForeignKeys();
            //  List<TeacherUniversityWithForeignKeys> list = new List<TeacherUniversityWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {
                   
                    teacherUniversityList = diTuitionsOnlineAdminDbContext.TeacherUniversity.Where(s => s.TeacherId == teacherId).ToList();
                   
                    foreach (var teacherUniversity in teacherUniversityList)
                    {
                        var list1 = new List<TeacherUniversityWithForeignKeys>();
                        
                        var TeacherDetails = diTuitionsOnlineAdminDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherUniversity.TeacherId);
                        var UniversityDetails = diTuitionsOnlineAdminDbContext.University.FirstOrDefault(s => s.UniversityId == teacherUniversity.UniversityId);
                        teacherUniversityWithForeignKeyList.Add(new TeacherUniversityWithForeignKeys()
                        {
                            TeacherName = TeacherDetails.Teacher_Name,
                            UniversityName = UniversityDetails.UniversityName,
                            UniversityId = UniversityDetails.UniversityId,
                            TeacherId = TeacherDetails.TeacherId,
                            TeacherUniversityId = teacherUniversity.TeacherUniversityId
                        });
                    }
                }
                if (teacherUniversityWithForeignKeyList == null)
                {
                    
                    teacherUniversityWithForeignKeyList = new List<TeacherUniversityWithForeignKeys>();
                }
                return teacherUniversityWithForeignKeyList;
            }
            catch (Exception)
            {
                return teacherUniversityWithForeignKeyList = null;
            }
        }
        //Aim : To create Teacher University in the database
        public string CreateTeacherUniversity(int teacherId, int selectedUniversities)
        {
           
            try
            {
                

                var teacherUniversity = new TeacherUniversity { TeacherId = teacherId, UniversityId = selectedUniversities };
               
                diTuitionsOnlineAdminDbContext.TeacherUniversity.Add(teacherUniversity);

                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {


                BusinessMessage businessMessage = new BusinessMessage();
                
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_TEACHERUNIVERSITY;
            }
        }
        //Aim : To remove Teacher Universities from the database
        public string EditTeacherUniversity(List<TeacherUniversityWithForeignKeys> teacherUniversities)
        {
            try
            {
               
                foreach (var teacherUniversity in teacherUniversities)
                {
                    
                    //  TeacherGraduateCourse_Qualification teacherGraduateCourseQualificationId = new TeacherGraduateCourse_Qualification() {TeacherGraduateCourse_QualificationId= teacherGraduateCourses.TeacherGraduateCourse_QualificationId, GraduateCourseId = teacherGraduateCourses.GraduateCourseId, TeacherId = teacherGraduateCourses.TeacherId
                    // };
                    // diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.Attach(teacherGraduateCourseQualificationId);
                    //diTuitionsOnlineAdminDbContext.TeacherGraduateCourse_Qualification.DeleteObject(teacherGraduateCourseQualificationId);
                    var id = teacherUniversity.TeacherUniversityId;
                    
                    var recordId = diTuitionsOnlineAdminDbContext.TeacherUniversity.FirstOrDefault(s => s.TeacherUniversityId == id);
                    
                    diTuitionsOnlineAdminDbContext.TeacherUniversity.Remove(recordId);
                }
                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_TEACHERUNIVERSITY;
            }
        }
    }
}
