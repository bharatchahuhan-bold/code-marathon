using CodeMarathon.ResumeBuilder.DTOs.Authentication;
using System.Threading.Tasks;

namespace CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.Authentication
{
    public interface IAuthenticationService
    {
        Task<string> SignInWithLinkedIn(AuthenticationRequest authRequest);
    }
}
