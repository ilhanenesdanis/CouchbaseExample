using Couchbase.KeyValue;
using CouchbaseExample.Abstract;
using CouchbaseExample.Config;
using CouchbaseExample.Models;

namespace CouchbaseExample.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly ICouchbaseCollection _couchbase;

        public UserRepository(CouchbaseConfig config)
        {
            _couchbase = config.GetCollection("ApplicationData", "Users");
        }

        public async Task AddAsync(User user)
        {
            await _couchbase.InsertAsync(user.Id.ToString(), user);
        }

        public Task Delete(Guid userId)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
