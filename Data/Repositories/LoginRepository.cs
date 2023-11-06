using Contracts.DTOs;
using Entities.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class LoginRepository
    {
        protected readonly MotoTopContext _context;

        public LoginRepository(MotoTopContext context)
        {
            _context = context;
        }
        // devuelve el id correspondiente al user
        public async Task<int> LoginMobile(LoginRequestDto loginRequest)
        {
            var user = await _context.Set<User>().FirstOrDefaultAsync(u => u.Email.Equals(loginRequest.Email));
            if (user == null)
            {
                return 0;
            }
            else
            {
                var passwordHasher = new PasswordHasher<string>();
                var result = passwordHasher.VerifyHashedPassword(string.Empty, user.PasswordHash, loginRequest.Password);
                if (result == PasswordVerificationResult.Failed)
                {
                    return 0;
                }
                else
                {
                    var seller = await _context.Set<Seller>().FirstOrDefaultAsync(s => s.UserId.Equals(user.Id));
                    if (seller == null)
                    {
                        return 0;
                    }
                    else
                    {
                        return seller.Id;
                    }
                }
            }
        }
    }
}
