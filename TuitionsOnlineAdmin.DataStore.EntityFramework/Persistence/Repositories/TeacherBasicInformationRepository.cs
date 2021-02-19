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
    //Author: GJ, TP, VM, SN
    //Date: 16/02/2021
    //commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution
    
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

        public string CreateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation)
        {
            try {
                instanceOfDbContext.TeacherBasicInformation.Add(teacherBasicInformation);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_TEACHERBASICINFORMATION;
            }
          
        }

        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //To view TeacherBasicInformation based on the search criteria 
        public List<TeacherBasicInformation> ViewTeacherBasicInformationRepository(string searchTeacherKeyword)
        {
            try {
                if (searchTeacherKeyword != null)
                {
                    List<TeacherBasicInformation> teacherBasicInformationList = new List<TeacherBasicInformation>();
                    teacherBasicInformationList = instanceOfDbContext.TeacherBasicInformation.Where(s => s.Teacher_Name.Contains(searchTeacherKeyword)).ToList();
                    return teacherBasicInformationList;
                }
                //if not entire list of data is displayed
                else

                {
                    var teacherBasicInformationList = instanceOfDbContext.TeacherBasicInformation.ToList();
                    return teacherBasicInformationList;
                }
            }
            catch (Exception) {
                List<TeacherBasicInformation> teacherBasicInformationList = new List<TeacherBasicInformation>();
                return teacherBasicInformationList = null;
            }
            //if the seach key is present the list is displayed

        }

        //To update TeacherBasicInformation
        public string UpdateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation)
        {
            try {
                TeacherBasicInformation teacherBasicInformationToBeUpdated = instanceOfDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherBasicInformation.TeacherId);
                teacherBasicInformationToBeUpdated = teacherBasicInformation;
                instanceOfDbContext.TeacherBasicInformation.Append(teacherBasicInformationToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_TEACHERBASICINFORMATION;
            }

        }
    } 
}
