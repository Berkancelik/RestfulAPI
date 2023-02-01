using RestfulAPI.Models;
using RestfulAPI.Repository;

namespace RestfulAPI.Service
{
    public interface IPostService
    {
        Posts Create(Posts post);

    }
}
