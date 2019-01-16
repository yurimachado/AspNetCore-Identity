//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Identity.Service.Application
//{
//    public class InMemoryUserRepository : IRepository<ApplicationUser, string>
//    {
//        private ICollection<ApplicationUser> _users;

//        public InMemoryUserRepository(IConfiguration configuration)
//        {
//            this._users = configuration.GetSection("Users").Get<List<ApplicationUser>>();
//        }

//        public ApplicationUser Add(ApplicationUser entity)
//        {
//            var user = FindByKey(entity.Id);
//            if (user == null)
//                this._users.Add(entity);
//            return user;
//        }

//        public ICollection<ApplicationUser> All()
//        {
//            return this._users.ToList();
//        }

//        public ApplicationUser FindByKey(string key)
//        {
//            return this._users.Where(u => u.Id == key).FirstOrDefault();
//        }

//        public ICollection<ApplicationUser> Query(Func<ApplicationUser, bool> predicate)
//        {
//            return this._users.Where(predicate).ToList();
//        }

//        public ApplicationUser Remove(ApplicationUser entity)
//        {
//            var user = FindByKey(entity.Id);
//            if (user != null)
//                this._users.Remove(entity);
//            return user;
//        }

//        public ApplicationUser Update(ApplicationUser entity)
//        {
//            var user = FindByKey(entity.Id);
//            if (user != null)
//                user = entity;
//            return user;
//        }
//    }
//}
