using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamXNetwork
{
    public struct PermissionTableResponse : IPacket
    {
        public List<(ulong, string, string)> permissionTable;
       
        public void Deserialize(NetIncomingMessage im)
        {
            permissionTable = new List<(ulong, string, string)>();

            int count = im.ReadInt32();
            for(int i = 0; i < count; i++)
            {
                permissionTable.Add((im.ReadUInt64(), im.ReadString(), im.ReadString()));
            }
        }

        public void Serialize(NetOutgoingMessage om)
        {
            if(permissionTable == null)
            {
                om.Write(0);
                return;
            }

            om.Write(permissionTable.Count);

            foreach((ulong,string,string) entry in permissionTable)
            {
                om.Write(entry.Item1);
                om.Write(entry.Item2);
                om.Write(entry.Item3);
            }
        }       
    }
}
