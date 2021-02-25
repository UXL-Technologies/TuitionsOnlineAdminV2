//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: implementing the inteface IHighSchoolBoardRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class HighSchoolBoardRepository : IHighSchoolBoardRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public HighSchoolBoardRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for HighSchoolBoard
        public string CreateHighSchoolBoardRepository(HighSchoolBoard highSchoolBoard)
        {
            Console.WriteLine(highSchoolBoard);
            try {
                Console.WriteLine(highSchoolBoard);
                instanceOfDbContext.HighSchoolBoard.Add(highSchoolBoard);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception) {
                Console.WriteLine(highSchoolBoard);
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_HIGHSCHOOLBOARD;
            }
        }


        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //To view HighSchoolBoard based on the search criteria 
        public List<HighSchoolBoard> ViewHighSchoolBoardRepository(string searchKey)
        {
            Console.WriteLine(searchKey);
            try {
                if (searchKey != null)
                {
                    Console.WriteLine(searchKey);
                    List<HighSchoolBoard> highSchoolBoardList = new List<HighSchoolBoard>();
                    highSchoolBoardList = instanceOfDbContext.HighSchoolBoard.Where(s => s.HighSchoolBoardName.Contains(searchKey)).ToList();
                    return highSchoolBoardList;
                }
                //if not entire list of data is displayed
                else

                {
                    var highSchoolBoardList = instanceOfDbContext.HighSchoolBoard.ToList();
                    return highSchoolBoardList;
                }
            }
            catch (Exception) {
                List<HighSchoolBoard> highSchoolBoardList = new List<HighSchoolBoard>();
                return highSchoolBoardList = null;

            }
            //if the seach key is present the list is displayed

        }

        //To update HighSchoolBoard
        public string UpdateHighSchoolBoardRepository(HighSchoolBoard highSchoolBoard)
        {
            try {
                HighSchoolBoard highSchoolBoardToBeUpdated = instanceOfDbContext.HighSchoolBoard.FirstOrDefault(s => s.HighSchoolBoardId == highSchoolBoard.HighSchoolBoardId);
                highSchoolBoardToBeUpdated = highSchoolBoard;
                instanceOfDbContext.HighSchoolBoard.Append(highSchoolBoardToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_HIGHSCHOOLBOARD;
            }

        }
    }
}
