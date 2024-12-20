using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet sent by the server to deny a skybox update in the editor.
    /// </summary>
    public struct EditorSkyboxDeniedPacket : IPacket
    {
        /// <summary>
        /// The ID of the skybox that was denied for update.
        /// </summary>
        public int Skybox;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            Skybox = im.ReadInt32();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(Skybox);
        }
    }
}
