//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:12-Jan-2021
//Aim: defining the pluginInterface  Repository  for TeacherBasicInformation;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    //Author: GJ, TP, VM, SN
    //Date: 16/02/2021
    //commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution
public interface ITeacherBasicInformationRepository
    {
       // To hold the contract for creating the TeacherBasicInformation and store it in a database
        string CreateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation);


        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:18-Jan-2021
        //To hold the contract for viewing TeacherBasicInformation
        List<TeacherBasicInformation> ViewTeacherBasicInformationRepository(string searchTeacherKeyword);

       // To hold the contract for updating TeacherBasicInformation
        string UpdateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation);
    }
}
