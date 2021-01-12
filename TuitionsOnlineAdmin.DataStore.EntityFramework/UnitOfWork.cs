//Authors: SA, BM, SM
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
        private readonly IGraduateCourseRepository graduateCourseRepository;

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
            this.graduateCourseRepository = graduateCourseRepository;
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

        public void CreateCity(City city)
        {
            cityRepository.CreateCityRepository(city);
        }

        public void CreateCurrency(Currency currency)
        {
            currencyRepository.CreateCurrencyRepository(currency);
        }

        public void CreateSubject(Subject subject)
        {
            subjectRepository.CreateSubjectRepository(subject);
        }
        public void CreateGrade(Grade grade)
        {
            gradeRepository.CreateGradeRepository(grade);
        }

        public void CreateTeacherVideo(TeacherVideo teacherVideo)
        {
            teacherVideoRepository.CreateTeacherVideoRepository(teacherVideo);
        }

        public void CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard)
        {
            highSchoolBoardRepository.CreateHighSchoolBoardRepository(highSchoolBoard);

        }

        public void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
        {
            teacherBasicInformationRepository.CreateTeacherBasicInformationRepository(teacherBasicInformation);

        }
    }
}


