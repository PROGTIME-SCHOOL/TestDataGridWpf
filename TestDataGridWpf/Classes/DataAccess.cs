using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestDataGridWpf.Models;

namespace TestDataGridWpf.Classes
{
    public static class DataAccess
    {
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User() { Id = 1, Name = "User 1", Pets = new List<Pet>() {
                    new Pet() { Id = 1, Name = "Dog"},
                    new Pet() { Id = 2, Name = "Cat"},
                    new Pet() { Id = 3, Name = "Dog 2"},
                } },
                new User() { Id = 2, Name = "User 2" , Pets = new List<Pet>() {
                    new Pet() { Id = 4, Name = "Parrot"},
                    new Pet() { Id = 5, Name = "Snake"},
                    new Pet() { Id = 6, Name = "Spider"},
                }},
                new User() { Id = 3, Name = "User 3"},
                new User() { Id = 4, Name = "User 4"},
                new User() { Id = 5, Name = "User 5"},
            };

            return users;
        }
    }
}
