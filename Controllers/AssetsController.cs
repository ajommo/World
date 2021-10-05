using Microsoft.AspNetCore.Mvc;

using Game.Database;
using Game.World.Models;

namespace Game.World.Controllers
{
    [Route("api")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly DatabaseContext database;

        public AssetsController(DatabaseContext database)
        {
            this.database = database;
        }

        [HttpGet]
        [Route("assets/{id}")]
        public ActionResult<Asset> GetAsset(string id)
        {
            return new Asset(database.GetAsset(id));
        }
    }
}
