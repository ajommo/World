using System;
using System.Runtime.Serialization;

using Game.Database.Models;

namespace Game.World.Models
{
    [DataContract]
    public class Instance
    {
        private Guid id;
        private string description;
        private string asset;
        private Vector scale;
        private Vector rotation;
        private Vector translation;

        public Instance()
        {
        }

        public Instance(InstanceEntity entity)
        {
            id = entity.Id;
            description = entity.Description;
            asset = entity.Asset;
            scale = new Vector(entity.Scale);
            rotation = new Vector(entity.Rotation);
            translation = new Vector(entity.Translation);
        }

        [DataMember(Name = "id", Order = 0)]
        public Guid Id
        {
            get => id;
            set => id = value;
        }

        [DataMember(Name = "description", Order = 1)]
        public string Description
        {
            get => description;
            set => description = value;
        }

        [DataMember(Name = "asset", Order = 2)]
        public string Asset
        {
            get => asset;
            set => asset = value;
        }

        [DataMember(Name = "scale", Order = 3)]
        public Vector Scale
        {
            get => scale;
            set => scale = value;
        }

        [DataMember(Name = "rotation", Order = 4)]
        public Vector Rotation
        {
            get => rotation;
            set => rotation = value;
        }

        [DataMember(Name = "translation", Order = 5)]
        public Vector Translation
        {
            get => translation;
            set => translation = value;
        }
    }
}
