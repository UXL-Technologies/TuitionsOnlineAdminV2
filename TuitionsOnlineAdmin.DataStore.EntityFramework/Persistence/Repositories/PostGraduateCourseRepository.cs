//Authors: SA, BM, SM
// Date:14-Jan-2021
//Aim: defining the Repository for postGraduate course



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class PostGraduateCourseRepository : IPostGraduateCourseRepository
    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;

        public PostGraduateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {

            this.instanceOfDbContext = instanceOfDbContext;

        }

        //To create a single record for PostGraduateCourse
        public void CreatePostGraduateRepository(PostGraduateCourse postGraduateCourse)
        {
            instanceOfDbContext.PostGraduateCourse.Add(postGraduateCourse);
            instanceOfDbContext.SaveChanges();
        }


        //To Update a record for PostGraduateCourse
        public string UpdatePostGraduateCourseRepository(PostGraduateCourse postGraduateCourse)
        {
            PostGraduateCourse postGraduateCourseToBeUpdated = instanceOfDbContext.PostGraduateCourse.FirstOrDefault(s => s.PostGraduateCourseId == postGraduateCourse.PostGraduateCourseId);
            postGraduateCourseToBeUpdated = postGraduateCourse;
            instanceOfDbContext.PostGraduateCourse.Append(postGraduateCourseToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";
        }

        //To view post graduate courses based on the search criteria 
        public List<PostGraduateCourse> ViewPostGraduateCourseRepository(string searchKey)
        {
            //if the seach key is present the list is displayed
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
    }
}
