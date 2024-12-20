using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a handshake request packet sent during connection initialization.
    /// </summary>
    public struct HandshakeRequestPacket : IPacket
    {
        /// <summary>
        /// The handshake message content.
        /// </summary>
        public string Message;

        /// <summary>
        /// Deserializes the packet from a <see cref="NetIncomingMessage"/>.
        /// </summary>
        /// <param name="im">The incoming message.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            Message = im.ReadString();
        }

        /// <summary>
        /// Serializes the packet into a <see cref="NetOutgoingMessage"/>.
        /// </summary>
        /// <param name="om">The outgoing message.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(Message);
        }
    }
}
