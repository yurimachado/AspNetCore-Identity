using System.Threading.Tasks;

namespace Identity.Service.Application.Services.Email
{
    public interface IEmailContentProvider<T>
    {
        Task<string> GetEmailContentAsync(T notification);
    }
}
