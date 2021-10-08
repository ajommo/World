using System;
using System.Runtime.Serialization;

namespace Game.World.Models
{
    public class Vector
    {
        private float x;
        private float y;
        private float z;

        public Vector()
        {
        }

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(byte[] bytes)
        {
            x = BitConverter.ToSingle(bytes, 0);
            y = BitConverter.ToSingle(bytes, 4);
            z = BitConverter.ToSingle(bytes, 8);
        }

        [DataMember(Name = "x", Order = 0)]
        public float X
        {
            get => x;
            set => x = value;
        }

        [DataMember(Name = "y", Order = 1)]
        public float Y
        {
            get => y;
            set => y = value;
        }

        [DataMember(Name = "z", Order = 2)]
        public float Z
        {
            get => z;
            set => z = value;
        }

        public byte[] Serialise()
        {
            var bytes = new byte[12];
            Buffer.BlockCopy(new float[] { x, y, z }, 0, bytes, 0, 12);
            return bytes;
        }
    }
}
