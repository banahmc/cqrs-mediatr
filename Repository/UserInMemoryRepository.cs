using CQRSMediatR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRSMediatR.Repository
{
    public class UserInMemoryRepository : IBaseRepository<UserEntity>
    {
        private static readonly ICollection<UserEntity> _users = new List<UserEntity>(UserSeed.Generate());

        public IEnumerable<UserEntity> FindAll() => _users.Select(u => u);

        public UserEntity FindOne(Guid id) => _users.FirstOrDefault(u => u.Id == id);

        public UserEntity Insert(UserEntity entity)
        {
            _users.Add(entity);

            return entity;
        }

        public UserEntity Update(UserEntity entity)
        {
            var existingUser = FindOne(entity.Id);

            existingUser.FirstName = entity.FirstName;
            existingUser.LastName = entity.LastName;
            existingUser.Email = entity.Email;

            return existingUser;
        }

        public void Delete(UserEntity entity)
        {
            _users.Remove(entity);
        }
    }

    public static class UserSeed
    {
        public static IEnumerable<UserEntity> Generate()
        {
            return new List<UserEntity>
            {
                new UserEntity
                {
                    Id = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"),
                    UserName = "Johny",
                    FirstName = "John",
                    LastName = "Tester",
                    Email = "john@tester.com"
                }
            };
        }
    }
}
