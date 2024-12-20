using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    /// <summary>
    /// Represents a packet sent when a player joins the session, containing the player's information and customization details.
    /// </summary>
    public struct PlayerJoinPacket : IPacket
    {
        /// <summary>The player's SteamID.</summary>
        public ulong SteamID;

        /// <summary>The player's display name.</summary>
        public string Name;

        /// <summary>The ID of the Zeepkist (cart) the player is using.</summary>
        public int Zeepkist;

        /// <summary>The ID of the front wheels.</summary>
        public int FrontWheels;

        /// <summary>The ID of the rear wheels.</summary>
        public int RearWheels;

        /// <summary>The ID of the paraglider.</summary>
        public int Paraglider;

        /// <summary>The ID of the horn.</summary>
        public int Horn;

        /// <summary>The ID of the hat.</summary>
        public int Hat;

        /// <summary>The ID of the glasses.</summary>
        public int Glasses;

        /// <summary>The player's body color.</summary>
        public int Color_body;

        /// <summary>The player's left arm color.</summary>
        public int Color_leftArm;

        /// <summary>The player's right arm color.</summary>
        public int Color_rightArm;

        /// <summary>The player's left leg color.</summary>
        public int Color_leftLeg;

        /// <summary>The player's right leg color.</summary>
        public int Color_rightLeg;

        /// <summary>The player's overall color.</summary>
        public int Color;

        /// <summary>
        /// Deserializes the packet data from the incoming message.
        /// </summary>
        /// <param name="im">The incoming message containing serialized data.</param>
        public void Deserialize(NetIncomingMessage im)
        {
            SteamID = im.ReadUInt64();
            Name = im.ReadString();
            Zeepkist = im.ReadInt32();
            FrontWheels = im.ReadInt32();
            RearWheels = im.ReadInt32();
            Paraglider = im.ReadInt32();
            Horn = im.ReadInt32();
            Hat = im.ReadInt32();
            Glasses = im.ReadInt32();
            Color_body = im.ReadInt32();
            Color_leftArm = im.ReadInt32();
            Color_rightArm = im.ReadInt32();
            Color_leftLeg = im.ReadInt32();
            Color_rightLeg = im.ReadInt32();
            Color = im.ReadInt32();
        }

        /// <summary>
        /// Serializes the packet data into the outgoing message.
        /// </summary>
        /// <param name="om">The outgoing message to populate with serialized data.</param>
        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(SteamID);
            om.Write(Name);
            om.Write(Zeepkist);
            om.Write(FrontWheels);
            om.Write(RearWheels);
            om.Write(Paraglider);
            om.Write(Horn);
            om.Write(Hat);
            om.Write(Glasses);
            om.Write(Color_body);
            om.Write(Color_leftArm);
            om.Write(Color_rightArm);
            om.Write(Color_leftLeg);
            om.Write(Color_rightLeg);
            om.Write(Color);
        }
    }
}
