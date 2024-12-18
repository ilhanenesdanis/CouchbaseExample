
using Couchbase;
using Couchbase.KeyValue;
using Microsoft.Extensions.Options;

namespace CouchbaseExample.Config
{
    public class CouchbaseConfig : IAsyncDisposable
    {
        private readonly ICluster _cluster;
        private readonly IBucket _bucket;
        private readonly IOptions<CouchbaseCredential> _credential;
        public CouchbaseConfig(IOptions<CouchbaseCredential> credential)
        {
            _credential = credential;

            _cluster = Cluster.ConnectAsync(connectionString: _credential.Value.ConnectionString, _credential.Value.UserName, _credential.Value.Password).Result;
            _bucket = _cluster.BucketAsync(_credential.Value.BucketName).Result;


        }
        public async ValueTask DisposeAsync()
        {
            await _cluster.DisposeAsync();
        }
        public ICouchbaseCollection GetCollection()
        {
            return _bucket.DefaultCollection();
        }
        
    }
}
