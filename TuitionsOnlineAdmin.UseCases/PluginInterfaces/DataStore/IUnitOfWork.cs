using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore
{
    public interface IUnitOfWork
    {
        void CreateGraduateCourse(GraduateCourse graduateCourse);
        void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse);
        void CreateDoctorateCourse(DoctorateCourse doctorateCourse);
        void CreateCertificateCourse(CertificateCourse certificateCourse);

    }
}
