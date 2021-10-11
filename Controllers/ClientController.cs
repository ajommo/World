using Microsoft.AspNetCore.Mvc;

using Game.Database;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Game.World.Controllers
{
    [Route("api")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DatabaseContext database;
        private readonly IConfiguration configuration;

        public ClientController(DatabaseContext database, IConfiguration configuration)
        {
            this.database = database;
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("client")]
        public async Task<ActionResult> GetClient()
        {
            var bytes = await System.IO.File.ReadAllBytesAsync(configuration["Client"]);
            return File(bytes, "application/octet-stream");
        }
    }
}
