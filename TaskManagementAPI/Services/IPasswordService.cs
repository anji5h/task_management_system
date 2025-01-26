namespace TaskManagementAPI.Services
{
    public interface IPasswordService<TUser>
    {
        string hashPassword(TUser user, string password);

        bool validatePassword(TUser user, string password, string hashedPassword);
    }
}