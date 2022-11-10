using Mango.Web.Models;

namespace Mango.Web.Services.Interfaces
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responeModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
