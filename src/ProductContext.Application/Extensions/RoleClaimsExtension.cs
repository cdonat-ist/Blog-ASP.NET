﻿using ProductContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProductContext.Application.Extensions
{
    public static class RoleClaimsExtension
    {
        public static IEnumerable<Claim> GetClaims(this User user)
        {
            var result = new List<Claim>
            {
                new(ClaimTypes.Email, user.Email),
                new("user", user.Id.ToString())
            };

            result.AddRange(user.Roles.Select(role => new Claim(ClaimTypes.Role, role.Title)));

            return result;
        }
    }
}
