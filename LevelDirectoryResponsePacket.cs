using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    public struct LevelDirectoryResponsePacket : IPacket
    {
        public List<string> LocalPaths;

        public void Deserialize(NetIncomingMessage im)
        {
            LocalPaths = new List<string>();

            int count = im.ReadInt32();

            for(int i = 0; i < count; i++)
            {
                LocalPaths.Add(im.ReadString());
            }
        }

        public void Serialize(NetOutgoingMessage om)
        {
            if(LocalPaths == null)
            {
                om.Write(0);
                return;
            }

            om.Write(LocalPaths.Count);
            foreach(string s in LocalPaths)
            {
                om.Write(s);
            }
        }
    }
}
