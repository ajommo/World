using System.Runtime.Serialization;

using Game.Database.Models;

namespace Game.World.Models
{
    [DataContract]
    public class Asset
    {
        private string id;
        private string name;
        private int version;
        private string prefab;
        private string bundle;

        public Asset()
        {
        }

        public Asset(AssetEntity asset)
        {
            id = asset.Id;
            name = asset.Name;
            version = asset.Version;
            prefab = asset.Prefab;
            bundle = asset.Bundle;
        }

        [DataMember(Name = "id", Order = 0)]
        public string Id
        {
            get => id;
            set => id = value;
        }

        [DataMember(Name = "name", Order = 1)]
        public string Name
        {
            get => name;
            set => name = value;
        }

        [DataMember(Name = "version", Order = 2)]
        public int Version
        {
            get => version;
            set => version = value;
        }

        [DataMember(Name = "prefab", Order = 3)]
        public string Prefab
        {
            get => prefab;
            set => prefab = value;
        }

        [DataMember(Name = "bundle", Order = 4)]
        public string Bundle
        {
            get => bundle;
            set => bundle = value;
        }
    }
}
