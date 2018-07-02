using System.Collections.Generic;
using System.Data.Entity;

namespace WebApplicationShoppingCart.Models
{
    public class UserDatabaseInitializer : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            GetUsers().ForEach(c => context.Categories.Add(c));

        }
        private static List<User> GetUsers()
        {

            var userSeed = new List<User> {
                new User
                {
                    UserID = 1,
                    UserName = "TestUser1",
                    Password = "cars2019"
                },
                new User
                {
                    UserID = 2,
                    UserName = "TestUser2",
                    Password = "Planes"
                }
            };

            return userSeed;
        }

    }
}