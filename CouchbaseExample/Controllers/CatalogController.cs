using CouchbaseExample.Config;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CouchbaseExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class CatalogController : ControllerBase
    {
        private readonly CouchbaseConfig _couchbaseConfig;

        public CatalogController(CouchbaseConfig couchbaseConfig)
        {
            _couchbaseConfig = couchbaseConfig;
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewCatalog(string catalogName)
        {
            //var collection = _couchbaseConfig.GetCollection();
            //await collection.UpsertAsync($"catalog::{Guid.NewGuid()}", catalogName);
            return Ok("Catalog Created");
        }
    }
}
