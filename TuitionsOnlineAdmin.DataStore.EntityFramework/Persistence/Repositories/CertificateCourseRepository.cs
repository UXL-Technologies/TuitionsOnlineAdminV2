//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the Repository for Certificate course

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
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        public CertificateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }
        //To create a single record for CertificateCourse
        public void CreateCertificateCourseRepository(CertificateCourse certificateCourse)
        {
            instanceOfDbContext.CertificateCourse.Add(certificateCourse);
            instanceOfDbContext.SaveChanges();
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To view Certificate Courses based on the search criteria 
        public List<CertificateCourse> ViewCertificateCourseRepository(string searchKey)
        {
            //if the seach key is present the list is displayed
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
        //To update CertificateCourse
        public string UpdateCertificateCourseRepository(CertificateCourse certificateCourse)
        {
            CertificateCourse certificateCourseToBeUpdated = instanceOfDbContext.CertificateCourse.FirstOrDefault(s => s.CertificateCourseId == certificateCourse.CertificateCourseId);
            certificateCourseToBeUpdated = certificateCourse;
            instanceOfDbContext.CertificateCourse.Append(certificateCourseToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";

        }
    }
}
