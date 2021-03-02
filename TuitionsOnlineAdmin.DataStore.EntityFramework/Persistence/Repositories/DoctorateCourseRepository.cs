//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
// Date:08-Jan-2021
//Aim: implementing the inteface IDoctorateCourseRepository



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
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public DoctorateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;

        }

        //To create a single record for DoctorateCourse
        public string CreateDoctorateCourseRepository(DoctorateCourse doctorateCourse )
        {
            try
            {
                instanceOfDbContext.DoctorateCourse.Add(doctorateCourse);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_DOCTORATECOURSE;

            }
        }


        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        // Date:14-Jan-2021
        //To update doctorate course
        public string UpdateDoctorateCourseRepository(DoctorateCourse doctorateCourse)
        {
            try {
                DoctorateCourse doctorateCourseToBeUpdated = instanceOfDbContext.DoctorateCourse.FirstOrDefault(s => s.DoctorateCourseId == doctorateCourse.DoctorateCourseId);
                doctorateCourseToBeUpdated = doctorateCourse;
                instanceOfDbContext.DoctorateCourse.Append(doctorateCourseToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_DOCTORATECOURSE;
            }
         

        }

        //To view DoctorateCourse based on the search criteria 
        public List<DoctorateCourse> ViewDoctorateCourseRepository(string searchKey)
        {
            try {
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
            catch (Exception) {
                List<DoctorateCourse> doctorateCourseList = new List<DoctorateCourse>();
                return doctorateCourseList = null;

            }
            //if the seach key is present the list is displayed

        }
    }

    
}
