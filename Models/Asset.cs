using System.Runtime.Serialization;

using Game.Database.Models;

namespace Game.World.Models
{
    [DataContract]
    public class Asset
    {
        private string id;
        private string bundle;
        private string name;
        private string prefab;
        private string version;

        public Asset()
        {
        }

        public Asset(AssetEntity asset)
        {
            id = asset.Id;
            bundle = asset.Bundle;
            name = asset.Name;
            prefab = asset.Prefab;
            version = asset.Version;
        }

        [DataMember(Name = "id")]
        public string Id
        {
            get => id;
            set => id = value;
        }

        [DataMember(Name = "bundle")]
        public string Bundle
        {
            get => bundle;
            set => bundle = value;
        }

        [DataMember(Name = "name")]
        public string Name
        {
            get => name;
            set => name = value;
        }

        [DataMember(Name = "prefab")]
        public string Prefab
        {
            get => prefab;
            set => prefab = value;
        }

        [DataMember(Name = "version")]
        public string Version
        {
            get => version;
            set => version = value;
        }
    }
}
