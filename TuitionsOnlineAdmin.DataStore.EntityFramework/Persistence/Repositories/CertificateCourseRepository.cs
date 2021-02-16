//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: implementing the inteface ICertificateCourseRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class CertificateCourseRepository : ICertificateCourseRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public CertificateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }
        //To create a single record for CertificateCourse
        public string CreateCertificateCourseRepository(CertificateCourse certificateCourse)
        {
           
            try
            {
                instanceOfDbContext.CertificateCourse.Add(certificateCourse);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_CERTIFICATECOURSE;

            }
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To view Certificate Courses based on the search criteria 
        public List<CertificateCourse> ViewCertificateCourseRepository(string searchKey)
        {
            try {
                if (searchKey != null)
                {
                    List<CertificateCourse> certificateCourseList = new List<CertificateCourse>();
                    certificateCourseList = instanceOfDbContext.CertificateCourse.Where(s => s.CertificateCourseName.Contains(searchKey)).ToList();
                    return certificateCourseList;
                }
                //if not entire list of data is displayed
                else

                {
                    var certificateCourseList = instanceOfDbContext.CertificateCourse.ToList();
                    return certificateCourseList;
                }
            }
            catch (Exception) {
                List<CertificateCourse> certificateCourseList = new List<CertificateCourse>();
                return certificateCourseList = null;

            }
            //if the seach key is present the list is displayed


        }
        //To update CertificateCourse
        public string UpdateCertificateCourseRepository(CertificateCourse certificateCourse)
        {
            try {
                CertificateCourse certificateCourseToBeUpdated = instanceOfDbContext.CertificateCourse.FirstOrDefault(s => s.CertificateCourseId == certificateCourse.CertificateCourseId);
                certificateCourseToBeUpdated = certificateCourse;
                instanceOfDbContext.CertificateCourse.Append(certificateCourseToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_CERTIFICATECOURSE;
            }
          

        }
    }
}
