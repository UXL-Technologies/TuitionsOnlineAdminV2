//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:15-Jan-2021
//Aim:  Interface to declare UpdateCertificateCourse ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.CertificateCourses.UpdateCertificateCourseScreen.Interface
{
  public  interface IUpdateCertificateCourseUseCase
    {
        //Declaring a method to update the certificate course
        string UpdateCertificateCourse(CertificateCourse certificateCourse);
    }
}
