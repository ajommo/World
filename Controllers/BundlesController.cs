using Microsoft.AspNetCore.Mvc;

using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Game.Database;
using Game.World.Models;
using Microsoft.Extensions.Configuration;

namespace Game.World.Controllers
{
    [Route("api")]
    [ApiController]
    public class BundlesController : ControllerBase
    {
        private readonly DatabaseContext database;
        private readonly IConfiguration configuration;

        public BundlesController(DatabaseContext database, IConfiguration configuration)
        {
            this.database = database;
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("bundles")]
        public IEnumerable<Bundle> GetBundles()
        {
            return database.GetBundles().Select(b => new Bundle(b, database.Assets));
        }

        [HttpGet]
        [Route("bundles/{id}")]
        public Bundle GetBundle(string id)
        {
            return new Bundle(database.GetBundle(id), database.Assets);
        }

        [HttpGet]
        [Route("bundles/{id}/binary")]
        public async Task<ActionResult> GetBundleFile(string id)
        {
            var bundle = database.GetBundle(id);
            var bytes = await System.IO.File.ReadAllBytesAsync(configuration["Bundles"] + id);
            return File(bytes, "application/octet-stream", id + "." + bundle.Version);
        }
    }
}
