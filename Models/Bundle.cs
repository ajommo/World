using System.Runtime.Serialization;

using Game.Database.Models;

namespace Game.World.Models
{
    [DataContract]
    public class Bundle
    {
        private string id;
        private string name;
        private string version;

        public Bundle()
        {
        }

        public Bundle(BundleEntity bundle)
        {
            id = bundle.Id;
            name = bundle.Name;
            version = bundle.Version;
        }

        [DataMember(Name = "id")]
        public string Id
        {
            get => id;
            set => id = value;
        }

        [DataMember(Name = "name")]
        public string Name
        {
            get => name;
            set => name = value;
        }

        [DataMember(Name = "version")]
        public string Version
        {
            get => version;
            set => version = value;
        }
    }
}
