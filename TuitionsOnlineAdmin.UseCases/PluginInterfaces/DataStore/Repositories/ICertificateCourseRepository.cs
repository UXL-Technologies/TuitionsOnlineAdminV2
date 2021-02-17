
//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the pluginInterface  Repository  for CertificateCourse ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ICertificateCourseRepository
    {
        //To hold the contract for creating the CertificateCourse and store it in a database
        string CreateCertificateCourseRepository(CertificateCourse certificateCourse);

        //Authors: SA, BM, SM
        //Date:15-Jan-2021
        //To hold the contract for viewing graduate course 
        List<CertificateCourse> ViewCertificateCourseRepository(string searchKey);

        //To hold the contract for updating CertificateCourse
        string UpdateCertificateCourseRepository(CertificateCourse certificateCourse);
    }
}
