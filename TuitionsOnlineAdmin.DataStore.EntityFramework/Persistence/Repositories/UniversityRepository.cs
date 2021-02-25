//Authors: SA, BM, SM,KK,BA
//Date:25-Jan-2021
//Aim: implementing the inteface IUniversityRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class UniversityRepository : IUniversityRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
    //constructor dependency injection
    public UniversityRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
    {
        this.instanceOfDbContext = instanceOfDbContext;
    }
    
        //To create a single record for University
        public string CreateUniversityRepository(University university)
        {
            try
            {
                instanceOfDbContext.University.Add(university);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_GRADE;
            }
        }

        //To update University
        public string UpdateUniversityRepository(University university)
        {
            try
            {
                University universityToBeUpdated = instanceOfDbContext.University.FirstOrDefault(s => s.UniversityId == university.UniversityId);
                universityToBeUpdated = university;
                instanceOfDbContext.University.Append(universityToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_GRADE;
            }

        }
        //To view University based on the search criteria 
        public List<University> ViewUniversityRepository(string searchKey)
        {
            try
            {
                if (searchKey != null)
                {
                    List<University> universityList = new List<University>();
                    universityList = instanceOfDbContext.University.Where(s => s.UniversityName.Contains(searchKey)).ToList();
                    return universityList;
                }
                //if not entire list of data is displayed
                else

                {
                    var universityList = instanceOfDbContext.University.ToList();
                    return universityList;
                }
            }
            catch (Exception)
            {
                List<University> universityList = new List<University>();
                return universityList = null;

            }
            //if the seach key is present the list is displayed

        }
    }
}
