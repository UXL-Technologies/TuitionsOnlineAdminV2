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

        private readonly IPostGraduateCourseRepository instanceOfIPostGraduateCourseRepository;

        private readonly IDoctorateCourseRepository instanceOfIDoctorateCourseRepository;

        private readonly ICertificateCourseRepository instanceOfICertificateCourseRepository;

        private readonly ICityRepository instanceOfICityRepository;

        private readonly ICurrencyRepository instanceOfICurrencyRepository;

        private readonly ISubjectRepository instanceOfISubjectRepository;

        private readonly IGradeRepository instanceOfIGradeRepository;

        private readonly ITeacherVideoRepository instanceOfITeacherVideoRepository;

        private readonly IHighSchoolBoardRepository instanceOfIHighSchoolBoardRepository;

        private readonly ITeacherBasicInformationRepository instanceOfITeacherBasicInformationRepository;


        public UnitOfWork(IGraduateCourseRepository instanceOfIGraduateCourseRepository, IPostGraduateCourseRepository instanceOfIPostGraduateCourseRepository, IDoctorateCourseRepository instanceOfIDoctorateCourseRepository,
            ICertificateCourseRepository instanceOfICertificateCourseRepository, ICityRepository instanceOfICityRepository, 
            ICurrencyRepository instanceOfICurrencyRepository, ISubjectRepository instanceOfISubjectRepository, IGradeRepository instanceOfIGradeRepository,
            ITeacherVideoRepository instanceOfITeacherVideoRepository, IHighSchoolBoardRepository instanceOfIHighSchoolBoardRepository,
            ITeacherBasicInformationRepository instanceOfITeacherBasicInformationRepository)
        {
            this.instanceOfIGraduateCourseRepository = instanceOfIGraduateCourseRepository;
            this.instanceOfIPostGraduateCourseRepository = instanceOfIPostGraduateCourseRepository;
            this.instanceOfIDoctorateCourseRepository = instanceOfIDoctorateCourseRepository;
            this.instanceOfICertificateCourseRepository = instanceOfICertificateCourseRepository;
            this.instanceOfICityRepository = instanceOfICityRepository;
            this.instanceOfICurrencyRepository = instanceOfICurrencyRepository;
            this.instanceOfISubjectRepository = instanceOfISubjectRepository;
            this.instanceOfIGradeRepository = instanceOfIGradeRepository;
            this.instanceOfITeacherVideoRepository = instanceOfITeacherVideoRepository;
            this.instanceOfIHighSchoolBoardRepository = instanceOfIHighSchoolBoardRepository;
            this.instanceOfITeacherBasicInformationRepository = instanceOfITeacherBasicInformationRepository;

        }

        public void CreateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            instanceOfIDoctorateCourseRepository.CreateDoctorateCourseRepository(doctorateCourse);
        }

        public void CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            instanceOfIGraduateCourseRepository.CreateGraduateCourseRepository(graduateCourse);
        }


        //To updateGraduateCourse
        public string UpdateGraduateCourse(GraduateCourse graduateCourse)
        {
            instanceOfIGraduateCourseRepository.UpdateGraduateCourseRepository(graduateCourse);
            return "done";

        }

        public void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            instanceOfIPostGraduateCourseRepository.CreatePostGraduateRepository(postGraduateCourse);
        }
        //creating view postgraduate course in unitofwork
        public List<PostGraduateCourse> ViewPostGraduateCourses(string searchKey)
        {
            var postGraduateCourseList = instanceOfIPostGraduateCourseRepository.ViewPostGraduateCourseRepository(searchKey);
            return postGraduateCourseList;
        }

        public void CreateCertificateCourse(CertificateCourse certificateCourse)
        {
            instanceOfICertificateCourseRepository.CreateCertificateCourseRepository(certificateCourse);
        }

        public void CreateCity(City city)
        {
            instanceOfICityRepository.CreateCityRepository(city);
        }

        public List<GraduateCourse> ViewGraduateCourses(string searchKey)
        {
            var graduateCourseList = instanceOfIGraduateCourseRepository.ViewGraduateCourseRepository(searchKey);
            return graduateCourseList;
        }

        public void CreateCurrency(Currency currency)
        {
            instanceOfICurrencyRepository.CreateCurrencyRepository(currency);
        }

        public void CreateSubject(Subject subject)
        {
            instanceOfISubjectRepository.CreateSubjectRepository(subject);
        }
        public void CreateGrade(Grade grade)
        {
            instanceOfIGradeRepository.CreateGradeRepository(grade);
        }

        public void CreateTeacherVideo(TeacherVideo teacherVideo)
        {
            instanceOfITeacherVideoRepository.CreateTeacherVideoRepository(teacherVideo);
        }

        public void CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard)
        {
            instanceOfIHighSchoolBoardRepository.CreateHighSchoolBoardRepository(highSchoolBoard);

        }

        public void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
        {
            instanceOfITeacherBasicInformationRepository.CreateTeacherBasicInformationRepository(teacherBasicInformation);

        }
    }
}
