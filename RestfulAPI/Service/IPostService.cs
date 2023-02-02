using RestfulAPI.Models;
using RestfulAPI.Repository;
using System.Collections.Generic;

namespace RestfulAPI.Service
{
    public interface IPostService
    {
        Posts Create(Posts post);
        Posts Update(int id, Posts post);
        Posts GetPost(int id);
        Posts DeleteProduct(int id);
        List<Posts> GetAll();
        

    }
}
