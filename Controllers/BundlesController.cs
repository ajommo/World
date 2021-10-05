using Microsoft.AspNetCore.Mvc;

using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Game.Database;
using Game.World.Models;

namespace Game.World.Controllers
{
    [Route("api")]
    [ApiController]
    public class BundlesController : ControllerBase
    {
        private readonly DatabaseContext database;

        public BundlesController(DatabaseContext database)
        {
            this.database = database;
        }

        [HttpGet]
        [Route("bundles")]
        public IEnumerable<Bundle> GetBundles()
        {
            return database.GetBundles().Select(b => new Bundle(b));
        }

        [HttpGet]
        [Route("bundles/{id}")]
        public Bundle GetBundle(string id)
        {
            return new Bundle(database.GetBundle(id));
        }

        [HttpGet]
        [Route("bundles/{id}/binary")]
        public async Task<ActionResult> GetBundleFile(string id)
        {
            var bytes = await System.IO.File.ReadAllBytesAsync(@"C:\Game\Game.Bundles\" + id);
            return File(bytes, "application/octet-stream", Path.GetFileName("primitives"));
        }
    }
}
