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
        //Authors: SA, BM, SM
        // Date:14-Jan-2021
        //To View DoctorateCourse
        public List<DoctorateCourse> ViewDoctorateCourses(string searchKey)
        {
            var doctorateCourseList = instanceOfIDoctorateCourseRepository.ViewDoctorateCourseRepository(searchKey);
            return doctorateCourseList;
        }
        //To update DoctorateCourse
        public string UpdateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            instanceOfIDoctorateCourseRepository.UpdateDoctorateCourseRepository(doctorateCourse);
            return "done";
        }
        //To Create GraduateCourse
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

        //to create postgraduate course
        public void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            instanceOfIPostGraduateCourseRepository.CreatePostGraduateRepository(postGraduateCourse);
        }
        //Authors: SA, BM, SM
        // Date:14-Jan-2021
        //creating view postgraduate course in unitofwork
        public List<PostGraduateCourse> ViewPostGraduateCourses(string searchKey)
        {
            var postGraduateCourseList = instanceOfIPostGraduateCourseRepository.ViewPostGraduateCourseRepository(searchKey);
            return postGraduateCourseList;
        }
        //Authors: SA, BM, SM
        // Date:14-Jan-2021
        //To updatePostGraduateCourse
        public string UpdatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            instanceOfIPostGraduateCourseRepository.UpdatePostGraduateCourseRepository(postGraduateCourse);
            return "done";
        }

        //to create CertificateCourse
        public void CreateCertificateCourse(CertificateCourse certificateCourse)
        {
            instanceOfICertificateCourseRepository.CreateCertificateCourseRepository(certificateCourse);
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //creating view CertificateCourse in unitofwork
        public List<CertificateCourse> ViewCertificateCourses(string searchKey)
        {
            var certificateCourseList = instanceOfICertificateCourseRepository.ViewCertificateCourseRepository(searchKey);
            return certificateCourseList;
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To update CertificateCourse
        public string UpdateCertificateCourse(CertificateCourse certificateCourse)
        {
            instanceOfICertificateCourseRepository.UpdateCertificateCourseRepository(certificateCourse);
            return "done";
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
        //To Create subject 
        public void CreateSubject(Subject subject)
        {
            instanceOfISubjectRepository.CreateSubjectRepository(subject);
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To View Subject
        public List<Subject> ViewSubjects(string searchKey)
        {
            var subjectList = instanceOfISubjectRepository.ViewSubjectRepository(searchKey);
            return subjectList;
        }
        //To update Subject
        public string UpdateSubject(Subject subject)
        {
            instanceOfISubjectRepository.UpdateSubjectRepository(subject);
            return "done";
        }
        //to create grade
        public void CreateGrade(Grade grade)
        {
            instanceOfIGradeRepository.CreateGradeRepository(grade);
        }

        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To View Grade
        public List<Grade> ViewGrades(string searchKey)
        {
            var gradeList = instanceOfIGradeRepository.ViewGradeRepository(searchKey);
            return gradeList;
        }
        //To update Grade
        public string UpdateGrade(Grade grade)
        {
            instanceOfIGradeRepository.UpdateGradeRepository(grade);
            return "done";
        }
        //to create a teacher video  by invoking CreateTeacherVideorepository of TeacherVideoRepository
        public void CreateTeacherVideo(TeacherVideo teacherVideo)
        {
            instanceOfITeacherVideoRepository.CreateTeacherVideoRepository(teacherVideo);
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //to view a teacher video  by invoking ViewTeacherVideorepository of TeacherVideoRepository
        public List<TeacherVideo> ViewTeacherVideos(string searchKey)
        {
            var teacherVideoList = instanceOfITeacherVideoRepository.ViewTeacherVideoRepository(searchKey);
            return teacherVideoList;
        }
        //to update a teacher video  by invoking updateTeacherVideorepository of TeacherVideoRepository
        public string UpdateTeacherVideo(TeacherVideo teacherVideo)
        {
            instanceOfITeacherVideoRepository.UpdateTeacherVideoRepository(teacherVideo);
            return "done";
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
