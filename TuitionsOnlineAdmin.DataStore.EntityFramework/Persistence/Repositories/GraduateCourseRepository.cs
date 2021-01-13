//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the Repository for Graduate course

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
       private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;


        public GraduateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
       {
            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for GraduateCourse
        public void CreateGraduateCourseRepository(GraduateCourse graduateCourse)
       {
            instanceOfDbContext.GraduateCourse.Add(graduateCourse);
            instanceOfDbContext.SaveChanges();
        }

        //To Update a record for GraduateCourse
        public string UpdateGraduateCourseRepository(GraduateCourse graduateCourse)
        {
            instanceOfDbContext.GraduateCourse.Add(graduateCourse);
            instanceOfDbContext.SaveChanges();
            return "done";
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
