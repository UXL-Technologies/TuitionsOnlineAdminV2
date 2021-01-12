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
        //To add the single record of the PostGraduateCourse to the database
        void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse);
        //To add the single record of the DoctorateCourse to the database
        void CreateDoctorateCourse(DoctorateCourse doctorateCourse);
        //To add the single record of the CertificateCourse to the database
        void CreateCertificateCourse(CertificateCourse certificateCourse);
        //To add the single record of the City to the database
        void CreateCity(City city);
        //To add the single record of the Currency to the database
        void CreateCurrency(Currency currency);
        //To add the single record of the Subject to the database
        void CreateSubject(Subject subject);
        //To add the single record of the Grade to the database
        void CreateGrade(Grade grade);
        //To add the single record of the TeacherVideo to the database
        void CreateTeacherVideo(TeacherVideo teacherVideo);
        //To add the single record of the HighSchoolBoard to the database
        void CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard);
        //To add the single record of the TeacherBasicInformation to the database
        void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation);
    }
}
