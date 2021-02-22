//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the unitOfWork


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
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
       
        private readonly ITeacherBasicInformationRepository diITeacherBasicInformationRepository;

        private readonly ITeacherGraduateCourse_QualificationRepository diITeacherGraduateCourse_QualificationRepository;

        public UnitOfWork(IGraduateCourseRepository instanceOfIGraduateCourseRepository, IPostGraduateCourseRepository instanceOfIPostGraduateCourseRepository, IDoctorateCourseRepository instanceOfIDoctorateCourseRepository,
            ICertificateCourseRepository instanceOfICertificateCourseRepository, ICityRepository instanceOfICityRepository, 
            ICurrencyRepository instanceOfICurrencyRepository, ISubjectRepository instanceOfISubjectRepository, IGradeRepository instanceOfIGradeRepository,
            ITeacherVideoRepository instanceOfITeacherVideoRepository, IHighSchoolBoardRepository instanceOfIHighSchoolBoardRepository,
            ITeacherBasicInformationRepository diITeacherBasicInformationRepository, ITeacherGraduateCourse_QualificationRepository diITeacherGraduateCourse_QualificationRepository)
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
            this.diITeacherBasicInformationRepository = diITeacherBasicInformationRepository;
            this.diITeacherGraduateCourse_QualificationRepository = diITeacherGraduateCourse_QualificationRepository;

        }
        //to create a DoctorateCourse  by invoking CreateDoctorateCourseRepository of DoctorateCourseRepository
        public string CreateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
           string result = instanceOfIDoctorateCourseRepository.CreateDoctorateCourseRepository(doctorateCourse);
            return result;
        }
        //Authors: SA, BM, SM
        // Date:14-Jan-2021
        //to view a DoctorateCourse  by invoking ViewDoctorateCourseRepository of DoctorateCourseRepository
        public List<DoctorateCourse> ViewDoctorateCourses(string searchKey)
        {
            var doctorateCourseList = instanceOfIDoctorateCourseRepository.ViewDoctorateCourseRepository(searchKey);
            return doctorateCourseList;
        }
        //to update a DoctorateCourse  by invoking UpdateDoctorateCourseRepository of DoctorateCourseRepository
        public string UpdateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            string result = instanceOfIDoctorateCourseRepository.UpdateDoctorateCourseRepository(doctorateCourse);
            return result;

           
        }

        //to create a GraduateCourse  by invoking CreateGraduateCourseRepository of GraduateCourseRepository
        public string CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            String result = instanceOfIGraduateCourseRepository.CreateGraduateCourseRepository(graduateCourse);
            return result;
        }
        //to view a GraduateCourse  by invoking ViewGraduateCourseRepository of GraduateCourseRepository
        public List<GraduateCourse> ViewGraduateCourses(string searchKey)
        {
            var graduateCourseList = instanceOfIGraduateCourseRepository.ViewGraduateCourseRepository(searchKey);
            return graduateCourseList;
        }

        //to update a GraduateCourse  by invoking UpdateGraduateCourseRepository of GraduateCourseRepository
        public string UpdateGraduateCourse(GraduateCourse graduateCourse)
        {
            instanceOfIGraduateCourseRepository.UpdateGraduateCourseRepository(graduateCourse);
            return "done";
        }

        //to create a PostGraduateCourse by invoking CreatePostGraduateRepository of PostGraduateRepository
        public string CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            string result = instanceOfIPostGraduateCourseRepository.CreatePostGraduateRepository(postGraduateCourse);
            return result;
        }
        //Authors: SA, BM, SM
        // Date:14-Jan-2021
        //to view a PostGraduateCourse by invoking ViewPostGraduateCourseRepository of PostGraduateCourseRepository
        public List<PostGraduateCourse> ViewPostGraduateCourses(string searchKey)
        {
            var postGraduateCourseList = instanceOfIPostGraduateCourseRepository.ViewPostGraduateCourseRepository(searchKey);
            return postGraduateCourseList;
        }
        //Authors: SA, BM, SM
        // Date:14-Jan-2021
        //to update a PostGraduateCourse by invoking UpdatePostGraduateCourseRepository of PostGraduateCourseRepository
        public string UpdatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            instanceOfIPostGraduateCourseRepository.UpdatePostGraduateCourseRepository(postGraduateCourse);
            return "done";
        }

        //to create a CertificateCourse by invoking CreateCertificateCourseRepository of CertificateCourseRepository
        public string CreateCertificateCourse(CertificateCourse certificateCourse)
        {
           string result =  instanceOfICertificateCourseRepository.CreateCertificateCourseRepository(certificateCourse);
            return result;
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //to view a CertificateCourse  by invoking ViewCertificateCourseRepository of CertificateCourseRepository
        public List<CertificateCourse> ViewCertificateCourses(string searchKey)
        {
            var certificateCourseList = instanceOfICertificateCourseRepository.ViewCertificateCourseRepository(searchKey);
            return certificateCourseList;
        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //to update a CertificateCourse by invoking UpdateCertificateCourseRepository of CertificateCourseRepository
        public string UpdateCertificateCourse(CertificateCourse certificateCourse)
        {
            instanceOfICertificateCourseRepository.UpdateCertificateCourseRepository(certificateCourse);
            return "done";
        }

        //to create a City by invoking CreateCityRepository of CityRepository
        public string CreateCity(City city)
        {
           string result =  instanceOfICityRepository.CreateCityRepository(city);
            return result;
        }
        //to view a City by invoking ViewCityRepository of CityRepository
        public List<City> ViewCities(string searchKey)
        {
            var cityList = instanceOfICityRepository.ViewCityRepository(searchKey);
            return cityList;
        }
        //to update a City by invoking UpdateCityRepository of CityRepository
        public string UpdateCity(City city)
        {
            instanceOfICityRepository.UpdateCityRepository(city);
            return "done";
        }



        //to Create a Currency by invoking CreateCurrencyRepository of CurrencyRepository
        public string CreateCurrency(Currency currency)
        {
           string result =  instanceOfICurrencyRepository.CreateCurrencyRepository(currency);
            return result;
        }
        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //to view a Currency by invoking ViewCurrencyRepository of CurrencyRepository
        public List<Currency> ViewCurrencies(string searchKey)
        {
            var currencyList = instanceOfICurrencyRepository.ViewCurrencyRepository(searchKey);
            return currencyList;
        }
        //to update a Currency by invoking UpdateCurrencyRepository of CurrencyRepository
        public string UpdateCurrency(Currency currency)
        {
            instanceOfICurrencyRepository.UpdateCurrencyRepository(currency);
            return "done";
        }


        //to Create a Subject by invoking CreateSubjectRepository of SubjectRepository
        public string CreateSubject(Subject subject)
        {
            string result = instanceOfISubjectRepository.CreateSubjectRepository(subject);
            return result;

        }
        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //to view a Subject by invoking ViewSubjectRepository of SubjectRepository
        public List<Subject> ViewSubjects(string searchKey)
        {
            var subjectList = instanceOfISubjectRepository.ViewSubjectRepository(searchKey);
            return subjectList;
        }
        //to update a Subject by invoking UpdateSubjectRepository of SubjectRepository
        public string UpdateSubject(Subject subject)
        {
            instanceOfISubjectRepository.UpdateSubjectRepository(subject);
            return "done";
        }
        //to create a Grade  by invoking CreateGradeRepository of GradeRepository
        public string CreateGrade(Grade grade)
        {
            string result = instanceOfIGradeRepository.CreateGradeRepository(grade);
            return result;
        }

        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //to view a Grade by invoking ViewGradeRepository of GradeRepository
        public List<Grade> ViewGrades(string searchKey)
        {
            var gradeList = instanceOfIGradeRepository.ViewGradeRepository(searchKey);
            return gradeList;
        }
        //to update a Grade  by invoking UpdateGradeRepository of GradeRepository
        public string UpdateGrade(Grade grade)
        {
            instanceOfIGradeRepository.UpdateGradeRepository(grade);
            return "done";
        }
        //to create a teacher video  by invoking CreateTeacherVideorepository of TeacherVideoRepository
        public string CreateTeacherVideo(TeacherVideo teacherVideo)
        {
            string result = instanceOfITeacherVideoRepository.CreateTeacherVideoRepository(teacherVideo);
            return result;
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


        //to create a HighSchoolBoard by invoking CreateHighSchoolBoardrepository of HighSchoolBoardRepository
        public string CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard)
        {
            string result = instanceOfIHighSchoolBoardRepository.CreateHighSchoolBoardRepository(highSchoolBoard);
            return result;
        }
        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //to view a HighSchoolBoard  by invoking ViewHighSchoolBoardrepository of HighSchoolBoardRepository
        public List<HighSchoolBoard> ViewHighSchoolBoards(string searchKey)
        {
            var highSchoolBoardList = instanceOfIHighSchoolBoardRepository.ViewHighSchoolBoardRepository(searchKey);
            return highSchoolBoardList;
        }
        //to update a highSchoolBoard by invoking updateHighSchoolBoardrepository of HighSchoolBoardRepository
        public string UpdateHighSchoolBoard(HighSchoolBoard highSchoolBoard)
        {
            instanceOfIHighSchoolBoardRepository.UpdateHighSchoolBoardRepository(highSchoolBoard);
            return "done";
        }

        //to create a TeacherBasicInformation by invoking CreateTeacherBasicInformationrepository of TeacherBasicInformationRepository
        public string CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
        {
          string result =  diITeacherBasicInformationRepository.CreateTeacherBasicInformationRepository(teacherBasicInformation);
            return result;

            }
            //Author: GJ, TP, VM, SN
            //Date: 16/02/2021
            //commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution
            /*public void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
            {
                teacherBasicInformationRepository.CreateTeacherBasicInformationRepository(teacherBasicInformation);

            } */

        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //to view a TeacherBasicInformation  by invoking ViewTeacherBasicInformationrepository of TeacherBasicInformationRepository
        public List<TeacherBasicInformation> ViewTeacherBasicInformation(string searchTeacherKeyword)
        {
            Console.WriteLine(searchTeacherKeyword);
            var teacherBasicInformationList = diITeacherBasicInformationRepository.ViewTeacherBasicInformationRepository(searchTeacherKeyword);
            return teacherBasicInformationList;
        }

        //to update a TeacherBasicInformation by invoking updateTeacherBasicInformationrepository of TeacherBasicInformationRepository
        public string UpdateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation)
        {
            diITeacherBasicInformationRepository.UpdateTeacherBasicInformationRepository(teacherBasicInformation);
            return "done";
        }


        //Authors: SA, BM, SM, BA, KK
        // Date:22-Feb-2021

        //Aim : The ViewTeacherGraduateCourseQualification method is responsible to view the teacher graduate course qualification details for the teacherId. 
        public List<TeacherGraduateCourse_Qualification> ViewTeacherGraduateCourseQualification(int teacherId)
        {
            var teacherGraduateCourseQualificationList = diITeacherGraduateCourse_QualificationRepository.ViewGraduateCourseQualificationRepository(teacherId);
            Console.WriteLine(teacherGraduateCourseQualificationList);
            return teacherGraduateCourseQualificationList;
        }

        
        //Aim : The CreateTeacherGraduateCourseQualification method is responsible to view the teacher graduate course qualification.

       public string CreateTeacherGraduateCourseQualification(int teacherId, int selectedGraduateCourses)
        {
            var result = diITeacherGraduateCourse_QualificationRepository.CreateTeacherGraduateCourseQualification(teacherId, selectedGraduateCourses);
            //Console.WriteLine(teacherId);
            return result;
        }


        // Aim : The EditTeacherGraduateCourseQualification method is responsible to remove the teacher graduate course qualification.
        public string EditGraduateCourseQualification(List<TeacherGraduateCourse_Qualification> teacherGraduateCourseQualifications)
        {
            var result = diITeacherGraduateCourse_QualificationRepository.EditGraduateCourseQualification(teacherGraduateCourseQualifications);
            return result;
        }

    }
}
