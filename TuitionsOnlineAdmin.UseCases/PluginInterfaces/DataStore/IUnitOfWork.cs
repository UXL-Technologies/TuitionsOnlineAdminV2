﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the pluginInterface  UnitOfWork

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore
{
    public interface IUnitOfWork
    {
        //To add the single record of the GraduateCourse to the database
        string CreateGraduateCourse(GraduateCourse graduateCourse);
        //To view graduate courses
        List<GraduateCourse> ViewGraduateCourses(string searchKey);
        //To update GraduateCourse
        string UpdateGraduateCourse(GraduateCourse graduateCourse);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:14-Jan-2021
        //To update post Graduate courses

        //To add the single record of the PostGraduateCourse to the database
        string CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse);
       

        //To view post Graduate courses
        List<PostGraduateCourse> ViewPostGraduateCourses(string searchKey);
        //To update post Graduate courses
        string UpdatePostGraduateCourse(PostGraduateCourse postGraduateCourse);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:14-Jan-2021
        //Aim: To create , view ,update DoctorateCourseUsecase ;

        //To add the single record of the DoctorateCourse to the database
        string CreateDoctorateCourse(DoctorateCourse doctorateCourse);
        //To view Doctorate courses
        List<DoctorateCourse> ViewDoctorateCourses(string searchKey);
        //To update doctorate course
        string UpdateDoctorateCourse(DoctorateCourse doctorateCourse);


        //To add the single record of the CertificateCourse to the database
        string CreateCertificateCourse(CertificateCourse certificateCourse);
        
        //Date:15-Jan-2021
        //To view CertificateCourses
        List<CertificateCourse> ViewCertificateCourses(string searchKey);
        //To update CertificateCourse
        string UpdateCertificateCourse(CertificateCourse certificateCourse);


        //To add the single record of the City to the database
        string CreateCity(City city);
        //To view Cities
        List<City> ViewCities(string searchKey);
        //To update City
        string UpdateCity(City city);

       


        //To add the single record of the Currency to the database
        string CreateCurrency(Currency currency);
        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:18-Jan-2021
        //To view Currencies
        List<Currency> ViewCurrencies(string searchKey);
        //To update Currency
        string UpdateCurrency(Currency currency);



        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:18-Jan-2021
        //To Create TeacherBasicInformation
        string CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation);
        //To view TeacherBasicInformation
        List<TeacherBasicInformation> ViewTeacherBasicInformation(string searchTeacherKeyword);
        //To update TeacherBasicInformation
        string UpdateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:15-Jan-2021
        //To Create TeacherVideo
        string CreateTeacherVideo(TeacherVideo teacherVideo);
        //To view TeacherVideo
        List<TeacherVideo> ViewTeacherVideos(string searchKey);
        //To update TeacherVideo
        string UpdateTeacherVideo(TeacherVideo teacherVideo);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:18-Jan-2021
        //To Create HighSchoolBoard
        string CreateHighSchoolBoard(HighSchoolBoard HighSchoolBoard);
        //To view HighSchoolBoard
        List<HighSchoolBoard> ViewHighSchoolBoards(string searchKey);
        //To update HighSchoolBoard
        string UpdateHighSchoolBoard(HighSchoolBoard HighSchoolBoard);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:15-Jan-2021
        //To Create Subject
        string CreateSubject(Subject subject);
        //To view Subject
        List<Subject> ViewSubjects(string searchKey);
        //To update Subject
        string UpdateSubject(Subject subject);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:15-Jan-2021
        //To Create Grade
        string CreateGrade(Grade grade);
        //To view Grade
        List<Grade> ViewGrades(string searchKey);
        //To update Grade
        string UpdateGrade(Grade grade);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga, BA, KK
        //Date:19-Feb-2021
        //To view TeacherGraduateCourse_Qualification
        public List<TeacherGraduateCourse_QualificationWithForeignKeys> ViewTeacherGraduateCourseQualification(int teacherId);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga, BA, KK
        //Date:22-Feb-2021
        //To create and edit TeacherGraduateCourse_Qualification

        //Aim : The method is responsible to hold the contract for creating the graduate course qualification.
        public string CreateTeacherGraduateCourseQualification(int teacherId, int selectedGraduateCourses);

        //Aim : The method is responsible to hold the contract for editing the graduate course qualification.
        public string EditGraduateCourseQualification(List<TeacherGraduateCourse_QualificationWithForeignKeys> teacherGraduateCourseQualifications);



        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga, BA, KK
        //Date:23-Feb-2021
        //To View ,create and edit TeacherPostGraduateCourse_Qualification

        //To view TeacherPostGraduateCourse_Qualification
        public List<TeacherPostGraduateCourse_QualificationWithForeignKeys> ViewTeacherPostGraduateCourseQualification(int teacherId);

        //Aim : The method is responsible to hold the contract for creating the Postgraduate course qualification.
        public string CreateTeacherPostGraduateCourseQualification(int teacherId, int selectedPostGraduateCourses);

        //Aim : The method is responsible to hold the contract for editing the Postgraduate course qualification.
        public string EditTeacherPostGraduateCourseQualification(List<TeacherPostGraduateCourse_QualificationWithForeignKeys> teacherPostGraduateCourseQualifications);


        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga, BA, KK
        //Date:24-Feb-2021
        //To View ,create and edit TeacherDoctorateCourse_Qualification

        //To view TeacherDoctorateCourse_Qualification
        public List<TeacherDoctorateCourse_QualificationWithForeignKeys> ViewTeacherDoctorateCourseQualification(int teacherId);

        //Aim : The method is responsible to hold the contract for creating the Doctorate course qualification.
        public string CreateTeacherDoctorateCourseQualification(int teacherId, int selectedDoctorateCourses);

        //Aim : The method is responsible to hold the contract for editing the Doctorate course qualification.
        public string EditTeacherDoctorateCourseQualification(List<TeacherDoctorateCourse_QualificationWithForeignKeys> teacherDoctorateCourseQualifications);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga, BA, KK
        //Date:24-Feb-2021
        //To View ,create and edit TeacherCertificateCourse_Qualification

        //To view TeacherCertificateCourse_Qualification
        public List<TeacherCertificateCourse_QualificationWithForeignKeys> ViewTeacherCertificateCourseQualification(int teacherId);

        //Aim : The method is responsible to hold the contract for creating the Certificate course qualification.
        public string CreateTeacherCertificateCourseQualification(int teacherId, int selectedCertificateCourses);

        //Aim : The method is responsible to hold the contract for editing the Certificate course qualification.
        public string EditTeacherCertificateCourseQualification(List<TeacherCertificateCourse_QualificationWithForeignKeys> teacherCertificateCourseQualifications);



        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga, BA, KK
        //Date:25-Feb-2021
        //To View ,create and edit TeacherHighSchoolBoard

        //To view TeacherHighSchoolBoard
        public List<TeacherHighSchoolBoardWithForeignKeys> ViewTeacherHighSchoolBoard(int teacherId);

        //Aim : The method is responsible to hold the contract for creating the HighSchoolBoard.
        public string CreateTeacherHighSchoolBoard(int teacherId, int selectedHighSchoolBoards);

        //Aim : The method is responsible to hold the contract for editing the HighSchoolBoard.
        public string EditTeacherHighSchoolBoard(List<TeacherHighSchoolBoardWithForeignKeys> teacherHighSchoolBoards);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga, BA, KK
        //Date:25-Feb-2021
        //To View ,create and edit University

        //Aim : The method is responsible to hold the contract for creating the University.
        string CreateUniversity(University university);

        //To update University
        string UpdateUniversity(University university);
        //To view University
        List<University> ViewUniversities(string searchKey);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga, BA, KK
        //Date:25-Feb-2021
        //To View ,create and edit University

        //To view TeacherUniversity
        public List<TeacherUniversityWithForeignKeys> ViewTeacherUniversity(int teacherId);

        //Aim : The method is responsible to hold the contract for creating the University.
        public string CreateTeacherUniversity(int teacherId, int selectedUniversities);

        //Aim : The method is responsible to hold the contract for editing the University.
        public string EditTeacherUniversity(List<TeacherUniversityWithForeignKeys> teacherUniversities);


        //To View Teacher Graduate Course Qualification Subject
        public List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys> ViewTeacherGraduateCourseQualificationSubject(int teacherId, int graduateCourseId);

    }
}
