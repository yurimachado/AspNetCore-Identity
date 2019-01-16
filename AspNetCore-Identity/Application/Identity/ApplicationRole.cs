using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Identity.Service.Application.Identity
{
    public class ApplicationRole
    {
        private readonly List<Claim> _claims;

        public ApplicationRole()
        {
            _claims = new List<Claim>();
        }


        public string Id { get; internal set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public IEnumerable<Claim> Claims
        {
            get => _claims;
            internal set
            {
                if (value != null) _claims.AddRange(value);
            }
        }

        internal void AddClaim(Claim claim)
        {
            if (claim == null)
            {
                throw new ArgumentNullException(nameof(claim));
            }

            _claims.Add(claim);
        }

        internal void RemoveClaim(Claim claim)
        {
            _claims.Remove(claim);
        }

        public static implicit operator ApplicationRole(string input) =>
            input == null ? null : new ApplicationRole { Name = input };
    }
}
