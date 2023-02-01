using RestfulAPI.Models;
using RestfulAPI.Repository;

namespace RestfulAPI.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _genericRepository;

        public PostManager(IGenericRepository<Posts> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Posts Create(Posts post)
        {
            throw new System.NotImplementedException();
        }
    }
}
