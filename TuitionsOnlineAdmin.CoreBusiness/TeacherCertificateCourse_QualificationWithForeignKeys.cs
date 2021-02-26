//Authors: SA, BM, SM,BA ,KK
//Date:26-Feb-2021
//Aim: defining the entity for TeacherCertificateCourse_QualificationWithForeignKeys 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherCertificateCourse_QualificationWithForeignKeys : TeacherCertificateCourse_Qualification
    { 
        //property to store TeacherName
        public string TeacherName { get; set; }
        //property to store CertificateCourseName
        public string CertificateCourseName { get; set; }
    }
}
