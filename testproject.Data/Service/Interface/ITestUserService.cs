using SimpleApp.Data.Entities;
using System.Data;

namespace SimpleApp.Data.Service.Interface
{
    public interface ITestUserService
    {

        /// <summary>
        /// Method to get all test users
        /// </summary>
        /// <returns>Data table</returns>
        DataRow GetById(int Id);

        /// <summary>
        /// Service method to get all test users
        /// </summary>
        /// <returns>Data table</returns>
        DataTable GetAll();

        
        /// <summary>
        /// Service method to create new test user
        /// </summary>
        /// <param name="testUser">test User model</param>
        /// <returns>true or false</returns>
        bool Create(TestUser testUser);

        /// <summary>
        /// Method to update test user details
        /// </summary>
        /// <param name="testUser">test user</param>
        /// <returns></returns>
        bool Update(TestUser testUser);

        /// <summary>
        /// Method to delete a test user
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>true / false</returns>
        bool Delete(int id);   
    }
}
