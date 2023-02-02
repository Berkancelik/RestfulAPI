using Microsoft.Extensions.Hosting;
using RestfulAPI.Models;
using RestfulAPI.Repository;
using System.Collections.Generic;

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
            return _genericRepository.Add(post);
        }

        public Posts DeleteProduct(int id)
        {
            var deletePost = _genericRepository.GetById(id);
            return _genericRepository.Delete(deletePost);
        }

        public List<Posts> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public Posts GetPost(int id)
        {
            return _genericRepository.GetById(id);
        }

        public Posts Update(int id, Posts post)
        {
            return _genericRepository.UpdateById(post, id);

        }
    }
}
