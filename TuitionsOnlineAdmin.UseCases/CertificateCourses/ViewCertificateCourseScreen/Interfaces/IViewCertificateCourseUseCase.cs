//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:15-Jan-2021
//Aim: defining the Interface for viewCertificateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.CertificateCourses.ViewCertificateCourseScreen.Interfaces
{
  public  interface IViewCertificateCourseUseCase
    {
        //Declaring a method to view the certificate course
        List<CertificateCourse> ViewCertificateCourse(string searchKey);
    }
}
