using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    public struct ServerRulesResponsePacket : IPacket
    {
        public bool IsAdministrator;
        public bool CanJoin;
        public bool CanCreate;
        public bool CanEdit;
        public bool CanEditAll;
        public bool CanEditFloor;
        public bool CanEditSkybox;
        public bool CanDestroy;
        public int BlockLimit;
        public int BannedBlockCount;
        public List<int> BannedBlocks;

        public void Deserialize(NetIncomingMessage im)
        {
            IsAdministrator = im.ReadBoolean();
            CanJoin = im.ReadBoolean();
            CanCreate = im.ReadBoolean();
            CanEdit = im.ReadBoolean();
            CanEditAll = im.ReadBoolean();
            CanEditFloor = im.ReadBoolean();
            CanEditSkybox = im.ReadBoolean();
            CanDestroy = im.ReadBoolean();
            BlockLimit = im.ReadInt32();

            BannedBlocks = new List<int>();

            BannedBlockCount = im.ReadInt32();
            for (int i = 0; i < BannedBlockCount; i++)
            {
                BannedBlocks.Add(im.ReadInt32());
            }
        }

        public void Serialize(NetOutgoingMessage om)
        {
            om.Write(IsAdministrator);
            om.Write(CanJoin);
            om.Write(CanCreate);
            om.Write(CanEdit);
            om.Write(CanEditAll);
            om.Write(CanEditFloor);
            om.Write(CanEditSkybox);
            om.Write(CanDestroy);
            om.Write(BlockLimit);
            om.Write(BannedBlocks.Count);
            foreach (int bb in BannedBlocks)
            {
                om.Write(bb);
            }
        }
    }
}
