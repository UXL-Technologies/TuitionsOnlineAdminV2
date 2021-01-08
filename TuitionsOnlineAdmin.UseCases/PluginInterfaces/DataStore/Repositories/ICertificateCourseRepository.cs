using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ICertificateCourseRepository
    {
        void CreateCertificateCourseRepository(CertificateCourse certificateCourse);
    }
}
