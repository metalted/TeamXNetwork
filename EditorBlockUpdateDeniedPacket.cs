using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet sent by the server to deny a block update in the editor.
    /// </summary>
    public struct EditorBlockUpdateDeniedPacket : IPacket
    {
        /// <summary>
        /// The serialized string representation of the block data that was denied for update.
        /// </summary>
        public string BlockString;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            BlockString = im.ReadString();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(BlockString);
        }
    }
}
