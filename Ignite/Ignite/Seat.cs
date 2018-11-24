using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{

        public class Seat : IBinarizable
        {
            [QuerySqlField(IsIndexed = true)]
            public int SeatId
            {
                set;
                get;
            }
            public int ActId
            {
                set;
                get;
            }
            public int SectionId
            {
                set;
                get;
            }
            public int BlockId
            {
                set;
                get;
            }
            public int RowId
            {
                set;
                get;
            }
            public int SeatNo
            {
                set;
                get;
            }
            public Seat(int seatId, int actId, int sectionId, int blockId, int rowId, int seatNo)
            {
                SeatId = seatId;
                ActId = actId;
                SectionId = sectionId;
                BlockId = blockId;
                RowId = rowId;
                SeatNo = seatNo;
            }
            public Seat() { }
            public void WriteBinary(IBinaryWriter writer)
            {
                writer.WriteInt("SeatId", SeatId);
                writer.WriteInt("ActId", ActId);
                writer.WriteInt("SectionId", SectionId);
                writer.WriteInt("BlockId", BlockId);
                writer.WriteInt("RowId", RowId);
                writer.WriteInt("SeatNo", SeatNo);
            }
            public void ReadBinary(IBinaryReader reader)
            {
                SeatId = reader.ReadInt("SeatId");
                ActId = reader.ReadInt("ActId");
                SectionId = reader.ReadInt("SectionId");
                BlockId = reader.ReadInt("BlockId");
                RowId = reader.ReadInt("RowId");
                SeatNo = reader.ReadInt("SeatNo");
            }
        }
}
