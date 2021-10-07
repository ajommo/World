using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using Game.Database.Models;

namespace Game.World.Models
{
    [DataContract]
    public class Bundle
    {
        private string id;
        private string name;
        private int version;
        private List<string> assets;

        public Bundle()
        {
        }

        public Bundle(BundleEntity bundle, IQueryable<AssetEntity> assets)
        {
            id = bundle.Id;
            name = bundle.Name;
            version = bundle.Version;
            this.assets = assets.Where(c => c.Bundle == bundle.Id && c.Active).Select(c => c.Id).ToList();
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

        [DataMember(Name = "assets", Order = 3)]
        public List<string> Assets
        {
            get => assets;
            set => assets = value;
        }
    }
}
