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

        public UnitOfWork(IGraduateCourseRepository graduateCourseRepository, IPostGraduateCourseRepository postGraduateCourseRepository, IDoctorateCourseRepository doctorateCourseRepository)
        {
            this.graduateCourseRepository = graduateCourseRepository;
            this.postGraduateCourseRepository = postGraduateCourseRepository;
            this.doctorateCourseRepository = doctorateCourseRepository;

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
    }
}
