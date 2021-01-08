using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.CertificateCouses.CreateCertificateCourseScreen.Interface
{
  public  interface ICreateCertificateCourseUseCase
    {
        void CreateCertificateCourse(CertificateCourse certificateCourse);

    }
}
