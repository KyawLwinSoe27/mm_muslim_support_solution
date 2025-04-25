using BaseLibrary.DTOs;
using BaseLibrary.Responses;

namespace ServerLibrary.Repositories.Contracts;

public interface IUserAccount
{
    Task<GeneralResponse> CreateAccount(Register user);
    Task<LoginResponse> Login(Login user);
}