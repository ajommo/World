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

        public Bundle()
        {
        }

        public Bundle(BundleEntity bundle)
        {
            id = bundle.Id;
            name = bundle.Name;
            version = bundle.Version;
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
    }
}
