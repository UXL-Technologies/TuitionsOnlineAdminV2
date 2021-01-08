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

        public UnitOfWork(IGraduateCourseRepository graduateCourseRepository)
        {
            this.graduateCourseRepository = graduateCourseRepository;
        }

        public void CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            graduateCourseRepository.CreateGraduateCourseRepository(graduateCourse);


        }
    }
}
