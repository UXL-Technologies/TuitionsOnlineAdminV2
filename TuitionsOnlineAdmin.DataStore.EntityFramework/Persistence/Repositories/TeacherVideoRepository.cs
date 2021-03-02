//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:12-Jan-2021
//Aim: implementing the inteface ITeacherVideoRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherVideoRepository : ITeacherVideoRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public TeacherVideoRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }


        //To create a single record for TeacherVideo
        public string CreateTeacherVideoRepository(TeacherVideo teacherVideo)
        {
            try {
                instanceOfDbContext.TeacherVideo.Add(teacherVideo);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_TEACHERVIDEO;
            }
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To view TeacherVideo based on the search criteria 
        public List<TeacherVideo> ViewTeacherVideoRepository(string searchKey)
        {
            try {
                if (searchKey != null)
                {
                    List<TeacherVideo> teacherVideoList = new List<TeacherVideo>();
                    teacherVideoList = instanceOfDbContext.TeacherVideo.Where(s => s.VideoURL.Contains(searchKey)).ToList();
                    return teacherVideoList;
                }
                //if not entire list of data is displayed
                else

                {
                    var teacherVideoList = instanceOfDbContext.TeacherVideo.ToList();
                    return teacherVideoList;
                }
            }
            catch (Exception) {
                List<TeacherVideo> teacherVideoList = new List<TeacherVideo>();
                return teacherVideoList = null;

            }
            //if the seach key is present the list is displayed

        }
        //To update TeacherVideo
        public string UpdateTeacherVideoRepository(TeacherVideo teacherVideo)
        {
            try {
                TeacherVideo teacherVideoToBeUpdated = instanceOfDbContext.TeacherVideo.FirstOrDefault(s => s.TeacherVideoId == teacherVideo.TeacherVideoId);
                teacherVideoToBeUpdated = teacherVideo;
                instanceOfDbContext.TeacherVideo.Append(teacherVideoToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_TEACHERVIDEO;
            }

        }



    }
}
