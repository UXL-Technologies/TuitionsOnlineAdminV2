//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the pluginInterface  UnitOfWork

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore
{
    public interface IUnitOfWork
    {
        //To add the single record of the GraduateCourse to the database
        void CreateGraduateCourse(GraduateCourse graduateCourse);

        //Authors: SA, BM, SM
        //Date:14-Jan-2021
        //To update post Graduate courses

        //To add the single record of the PostGraduateCourse to the database
        void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse);
        //To view post Graduate courses
        List<PostGraduateCourse> ViewPostGraduateCourses(string searchKey);
        //To update post Graduate courses
        string UpdatePostGraduateCourse(PostGraduateCourse postGraduateCourse);

        //Authors: SA, BM, SM
        //Date:14-Jan-2021
        //Aim: To create , view ,update DoctorateCourseUsecase ;

        //To add the single record of the DoctorateCourse to the database
        void CreateDoctorateCourse(DoctorateCourse doctorateCourse);
        //To view Doctorate courses
        List<DoctorateCourse> ViewDoctorateCourses(string searchKey);
        //To update doctorate course
        string UpdateDoctorateCourse(DoctorateCourse doctorateCourse);


        //To add the single record of the CertificateCourse to the database
        void CreateCertificateCourse(CertificateCourse certificateCourse);
        //Authors: SA, BM, SM
        //Date:15-Jan-2021
        //To view CertificateCourses
        List<CertificateCourse> ViewCertificateCourses(string searchKey);
        //To update CertificateCourse
        string UpdateCertificateCourse(CertificateCourse certificateCourse);


        //To add the single record of the City to the database
        void CreateCity(City city);

        //To view graduate courses
        List<GraduateCourse> ViewGraduateCourses(string searchKey);
        void CreateCurrency(Currency currency);
       void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation);

        //Authors: SA, BM, SM
        //Date:15-Jan-2021
        //To Create TeacherVideo
        void CreateTeacherVideo(TeacherVideo teacherVideo);
        //To view TeacherVideo
        List<TeacherVideo> ViewTeacherVideos(string searchKey);
        //To update TeacherVideo
        string UpdateTeacherVideo(TeacherVideo teacherVideo);


        void CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard);

        //Authors: SA, BM, SM
        //Date:15-Jan-2021
        //To Create Subject
        void CreateSubject(Subject subject);
        //To view Subject
        List<Subject> ViewSubjects(string searchKey);
        //To update Subject
        string UpdateSubject(Subject subject);

        //Authors: SA, BM, SM
        //Date:15-Jan-2021
        //To Create Grade
        void CreateGrade(Grade grade);
        //To view Grade
        List<Grade> ViewGrades(string searchKey);
        //To update Grade
        string UpdateGrade(Grade grade);


        string UpdateGraduateCourse(GraduateCourse graduateCourse);

        


    }
}
