using System;

using Microsoft.AspNetCore.Mvc;

using Game.Database;
using Game.World.Models;
using Game.Database.Models;

namespace Game.World.Controllers
{
    [Route("api")]
    [ApiController]
    public class InstancesController : ControllerBase
    {
        private readonly DatabaseContext database;

        public InstancesController(DatabaseContext database)
        {
            this.database = database;
        }

        [HttpGet]
        [Route("instances/{id}")]
        public Instance GetAsset(Guid id)
        {
            return new Instance(database.GetInstance(id));
        }

        [HttpPost]
        [Route("instances")]
        public Instance PostAsset([FromBody]Instance instance)
        {
            var entity = new InstanceEntity();
            entity.Id = Guid.NewGuid();
            entity.Description = instance.Description;
            entity.Asset = instance.Asset;
            entity.Scale = instance.Scale.Serialise();
            entity.Rotation = instance.Rotation.Serialise();
            entity.Translation = instance.Translation.Serialise();
            database.Instances.Add(entity);
            database.SaveChanges();
            return null;
        }
    }
}
