//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the unitOfWork


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
        private readonly IGraduateCourseRepository  instanceOfIGraduateCourseRepository;

        private readonly IPostGraduateCourseRepository postGraduateCourseRepository;

        private readonly IDoctorateCourseRepository doctorateCourseRepository;

        private readonly ICertificateCourseRepository certificateCourseRepository;

        private readonly ICityRepository cityRepository;


        public UnitOfWork(IGraduateCourseRepository graduateCourseRepository, IPostGraduateCourseRepository postGraduateCourseRepository, IDoctorateCourseRepository doctorateCourseRepository, ICertificateCourseRepository certificateCourseRepository , ICityRepository cityRepository)
        {
            this.instanceOfIGraduateCourseRepository = graduateCourseRepository;
            this.postGraduateCourseRepository = postGraduateCourseRepository;
            this.doctorateCourseRepository = doctorateCourseRepository;
            this.certificateCourseRepository = certificateCourseRepository;
            this.cityRepository = cityRepository;

        }

        public void CreateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            doctorateCourseRepository.CreateDoctorateCourseRepository(doctorateCourse);
        }

        public void CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            instanceOfIGraduateCourseRepository.CreateGraduateCourseRepository(graduateCourse);


        }

        public void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            postGraduateCourseRepository.CreatePostGraduateRepository(postGraduateCourse);
        }

        public void CreateCertificateCourse(CertificateCourse certificateCourse)
        {
            certificateCourseRepository.CreateCertificateCourseRepository(certificateCourse);
        }

        public void CreateCity(City city)
        {
           cityRepository.CreateCityRepository(city);
        }

        public List<GraduateCourse> ViewGraduateCourses(string searchKey)
        {
            var graduateCourseList = instanceOfIGraduateCourseRepository.ViewGraduateCourseRepository(searchKey);
            return graduateCourseList;
        }
    }
}
