using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IGraduateCourseRepository  graduateCourseRepository;

        private readonly IPostGraduateCourseRepository postGraduateCourseRepository;

        private readonly IDoctorateCourseRepository doctorateCourseRepository;

        private readonly ICertificateCourseRepository certificateCourseRepository;

        public UnitOfWork(IGraduateCourseRepository graduateCourseRepository, IPostGraduateCourseRepository postGraduateCourseRepository, IDoctorateCourseRepository doctorateCourseRepository, ICertificateCourseRepository certificateCourseRepository)
        {
            this.graduateCourseRepository = graduateCourseRepository;
            this.postGraduateCourseRepository = postGraduateCourseRepository;
            this.doctorateCourseRepository = doctorateCourseRepository;
            this.certificateCourseRepository = certificateCourseRepository;

        }

        public void CreateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            doctorateCourseRepository.CreateDoctorateCourseRepository(doctorateCourse);
        }

        public void CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            graduateCourseRepository.CreateGraduateCourseRepository(graduateCourse);


        }

        public void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            postGraduateCourseRepository.CreatePostGraduateRepository(postGraduateCourse);
        }

        public void CreateCertificateCourse(CertificateCourse certificateCourse)
        {
            certificateCourseRepository.CreateCertificateCourseRepository(certificateCourse);
        }
    }
}
