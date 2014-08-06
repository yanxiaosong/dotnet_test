

namespace SimpleApp.Data.Service
{
    using SimpleApp.Data.Context;
    using SimpleApp.Data.Entities;
    using SimpleApp.Data.Extension;
    using SimpleApp.Data.Service.Interface;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class TestUserService : ITestUserService
    {

        /// <summary>
        /// Service method to get user by Id
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>Data row</returns>
        public DataRow GetById(int id)
        {
            using (var context = new SimpleAppDbContext())
            {
                TestUser user = context.TestUsers
                    .Where(i => i.Id == id)
                    .SingleOrDefault();
                
                return user.ToDataRow<TestUser>();
            }
        }

        /// <summary>
        /// Service method to get all users
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAll()
        {
            using (var context = new SimpleAppDbContext())
            {
                IList<TestUser> users = context.TestUsers.ToList();

                return users.ToDataTable<TestUser>();
            }
        }

        
        /// <summary>
        /// Service method to create new user
        /// </summary>
        /// <param name="user">user model</param>
        /// <returns>true or false</returns>
        public bool Create(TestUser user)
        {
            using (var context = new SimpleAppDbContext())
            {
                context.TestUsers.Add(user);
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Service method to update user
        /// </summary>
        /// <param name="user">user</param>
        /// <returns>true / false</returns>
        public bool Update(TestUser user)
        {
            using (var context = new SimpleAppDbContext())
            {
                context.TestUsers.Attach(user);
                context.Entry(user).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Method to delete a user
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>true / false</returns>
        public bool Delete(int id)
        {
            using (var context = new SimpleAppDbContext())
            {
                var user = context.TestUsers.Find(id);
                context.TestUsers.Remove(user);
                return context.SaveChanges() > 0;
            }
        }
    }
}
