//Authors: SA, BM, SM
// Date:14-Jan-2021
//Aim: implementing the inteface IPostGraduateCourseRepository



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class PostGraduateCourseRepository : IPostGraduateCourseRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public PostGraduateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {

            this.instanceOfDbContext = instanceOfDbContext;

        }

        //To create a single record for PostGraduateCourse
        public string CreatePostGraduateRepository(PostGraduateCourse postGraduateCourse)
        { 
            try
            {
                instanceOfDbContext.PostGraduateCourse.Add(postGraduateCourse);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_POSTGRADUATECOURSE;

            }
        }


        //To Update a record for PostGraduateCourse
        public string UpdatePostGraduateCourseRepository(PostGraduateCourse postGraduateCourse)
        {
            try {
                PostGraduateCourse postGraduateCourseToBeUpdated = instanceOfDbContext.PostGraduateCourse.FirstOrDefault(s => s.PostGraduateCourseId == postGraduateCourse.PostGraduateCourseId);
                postGraduateCourseToBeUpdated = postGraduateCourse;
                instanceOfDbContext.PostGraduateCourse.Append(postGraduateCourseToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_POSTGRADUATECOURSE;
            }
        }

        //To view post graduate courses based on the search criteria 
        public List<PostGraduateCourse> ViewPostGraduateCourseRepository(string searchKey)
        {
            try {
                if (searchKey != null)
                {
                    List<PostGraduateCourse> postGraduateCourseList = new List<PostGraduateCourse>();
                    postGraduateCourseList = instanceOfDbContext.PostGraduateCourse.Where(s => s.PostGraduateCourseName.Contains(searchKey)).ToList();
                    return postGraduateCourseList;
                }
                //if not entire list of data is displayed
                else

                {
                    var postGraduateCourseList = instanceOfDbContext.PostGraduateCourse.ToList();
                    return postGraduateCourseList;
                }
            }
            //if the seach key is present the list is displayed
            catch(Exception) {
                List<PostGraduateCourse> postGraduateCourseList = new List<PostGraduateCourse>();
                return postGraduateCourseList = null;

            }
        }
    }
}
