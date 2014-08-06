using SimpleApp.Data.Context;
using SimpleApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SimpleApp.Data.Initializer
{
    public class SimpleAppInitializer : DropCreateDatabaseIfModelChanges<SimpleAppDbContext>
    {
        protected override void Seed(SimpleAppDbContext context)
        {
            
            var testUsers = new List<TestUser> {
                new TestUser { FirstName="First Nmae", LastName = "Last Name", DateOfBirth = DateTime.Now.AddDays(-6500)}
            };

            testUsers.ForEach(user => context.TestUsers.Add(user));
        }
    }
}
