//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace Identity.Service.Application
//{
//    public class InMemoryRoleRepository : IRepository<IdentityRole, string>
//    {
//        private ICollection<IdentityRole> _roles;

//        public InMemoryRoleRepository(IConfiguration configuration)
//        {
//            this._roles = configuration.GetSection("Role").Get<List<IdentityRole>>();
//        }

//        public IdentityRole Add(IdentityRole entity)
//        {
//            var role = FindByKey(entity.Id);
//            if (role == null)
//                this._roles.Add(entity);
//            return role;
//        }

//        public ICollection<IdentityRole> All()
//        {
//            return this._roles.ToList();
//        }

//        public IdentityRole FindByKey(string key)
//        {
//            return this._roles.Where(u => u.Id == key).FirstOrDefault();
//        }

//        public ICollection<IdentityRole> Query(Func<IdentityRole, bool> predicate)
//        {
//            return this._roles.Where(predicate).ToList();
//        }

//        public IdentityRole Remove(IdentityRole entity)
//        {
//            var role = FindByKey(entity.Id);
//            if (role != null)
//                this._roles.Remove(entity);
//            return role;
//        }

//        public IdentityRole Update(IdentityRole entity)
//        {
//            var role = FindByKey(entity.Id);
//            if (role != null)
//                role = entity;
//            return role;
//        }
//    }
//}
