using CodeMarathon.ResumeBuilder.DTOs.User;
using System.Threading.Tasks;

namespace CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.User
{
    public interface IUserService
    {
        Task<UserDetailsResponse> GetUserDetailsByLinkedInToken(string token);
    }
}
