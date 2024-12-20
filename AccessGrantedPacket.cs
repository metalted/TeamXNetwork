using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet sent from the server to the client to grant access and specify the user's permission level.
    /// </summary>
    public struct AccessGrantedPacket : IPacket
    {
        public string Message;

        public void Deserialize(NetIncomingMessage im)
        {
            Message = im.ReadString();
        }

        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(Message);
        }
    }
}
