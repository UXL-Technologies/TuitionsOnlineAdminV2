//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim: defining the entity for TeacherCertificateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherCertificateCourse_Qualification
    {
        //property to store TeacherId
        public int TeacherId { get; set; }
        //property to store CertificateCourseId
        public int CertificateCourseId { get; set; }
        //property to store TeacherCertificateCourse_QualificationId
        public int TeacherCertificateCourse_QualificationId { get; set; }

    }
}
