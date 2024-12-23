using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    public struct LoadLevelRequestPacket : IPacket
    {
        public ulong SteamID;
        public string LocalPath;

        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            LocalPath = im.ReadString();
        }

        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(LocalPath);
        }
    }
}
