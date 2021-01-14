//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the Repository for Doctorate course



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class DoctorateCourseRepository : IDoctorateCourseRepository
    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        public DoctorateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;

        }

        //To create a single record for DoctorateCourse
        public void CreateDoctorateCourseRepository(DoctorateCourse doctorateCourse )
        {
            instanceOfDbContext.DoctorateCourse.Add(doctorateCourse);
            instanceOfDbContext.SaveChanges();
        }


        //Authors: SA, BM, SM
        // Date:14-Jan-2021
        //To view DoctorateCourse based on the search criteria 
        //To update doctorate course
        public string UpdateDoctorateCourseRepository(DoctorateCourse doctorateCourse)
        {
            DoctorateCourse doctorateCourseToBeUpdated = instanceOfDbContext.DoctorateCourse.FirstOrDefault(s => s.DoctorateCourseId == doctorateCourse.DoctorateCourseId);
            doctorateCourseToBeUpdated = doctorateCourse;
            instanceOfDbContext.DoctorateCourse.Append(doctorateCourseToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";

        }

        public List<DoctorateCourse> ViewDoctorateCourseRepository(string searchKey)
        {

            //if the seach key is present the list is displayed
            if (searchKey != null)
            {
                List<DoctorateCourse> doctorateCourseList = new List<DoctorateCourse>();
                doctorateCourseList = instanceOfDbContext.DoctorateCourse.Where(s => s.DoctorateCourseName.Contains(searchKey)).ToList();
                return doctorateCourseList;
            }
            //if not entire list of data is displayed
            else

            {
                var doctorateCourseList = instanceOfDbContext.DoctorateCourse.ToList();
                return doctorateCourseList;
            }
        }
    }

    
}
