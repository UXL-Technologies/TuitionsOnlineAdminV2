//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: implementing the inteface ITeacherBasicInformationRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherBasicInformationRepository : ITeacherBasicInformationRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public TeacherBasicInformationRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {

            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for TeacherBasicInformation

        public void CreateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation)
        {
            instanceOfDbContext.TeacherBasicInformation.Add(teacherBasicInformation);
            instanceOfDbContext.SaveChanges();
        }

        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //To view TeacherBasicInformation based on the search criteria 
        public List<TeacherBasicInformation> ViewTeacherBasicInformationRepository(string searchKey)
        {

            //if the seach key is present the list is displayed
            if (searchKey != null)
            {
                List<TeacherBasicInformation> teacherBasicInformationList = new List<TeacherBasicInformation>();
                teacherBasicInformationList = instanceOfDbContext.TeacherBasicInformation.Where(s => s.TeacherFullName.Contains(searchKey)).ToList();
                return teacherBasicInformationList;
            }
            //if not entire list of data is displayed
            else

            {
                var teacherBasicInformationList = instanceOfDbContext.TeacherBasicInformation.ToList();
                return teacherBasicInformationList;
            }
        }

        //To update TeacherBasicInformation
        public string UpdateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation)
        {
            TeacherBasicInformation teacherBasicInformationToBeUpdated = instanceOfDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherBasicInformation.TeacherId);
            teacherBasicInformationToBeUpdated = teacherBasicInformation;
            instanceOfDbContext.TeacherBasicInformation.Append(teacherBasicInformationToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";

        }
    }
}
