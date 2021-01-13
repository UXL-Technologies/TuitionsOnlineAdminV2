﻿//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the unitOfWork


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories;
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

        private readonly ICurrencyRepository currencyRepository;

        private readonly ISubjectRepository subjectRepository;

        private readonly IGradeRepository gradeRepository;

        private readonly ITeacherVideoRepository teacherVideoRepository;

        private readonly IHighSchoolBoardRepository highSchoolBoardRepository;

        private readonly ITeacherBasicInformationRepository teacherBasicInformationRepository;

        public UnitOfWork(IGraduateCourseRepository graduateCourseRepository, IPostGraduateCourseRepository postGraduateCourseRepository, IDoctorateCourseRepository doctorateCourseRepository, ICertificateCourseRepository certificateCourseRepository,
            ICityRepository cityRepository, ICurrencyRepository currencyRepository, ISubjectRepository subjectRepository, IGradeRepository gradeRepository, ITeacherVideoRepository teacherVideoRepository, IHighSchoolBoardRepository highSchoolBoardRepository,
            ITeacherBasicInformationRepository teacherBasicInformationRepository)
        {
            this.instanceOfIGraduateCourseRepository = graduateCourseRepository;
            this.postGraduateCourseRepository = postGraduateCourseRepository;
            this.doctorateCourseRepository = doctorateCourseRepository;
            this.certificateCourseRepository = certificateCourseRepository;
            this.cityRepository = cityRepository;
            this.currencyRepository = currencyRepository;
            this.subjectRepository = subjectRepository;
            this.gradeRepository = gradeRepository;
            this.teacherVideoRepository = teacherVideoRepository;
            this.highSchoolBoardRepository = highSchoolBoardRepository;
            this.teacherBasicInformationRepository = teacherBasicInformationRepository;
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

        public void CreateCurrency(Currency currency)
        {
            throw new NotImplementedException();
        }

        public void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
        {
            throw new NotImplementedException();
        }

        public void CreateTeacherVideo(TeacherVideo teacherVideo)
        {
            throw new NotImplementedException();
        }

        public void CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard)
        {
            throw new NotImplementedException();
        }

        public void CreateSubject(Subject subject)
        {
            throw new NotImplementedException();
        }

        public void CreateGrade(Grade grade)
        {
            throw new NotImplementedException();
        }
    }
}
