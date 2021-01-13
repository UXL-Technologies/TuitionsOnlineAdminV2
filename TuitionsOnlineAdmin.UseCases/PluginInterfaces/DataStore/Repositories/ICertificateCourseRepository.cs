
//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the pluginInterface  Repository  for CertificateCourse ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ICertificateCourseRepository
    {
        //To hold the contract for creating the CertificateCourse and store it in a database
        void CreateCertificateCourseRepository(CertificateCourse certificateCourse);
    }
}
