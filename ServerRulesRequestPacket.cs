using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    public struct ServerRulesRequestPacket : IPacket
    {
        public ulong SteamID;

        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
        }

        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
        }
    }
}
