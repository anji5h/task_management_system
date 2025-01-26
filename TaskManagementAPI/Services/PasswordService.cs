using Microsoft.AspNetCore.Identity;

namespace TaskManagementAPI.Services
{
    class PasswordService<TUser> : IPasswordService<TUser> where TUser : class
    {
        private readonly IPasswordHasher<TUser> _passwordHasher;

        public PasswordService(IPasswordHasher<TUser> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }
        public string hashPassword(TUser user, string password)
        {
            return _passwordHasher.HashPassword(user, password);
        }

        public bool validatePassword(TUser user, string password, string hashedPassword)
        {
            var result = _passwordHasher.VerifyHashedPassword(user, hashedPassword, password);

            if (result == PasswordVerificationResult.Success)
            {
                return true;
            }

            return false;
        }
    }
}