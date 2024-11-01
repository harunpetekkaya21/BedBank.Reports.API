﻿using Microsoft.AspNetCore.Identity;

namespace BedBankReports.API.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}