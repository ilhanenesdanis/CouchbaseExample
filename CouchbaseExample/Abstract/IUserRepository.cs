using Couchbase.KeyValue;
using CouchbaseExample.Models;

namespace CouchbaseExample.Abstract
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task Delete(Guid userId);
        ICollection<User> GetAllUser();
      
    }
}
