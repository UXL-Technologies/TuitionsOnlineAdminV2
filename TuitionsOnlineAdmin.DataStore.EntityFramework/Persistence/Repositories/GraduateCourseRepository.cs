//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: implementing the inteface IGraduateCourseRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class GraduateCourseRepository : IGraduateCourseRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;

        
        //constructor dependency injection
        public GraduateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }

        public string CreateGraduateCourseRepository(GraduateCourse graduateCourse)
        {
            instanceOfDbContext.GraduateCourse.Add(graduateCourse);
            instanceOfDbContext.SaveChanges();

            try
            {
                instanceOfDbContext.GraduateCourse.Add(graduateCourse);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception ex)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_GRADUATECOURSE + " ,the error number is 101";

            }
        }

        //To create a single record for GraduateCourse


        //Authors: SA, BM, SM
        // Date:14-Jan-2021
        //To Update a record for GraduateCourse
        public string UpdateGraduateCourseRepository(GraduateCourse graduateCourse)
        {
            GraduateCourse graduateCourseToBeUpdated = instanceOfDbContext.GraduateCourse.FirstOrDefault(s => s.GraduateCourseId == graduateCourse.GraduateCourseId);
            graduateCourseToBeUpdated = graduateCourse;
            instanceOfDbContext.GraduateCourse.Append(graduateCourseToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";
        }

        //To view graduate courses based on the search criteria 
        public List<GraduateCourse> ViewGraduateCourseRepository(string searchKey)
        {

            //if the seach key is present the list is displayed
            if (searchKey != null)
            {
                List<GraduateCourse> graduateCourseList = new List<GraduateCourse>();
                graduateCourseList = instanceOfDbContext.GraduateCourse.Where(s => s.GraduateCourseName.Contains(searchKey)).ToList();
                return graduateCourseList;
            }
            //if not entire list of data is displayed
            else
            
            {
                var graduateCourseList = instanceOfDbContext.GraduateCourse.ToList();
                return graduateCourseList;
            }
        }

       
    }
}
