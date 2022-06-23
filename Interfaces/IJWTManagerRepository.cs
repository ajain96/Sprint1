using E_Commerce.ViewModels;

namespace E_Commerce.Interfaces
{
    public interface IJWTMangerRepository
    {
        Tokens Authenicate(LoginViewModel users, bool IsRegister);
    }
}